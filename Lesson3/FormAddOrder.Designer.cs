namespace Lesson3
{
    partial class FormAddOrder
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
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonOrderYes = new System.Windows.Forms.Button();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.AutoSize = true;
            this.buttonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOrderCancel.Location = new System.Drawing.Point(164, 139);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(89, 33);
            this.buttonOrderCancel.TabIndex = 11;
            this.buttonOrderCancel.Text = "Отмена";
            this.buttonOrderCancel.UseVisualStyleBackColor = true;
            this.buttonOrderCancel.Click += new System.EventHandler(this.buttonOrderCancel_Click);
            // 
            // buttonOrderYes
            // 
            this.buttonOrderYes.AutoSize = true;
            this.buttonOrderYes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOrderYes.Location = new System.Drawing.Point(3, 139);
            this.buttonOrderYes.Name = "buttonOrderYes";
            this.buttonOrderYes.Size = new System.Drawing.Size(135, 33);
            this.buttonOrderYes.TabIndex = 10;
            this.buttonOrderYes.Text = "Подтвердить";
            this.buttonOrderYes.UseVisualStyleBackColor = true;
            this.buttonOrderYes.Click += new System.EventHandler(this.buttonOrderYes_Click);
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(13, 175);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(0, 13);
            this.labelProductPrice.TabIndex = 9;
            this.labelProductPrice.Click += new System.EventHandler(this.labelProductPrice_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(13, 12);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(43, 13);
            this.labelProductName.TabIndex = 8;
            this.labelProductName.Text = "Клиент";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(16, 28);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(214, 21);
            this.comboBoxUsers.TabIndex = 12;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 188);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 13);
            this.labelPrice.TabIndex = 17;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.buttonOrderCancel);
            this.Controls.Add(this.buttonOrderYes);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductName);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Button buttonOrderYes;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label labelPrice;
    }
}