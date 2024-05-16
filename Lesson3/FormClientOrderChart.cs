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
    public partial class FormClientOrderChart : Form
    {
        public NpgsqlConnection conn;
        private List<string> selectedClients = new List<string>();

        public FormClientOrderChart(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadClients();
        }

        private void LoadClients()
        {
            string sqlClients = "SELECT client_name FROM Client";

            using (var cmd = new NpgsqlCommand(sqlClients, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    checkedListBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void buttonGenerateChart_Click(object sender, EventArgs e)
        {
            selectedClients.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedClients.Add(item.ToString());
            }

            if (selectedClients.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одного клиента.");
                return;
            }

            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            string sql = $@"SELECT c.client_name, 
                           SUM(CASE WHEN oi.payment_50_received THEN oi.quantity * p.product_price ELSE 0 END) AS total_to_be_shipped,
                           SUM(CASE WHEN oi.delivered THEN oi.quantity * p.product_price ELSE 0 END) AS total_shipped
                    FROM Client c
                    INNER JOIN Orders o ON c.client_id = o.client_id
                    INNER JOIN OrderInfo oi ON o.order_id = oi.order_id
                    INNER JOIN Product p ON oi.product_id = p.product_id
                    WHERE c.client_name IN ({string.Join(",", selectedClients.Select(c => $"'{c}'"))})
                    AND o.order_date BETWEEN @startDate AND @endDate
                    GROUP BY c.client_name";

            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                 
                    if (!dataGridView1.Columns.Contains("ClientName"))
                        dataGridView1.Columns.Add("ClientName", "Клиент");
                    if (!dataGridView1.Columns.Contains("ToBeShipped"))
                        dataGridView1.Columns.Add("ToBeShipped", "Подлежит отгрузке");
                    if (!dataGridView1.Columns.Contains("Shipped"))
                        dataGridView1.Columns.Add("Shipped", "Отгружено");

                   
                    dataGridView1.Rows.Clear();

                   
                    foreach (DataRow row in dt.Rows)
                    {
                        string clientName = row["client_name"].ToString();
                        decimal toBeShipped = Convert.ToDecimal(row["total_to_be_shipped"]);
                        decimal shipped = Convert.ToDecimal(row["total_shipped"]);

                        dataGridView1.Rows.Add(clientName, toBeShipped, shipped);
                    }

      
                    chart1.Series.Clear();

           
                    chart1.Series.Add("Подлежит отгрузке");
                    chart1.Series.Add("Отгружено");

             
                    chart1.Series["Подлежит отгрузке"].ChartType = SeriesChartType.Column;
                    chart1.Series["Отгружено"].ChartType = SeriesChartType.Column;

              
                    foreach (DataRow row in dt.Rows)
                    {
                        string clientName = row["client_name"].ToString();
                        decimal toBeShipped = Convert.ToDecimal(row["total_to_be_shipped"]);
                        decimal shipped = Convert.ToDecimal(row["total_shipped"]);

                        chart1.Series["Подлежит отгрузке"].Points.AddXY(clientName, toBeShipped);
                        chart1.Series["Отгружено"].Points.AddXY(clientName, shipped);
                    }

          
                    chart1.ChartAreas[0].AxisX.Title = "Клиент";
                    chart1.ChartAreas[0].AxisY.Title = "Сумма";
                }
            }
        }

        private void checkedListBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormClientOrderChart_Load(object sender, EventArgs e)
        {

        }
    }
}