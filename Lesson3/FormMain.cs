using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lesson3
{
    public partial class FormMain : Form
    {
        public NpgsqlConnection conn;

        public FormMain()
        {
            InitializeComponent();
            MyLoad();
        }

        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=roma7");
            conn.Open();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(conn);
            formProduct.ShowDialog();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient(conn);
            formClient.ShowDialog();

        }

        private void buttonAllFutura_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice(conn);
            formInvoice.ShowDialog();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders(conn);
            formOrders.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductReport formProductReport = new FormProductReport(conn);
            formProductReport.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClientOrderChart form = new FormClientOrderChart(conn);
            form.ShowDialog();
        }
    }
}
