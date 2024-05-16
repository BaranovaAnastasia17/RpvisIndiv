using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class FormAddOrderProduct : Form
    {
        public NpgsqlConnection conn;
        DataTable products = new DataTable();
        DataSet dsProducts = new DataSet();
        public int orderID;
        public string productName;
        public int orderInfoID;
        public int quantity;
        public bool delivered;
        public bool payment50Received;
        // Конструктор для добавления новой записи
        public FormAddOrderProduct(NpgsqlConnection conn, int orderID)
        {
            InitializeComponent();
            this.conn = conn;
            this.orderID = orderID;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProducts();
        }

        // Конструктор для редактирования существующей записи
        public FormAddOrderProduct(NpgsqlConnection conn, int orderID, int orderInfoID, string productName, int quantity, bool delivered, bool payment50Received)
        {
            InitializeComponent();
            this.conn = conn;
            this.orderID = orderID;
            this.orderInfoID = orderInfoID;
            this.productName = productName;
            this.quantity = quantity;
            this.delivered = delivered;
            this.payment50Received = payment50Received;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProducts();

            // Установка значений в элементы управления
            comboBoxProduct.SelectedIndex = comboBoxProduct.FindStringExact(productName);
            numericUpDownQuantity.Value = quantity;
            checkBoxDelivered.Checked = delivered;
            checkBoxPayment50Received.Checked = payment50Received;
        }

        private void LoadProducts()
        {
            String sqlProducts = "Select * from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlProducts, conn);
            dsProducts.Reset();
            da.Fill(dsProducts);
            products = dsProducts.Tables[0];

            var productList = dsProducts.Tables[0].AsEnumerable().Select(row => new
            {
                Id = row.Field<int>("product_id"),
                Name = row.Field<string>("product_name"),
                Price = row.Field<int>("product_price")
            }).ToList();

            comboBoxProduct.DataSource = productList;
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "Id";
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null)
            {
                var selectedProduct = (dynamic)comboBoxProduct.SelectedItem;
                int totalPrice = selectedProduct.Price * (int)(numericUpDownQuantity.Value);
                label3.Text = totalPrice.ToString(); 
            }
        }

        private void buttonOrderProductCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOrderProductYes_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = (int)comboBoxProduct.SelectedValue;
                int quantity = (int)numericUpDownQuantity.Value;
                bool delivered = checkBoxDelivered.Checked;
                bool payment50Received = checkBoxPayment50Received.Checked;
                if (orderInfoID == 0) 
                {
                    string sql = @"INSERT INTO OrderInfo (order_id, product_id, quantity, delivered,payment_50_received) 
                                    VALUES (@orderID, @productID, @quantity, @delivered, @payment_50_received)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        cmd.Parameters.AddWithValue("@productID", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@delivered", delivered);
                        cmd.Parameters.AddWithValue("@delivered", delivered);
                        cmd.Parameters.AddWithValue("@payment_50_received", payment50Received);
                        cmd.ExecuteNonQuery();
                    }
                }
                else 
                {
                    string sql = @"UPDATE OrderInfo 
                                   SET product_id = @productID, quantity = @quantity, delivered = @delivered, payment_50_received = @payment_50_received
                                   WHERE orderinfo_id = @orderInfoID";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@productID", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@delivered", delivered);
                        cmd.Parameters.AddWithValue("@orderInfoID", orderInfoID);
                        cmd.Parameters.AddWithValue("@payment_50_received", payment50Received);
                        cmd.ExecuteNonQuery();
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddOrderProduct_Load(object sender, EventArgs e)
        {

        }
    }
}