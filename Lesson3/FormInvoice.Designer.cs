namespace Lesson3
{
    partial class FormInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInvoice = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuInvoiceAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInvoiceProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInvoiceNewInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.dataGridViewInvoiceInfo = new System.Windows.Forms.DataGridView();
            this.labelInvoiceInfo = new System.Windows.Forms.Label();
            this.menuInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAllFutura
            // 
            this.menuInvoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuInvoiceAdd});
            this.menuInvoice.Location = new System.Drawing.Point(0, 0);
            this.menuInvoice.Name = "menuAllFutura";
            this.menuInvoice.Size = new System.Drawing.Size(1182, 31);
            this.menuInvoice.TabIndex = 0;
            this.menuInvoice.Text = "menuStrip1";
            // 
            // toolStripMenuAllFuturaAdd
            // 
            this.toolStripMenuInvoiceAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuInvoiceProduct,
            this.toolStripMenuInvoiceNewInvoice});
            this.toolStripMenuInvoiceAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuInvoiceAdd.Name = "toolStripMenuAllFuturaAdd";
            this.toolStripMenuInvoiceAdd.Size = new System.Drawing.Size(106, 27);
            this.toolStripMenuInvoiceAdd.Text = "Добавить";
            // 
            // toolStripMenuAllFuturaProduct
            // 
            this.toolStripMenuInvoiceProduct.Name = "toolStripMenuAllFuturaProduct";
            this.toolStripMenuInvoiceProduct.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuInvoiceProduct.Text = "Товар";
            // 
            // toolStripMenuAllFuturaNewFutura
            // 
            this.toolStripMenuInvoiceNewInvoice.Name = "toolStripMenuAllFuturaNewFutura";
            this.toolStripMenuInvoiceNewInvoice.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuInvoiceNewInvoice.Text = "Накладная";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 34);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(214, 31);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridViewFutura
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewInvoice.Name = "dataGridViewFutura";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.RowTemplate.Height = 24;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1158, 200);
            this.dataGridViewInvoice.TabIndex = 3;
            // 
            // labelFutura
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(12, 110);
            this.labelInvoice.Name = "labelFutura";
            this.labelInvoice.Size = new System.Drawing.Size(99, 23);
            this.labelInvoice.TabIndex = 4;
            this.labelInvoice.Text = "Накладная";
            // 
            // dataGridViewFuturaInfo
            // 
            this.dataGridViewInvoiceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceInfo.Location = new System.Drawing.Point(12, 365);
            this.dataGridViewInvoiceInfo.Name = "dataGridViewFuturaInfo";
            this.dataGridViewInvoiceInfo.RowHeadersWidth = 51;
            this.dataGridViewInvoiceInfo.RowTemplate.Height = 24;
            this.dataGridViewInvoiceInfo.Size = new System.Drawing.Size(1158, 200);
            this.dataGridViewInvoiceInfo.TabIndex = 5;
            // 
            // labelFuturaInfo
            // 
            this.labelInvoiceInfo.AutoSize = true;
            this.labelInvoiceInfo.Location = new System.Drawing.Point(12, 339);
            this.labelInvoiceInfo.Name = "labelFuturaInfo";
            this.labelInvoiceInfo.Size = new System.Drawing.Size(235, 23);
            this.labelInvoiceInfo.TabIndex = 6;
            this.labelInvoiceInfo.Text = "Информация о накладной";
            // 
            // FormAllFutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.labelInvoiceInfo);
            this.Controls.Add(this.dataGridViewInvoiceInfo);
            this.Controls.Add(this.labelInvoice);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.menuInvoice);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAllFutura";
            this.Text = "FormAllFutura";
            this.menuInvoice.ResumeLayout(false);
            this.menuInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInvoice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInvoiceAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInvoiceProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInvoiceNewInvoice;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceInfo;
        private System.Windows.Forms.Label labelInvoiceInfo;
    }
}