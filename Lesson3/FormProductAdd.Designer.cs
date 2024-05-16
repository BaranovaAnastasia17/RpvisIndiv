namespace Lesson3
{
    partial class FormProductAdd
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.buttonProductAddYes = new System.Windows.Forms.Button();
            this.buttonProductAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(13, 36);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(229, 25);
            this.textBoxProductName.TabIndex = 0;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(13, 96);
            this.textBoxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(229, 25);
            this.textBoxProductPrice.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(13, 9);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(116, 20);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Наименование";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(13, 69);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(45, 20);
            this.labelProductPrice.TabIndex = 3;
            this.labelProductPrice.Text = "Цена";
            // 
            // buttonProductAddYes
            // 
            this.buttonProductAddYes.AutoSize = true;
            this.buttonProductAddYes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductAddYes.Location = new System.Drawing.Point(12, 132);
            this.buttonProductAddYes.Name = "buttonProductAddYes";
            this.buttonProductAddYes.Size = new System.Drawing.Size(135, 33);
            this.buttonProductAddYes.TabIndex = 4;
            this.buttonProductAddYes.Text = "Подтвердить";
            this.buttonProductAddYes.UseVisualStyleBackColor = true;
            this.buttonProductAddYes.Click += new System.EventHandler(this.buttonProductAddYes_Click);
            // 
            // buttonProductAddCancel
            // 
            this.buttonProductAddCancel.AutoSize = true;
            this.buttonProductAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductAddCancel.Location = new System.Drawing.Point(153, 132);
            this.buttonProductAddCancel.Name = "buttonProductAddCancel";
            this.buttonProductAddCancel.Size = new System.Drawing.Size(89, 33);
            this.buttonProductAddCancel.TabIndex = 5;
            this.buttonProductAddCancel.Text = "Отмена";
            this.buttonProductAddCancel.UseVisualStyleBackColor = true;
            this.buttonProductAddCancel.Click += new System.EventHandler(this.buttonProductAddCancel_Click);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.buttonProductAddCancel);
            this.Controls.Add(this.buttonProductAddYes);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductAdd";
            this.Text = "FormProductAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Button buttonProductAddYes;
        private System.Windows.Forms.Button buttonProductAddCancel;
    }
}