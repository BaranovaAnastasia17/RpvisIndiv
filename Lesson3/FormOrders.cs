using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class FormOrders : Form
    {
        public NpgsqlConnection conn;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public FormOrders(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
            Update();
        }
        private void Update()
        {
            string sql = @"SELECT Orders.order_id, Orders.order_date, Client.client_name, 
                     Orders.total_amount
               FROM Orders
               INNER JOIN Client ON Orders.client_id = Client.client_id";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewOrders.DataSource = dt;
            dataGridViewOrders.Columns["order_id"].HeaderText = "Номер";
            dataGridViewOrders.Columns["order_date"].HeaderText = "Дата";
            dataGridViewOrders.Columns["client_name"].HeaderText = "Клиент";
          
            dataGridViewOrders.Columns["total_amount"].HeaderText = "Сумма";
        }
        public void ExportSelectedOrderToExcel(string filePath, int orderId)
        {
            string sqlOrders = @"SELECT o.order_id, o.order_date, c.client_name, o.total_amount
                         FROM Orders o
                         INNER JOIN Client c ON o.client_id = c.client_id
                         WHERE o.order_id = @order_id";

            string sqlOrderProducts = @"SELECT p.product_name, oi.quantity
                                FROM OrderInfo oi
                                INNER JOIN Orders o ON oi.order_id = o.order_id
                                INNER JOIN Product p ON oi.product_id = p.product_id
                                WHERE o.order_id = @order_id";

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Заказ");

                // Заголовки столбцов
                worksheet.Cell(1, 1).Value = "Номер заказа";
                worksheet.Cell(1, 2).Value = "Дата заказа";
                worksheet.Cell(1, 3).Value = "Клиент";
                worksheet.Cell(1, 4).Value = "Сумма";
                worksheet.Cell(1, 5).Value = "Товары";

                int row = 2;

                using (var cmdOrders = new NpgsqlCommand(sqlOrders, conn))
                {
                    cmdOrders.Parameters.AddWithValue("@order_id", orderId);
                    using (var readerOrders = cmdOrders.ExecuteReader())
                    {
                        if (readerOrders.Read())
                        {
                            worksheet.Cell(row, 1).Value = readerOrders.GetInt32(0); // orderID
                            worksheet.Cell(row, 2).Value = readerOrders.GetDateTime(1).ToString("dd.MM.yyyy"); // orderDate
                            worksheet.Cell(row, 3).Value = readerOrders.GetString(2); // clientName
                            worksheet.Cell(row, 4).Value = readerOrders.GetInt32(3); // totalAmount
                        }
                    }
                }

                using (var cmdOrderProducts = new NpgsqlCommand(sqlOrderProducts, conn))
                {
                    cmdOrderProducts.Parameters.AddWithValue("@order_id", orderId);
                    using (var readerOrderProducts = cmdOrderProducts.ExecuteReader())
                    {
                        StringBuilder productsBuilder = new StringBuilder();
                        while (readerOrderProducts.Read())
                        {
                            string productName = readerOrderProducts.GetString(0);
                            int quantity = readerOrderProducts.GetInt32(1);
                            productsBuilder.AppendLine($"- {productName} x {quantity}");
                        }
                        worksheet.Cell(row, 5).Value = productsBuilder.ToString();
                    }
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }
        }
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder(conn);
            formAddOrder.ShowDialog();
            Update();
        }

        private void buttonProductChange_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewOrders.CurrentRow.Cells["order_id"].Value;
            string clientName = (string)dataGridViewOrders.CurrentRow.Cells["client_name"].Value.ToString();

            FormAddOrder formAddOrder = new FormAddOrder(conn, id, clientName);
            formAddOrder.ShowDialog();
            Update();
        }

        private void buttonProductDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewOrders.CurrentRow.Cells["order_id"].Value;
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Orders WHERE order_id = :order_id", conn);
                command.Parameters.AddWithValue("order_id", id);
                command.ExecuteNonQuery();
                Update();
            }
            catch (Exception ex) { }
        }


        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
        
                int selectedOrderId = (int)dataGridViewOrders.CurrentRow.Cells["order_id"].Value;

           

                string rootPath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = $"Заказ_{selectedOrderId}.xlsx";
                string filePath = Path.Combine(rootPath, fileName);

                ExportSelectedOrderToExcel(filePath, selectedOrderId);

                MessageBox.Show("Заказ успешно экспортирован в Excel!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrderProduct formOrderProduct =new FormOrderProduct(this,conn, (int)dataGridViewOrders.CurrentRow.Cells["order_id"].Value);
            formOrderProduct.ShowDialog();
            Update();
        }
    }
}
