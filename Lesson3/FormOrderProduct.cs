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
    public partial class FormOrderProduct : Form
    {
        public NpgsqlConnection conn;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int selectedOrderID;
        FormOrders f;
        public FormOrderProduct(FormOrders f, NpgsqlConnection conn, int selectedOrderID)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.selectedOrderID = selectedOrderID;
            this.f = f;
            Update();
        }

        private void Update()
        {
            // Проверяем, выбран ли заказ
            if (selectedOrderID > 0)
            {
                string sql = @"SELECT oi.orderinfo_id, o.order_id, o.order_date, c.client_name, 
                            p.product_name, oi.quantity, oi.delivered, oi.payment_50_received
                     FROM OrderInfo oi
                     INNER JOIN Orders o ON oi.order_id = o.order_id
                     INNER JOIN Client c ON o.client_id = c.client_id
                     INNER JOIN Product p ON oi.product_id = p.product_id
                     WHERE o.order_id = @order_id";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@order_id", selectedOrderID);

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridViewOrderProduct.DataSource = dt;

                // Настройка заголовков столбцов
                dataGridViewOrderProduct.Columns["orderinfo_id"].HeaderText = "ID";
                dataGridViewOrderProduct.Columns["order_id"].HeaderText = "Номер заказа";
                dataGridViewOrderProduct.Columns["order_date"].HeaderText = "Дата заказа";
                dataGridViewOrderProduct.Columns["client_name"].HeaderText = "Клиент";
                dataGridViewOrderProduct.Columns["product_name"].HeaderText = "Товар";
                dataGridViewOrderProduct.Columns["quantity"].HeaderText = "Количество";
                dataGridViewOrderProduct.Columns["delivered"].HeaderText = "Доставлено";
                dataGridViewOrderProduct.Columns["payment_50_received"].HeaderText = "50% оплаты";
            }
            else
            {
                // Если заказ не выбран, очищаем DataGridView
                dataGridViewOrderProduct.DataSource = null;
            }
        }

        // Обработчик события клика по строке в DataGridView
        private void dataGridViewOrderProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получаем ID выбранного заказа из строки DataGridView
                selectedOrderID = Convert.ToInt32(dataGridViewOrderProduct.Rows[e.RowIndex].Cells["order_id"].Value);

                // Обновляем данные в DataGridView
                Update();
            }
        }

        private void FormOrderProduct_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateOrderProduct_Click(object sender, EventArgs e)
        {
            FormAddOrderProduct formAddOrderProduct = new FormAddOrderProduct(conn, selectedOrderID);
            formAddOrderProduct.ShowDialog();
            Update();
        }

        private void buttonProductOrderChange_Click(object sender, EventArgs e)
        {
            FormAddOrderProduct formAddOrderProduct = new FormAddOrderProduct(
                conn, selectedOrderID, 
                (int)dataGridViewOrderProduct.CurrentRow.Cells["orderinfo_id"].Value,
                (string)dataGridViewOrderProduct.CurrentRow.Cells["product_name"].Value, 
                (int)dataGridViewOrderProduct.CurrentRow.Cells["quantity"].Value,
                (Boolean)dataGridViewOrderProduct.CurrentRow.Cells["delivered"].Value,
                (Boolean)dataGridViewOrderProduct.CurrentRow.Cells["payment_50_received"].Value
                );
            formAddOrderProduct.ShowDialog();
            Update();
        }
    }
}
