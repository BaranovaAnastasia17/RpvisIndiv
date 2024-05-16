namespace Lesson3
{
    partial class FormOrders
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
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonProductChange = new System.Windows.Forms.Button();
            this.buttonProductDel = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.AutoSize = true;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateOrder.Location = new System.Drawing.Point(12, 168);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(106, 33);
            this.buttonCreateOrder.TabIndex = 5;
            this.buttonCreateOrder.Text = "Создать";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(758, 150);
            this.dataGridViewOrders.TabIndex = 4;
            // 
            // buttonProductChange
            // 
            this.buttonProductChange.AutoSize = true;
            this.buttonProductChange.Location = new System.Drawing.Point(124, 168);
            this.buttonProductChange.Name = "buttonProductChange";
            this.buttonProductChange.Size = new System.Drawing.Size(104, 33);
            this.buttonProductChange.TabIndex = 7;
            this.buttonProductChange.Text = "Изменить";
            this.buttonProductChange.UseVisualStyleBackColor = true;
            this.buttonProductChange.Click += new System.EventHandler(this.buttonProductChange_Click);
            // 
            // buttonProductDel
            // 
            this.buttonProductDel.AutoSize = true;
            this.buttonProductDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductDel.Location = new System.Drawing.Point(234, 168);
            this.buttonProductDel.Name = "buttonProductDel";
            this.buttonProductDel.Size = new System.Drawing.Size(92, 33);
            this.buttonProductDel.TabIndex = 6;
            this.buttonProductDel.Text = "Удалить";
            this.buttonProductDel.UseVisualStyleBackColor = true;
            this.buttonProductDel.Click += new System.EventHandler(this.buttonProductDel_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.AutoSize = true;
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExportExcel.Location = new System.Drawing.Point(776, 12);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(120, 33);
            this.buttonExportExcel.TabIndex = 8;
            this.buttonExportExcel.Text = "Экспорт накладной";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Товары";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.buttonProductChange);
            this.Controls.Add(this.buttonProductDel);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonProductChange;
        private System.Windows.Forms.Button buttonProductDel;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button button1;
    }
}