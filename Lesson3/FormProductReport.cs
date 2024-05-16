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
using System.Windows.Forms.DataVisualization.Charting;

namespace Lesson3
{
    public partial class FormProductReport : Form
    {
        public NpgsqlConnection conn;
        private List<string> selectedProducts = new List<string>();

        public FormProductReport(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProducts();
        }

        private void LoadProducts()
        {
            string sqlProducts = "SELECT product_name FROM Product";

            using (var cmd = new NpgsqlCommand(sqlProducts, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    checkedListBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            selectedProducts.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedProducts.Add(item.ToString());
            }

            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один товар.");
                return;
            }

            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            string sql = $@"SELECT p.product_name, 
                           SUM(CASE WHEN o.order_date BETWEEN @startDate AND @endDate THEN oi.quantity ELSE 0 END) AS total_contracted,
                           SUM(CASE WHEN o.order_date BETWEEN @startDate AND @endDate AND oi.payment_50_received THEN oi.quantity ELSE 0 END) AS total_paid
                    FROM Product p
                    LEFT JOIN OrderInfo oi ON p.product_id = oi.product_id
                    LEFT JOIN Orders o ON oi.order_id = o.order_id
                    WHERE p.product_name IN ({string.Join(",", selectedProducts.Select(c => $"'{c}'"))})
                    GROUP BY p.product_name";

            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["product_name"].HeaderText = "Название товара";
                    dataGridView1.Columns["total_contracted"].HeaderText = "Законтрактовано";
                    dataGridView1.Columns["total_paid"].HeaderText = "Оплачено";

                
                    chart1.Series.Clear();
                    chart1.Series.Add("Законтрактовано");
                    chart1.Series.Add("Оплачено");

                    chart1.Series["Законтрактовано"].ChartType = SeriesChartType.Column;
                    chart1.Series["Оплачено"].ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dt.Rows)
                    {
                        string productName = row["product_name"].ToString();
                        int contracted = Convert.ToInt32(row["total_contracted"]);
                        int paid = Convert.ToInt32(row["total_paid"]);

                        chart1.Series["Законтрактовано"].Points.AddXY(productName, contracted);
                        chart1.Series["Оплачено"].Points.AddXY(productName, paid);
                    }

                    chart1.ChartAreas[0].AxisX.Title = "Товар";
                    chart1.ChartAreas[0].AxisY.Title = "Количество";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormProductReport_Load(object sender, EventArgs e)
        {

        }
    }
}