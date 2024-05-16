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
    public partial class FormInvoice : Form

    {
        public NpgsqlConnection conn;
        DataTable clients = new DataTable();
        DataSet ds = new DataSet();

        public FormInvoice(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadClients();
        }
        private void LoadClients()
        {
            String sqlClients = "Select * from Client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlClients, conn);
            ds.Reset();
            da.Fill(ds);
            clients = ds.Tables[0];
            var clientList = ds.Tables[0].AsEnumerable().Select(row => new
            {
                Id = row.Field<int>("client_id"),
                Name = row.Field<string>("client_name")
            }).ToList();

        
            comboBoxUsers.DataSource = clientList;
            comboBoxUsers.DisplayMember = "Name";  
            comboBoxUsers.ValueMember = "Id";
        }
    }
}
