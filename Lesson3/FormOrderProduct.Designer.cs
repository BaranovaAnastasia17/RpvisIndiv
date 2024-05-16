namespace Lesson3
{
    partial class FormOrderProduct
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
            this.buttonProductOrderChange = new System.Windows.Forms.Button();
            this.buttonOrderProductDel = new System.Windows.Forms.Button();
            this.buttonCreateOrderProduct = new System.Windows.Forms.Button();
            this.dataGridViewOrderProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProductOrderChange
            // 
            this.buttonProductOrderChange.AutoSize = true;
            this.buttonProductOrderChange.Location = new System.Drawing.Point(133, 287);
            this.buttonProductOrderChange.Name = "buttonProductOrderChange";
            this.buttonProductOrderChange.Size = new System.Drawing.Size(104, 33);
            this.buttonProductOrderChange.TabIndex = 11;
            this.buttonProductOrderChange.Text = "Изменить";
            this.buttonProductOrderChange.UseVisualStyleBackColor = true;
            this.buttonProductOrderChange.Click += new System.EventHandler(this.buttonProductOrderChange_Click);
            // 
            // buttonOrderProductDel
            // 
            this.buttonOrderProductDel.AutoSize = true;
            this.buttonOrderProductDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOrderProductDel.Location = new System.Drawing.Point(243, 287);
            this.buttonOrderProductDel.Name = "buttonOrderProductDel";
            this.buttonOrderProductDel.Size = new System.Drawing.Size(92, 33);
            this.buttonOrderProductDel.TabIndex = 10;
            this.buttonOrderProductDel.Text = "Удалить";
            this.buttonOrderProductDel.UseVisualStyleBackColor = true;
            // 
            // buttonCreateOrderProduct
            // 
            this.buttonCreateOrderProduct.AutoSize = true;
            this.buttonCreateOrderProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateOrderProduct.Location = new System.Drawing.Point(21, 287);
            this.buttonCreateOrderProduct.Name = "buttonCreateOrderProduct";
            this.buttonCreateOrderProduct.Size = new System.Drawing.Size(106, 33);
            this.buttonCreateOrderProduct.TabIndex = 9;
            this.buttonCreateOrderProduct.Text = "Создать";
            this.buttonCreateOrderProduct.UseVisualStyleBackColor = true;
            this.buttonCreateOrderProduct.Click += new System.EventHandler(this.buttonCreateOrderProduct_Click);
            // 
            // dataGridViewOrderProduct
            // 
            this.dataGridViewOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderProduct.Location = new System.Drawing.Point(21, 131);
            this.dataGridViewOrderProduct.Name = "dataGridViewOrderProduct";
            this.dataGridViewOrderProduct.RowHeadersWidth = 51;
            this.dataGridViewOrderProduct.RowTemplate.Height = 24;
            this.dataGridViewOrderProduct.Size = new System.Drawing.Size(758, 150);
            this.dataGridViewOrderProduct.TabIndex = 8;
            // 
            // FormOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProductOrderChange);
            this.Controls.Add(this.buttonOrderProductDel);
            this.Controls.Add(this.buttonCreateOrderProduct);
            this.Controls.Add(this.dataGridViewOrderProduct);
            this.Name = "FormOrderProduct";
            this.Text = "FormOrderProduct";
            this.Load += new System.EventHandler(this.FormOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProductOrderChange;
        private System.Windows.Forms.Button buttonOrderProductDel;
        private System.Windows.Forms.Button buttonCreateOrderProduct;
        private System.Windows.Forms.DataGridView dataGridViewOrderProduct;
    }
}