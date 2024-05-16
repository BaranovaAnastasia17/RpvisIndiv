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
    public partial class FormProductAdd : Form
    {
        public NpgsqlConnection conn;
        public int productId = -1;
        public string productName;
        public int productPrice;

        public FormProductAdd(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormProductAdd(NpgsqlConnection conn, int productId, string productName, int productPrice)
        {
            InitializeComponent();
            this.conn = conn;
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            textBoxProductName.Text = productName;
            textBoxProductPrice.Text = productPrice.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonProductAddYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.productId == -1)
                {
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Product (product_name, product_price) VALUES (:product_name, :product_price)", conn);
                    command.Parameters.AddWithValue("product_name", textBoxProductName.Text);
                    command.Parameters.AddWithValue("product_price", int.Parse(textBoxProductPrice.Text));
                    command.ExecuteNonQuery();
                    Close();
                }
                else
                {
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE Product SET product_name = :product_name, product_price = :product_price WHERE product_id = :product_id", conn);
                    command.Parameters.AddWithValue("product_id", this.productId);
                    command.Parameters.AddWithValue("product_name", textBoxProductName.Text);
                    command.Parameters.AddWithValue("product_price", int.Parse(textBoxProductPrice.Text));
                    command.ExecuteNonQuery();
                    Close();
                }
            }
            catch (Exception ex) {
            }
        }

        private void buttonProductAddCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
