namespace Lesson3
{
    partial class FormAddOrderProduct
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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonOrderYes = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDelivered = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPayment50Received = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(45, 49);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(214, 21);
            this.comboBoxProduct.TabIndex = 16;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.AutoSize = true;
            this.buttonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOrderCancel.Location = new System.Drawing.Point(206, 240);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(89, 33);
            this.buttonOrderCancel.TabIndex = 15;
            this.buttonOrderCancel.Text = "Отмена";
            this.buttonOrderCancel.UseVisualStyleBackColor = true;
            this.buttonOrderCancel.Click += new System.EventHandler(this.buttonOrderProductCancel_Click);
            // 
            // buttonOrderYes
            // 
            this.buttonOrderYes.AutoSize = true;
            this.buttonOrderYes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOrderYes.Location = new System.Drawing.Point(45, 240);
            this.buttonOrderYes.Name = "buttonOrderYes";
            this.buttonOrderYes.Size = new System.Drawing.Size(135, 33);
            this.buttonOrderYes.TabIndex = 14;
            this.buttonOrderYes.Text = "Подтвердить";
            this.buttonOrderYes.UseVisualStyleBackColor = true;
            this.buttonOrderYes.Click += new System.EventHandler(this.buttonOrderProductYes_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(42, 33);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 13);
            this.labelProductName.TabIndex = 13;
            this.labelProductName.Text = "Продукт";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(45, 108);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 17;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // checkBoxDelivered
            // 
            this.checkBoxDelivered.AutoSize = true;
            this.checkBoxDelivered.Location = new System.Drawing.Point(45, 167);
            this.checkBoxDelivered.Name = "checkBoxDelivered";
            this.checkBoxDelivered.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDelivered.TabIndex = 18;
            this.checkBoxDelivered.Text = "Доставлен";
            this.checkBoxDelivered.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "0";
            // 
            // checkBoxPayment50Received
            // 
            this.checkBoxPayment50Received.AutoSize = true;
            this.checkBoxPayment50Received.Location = new System.Drawing.Point(213, 167);
            this.checkBoxPayment50Received.Name = "checkBoxPayment50Received";
            this.checkBoxPayment50Received.Size = new System.Drawing.Size(86, 17);
            this.checkBoxPayment50Received.TabIndex = 22;
            this.checkBoxPayment50Received.Text = "Оплата 50%";
            this.checkBoxPayment50Received.UseVisualStyleBackColor = true;
            // 
            // FormAddOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxPayment50Received);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDelivered);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.buttonOrderCancel);
            this.Controls.Add(this.buttonOrderYes);
            this.Controls.Add(this.labelProductName);
            this.Name = "FormAddOrderProduct";
            this.Text = "FormAddOrderProduct";
            this.Load += new System.EventHandler(this.FormAddOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Button buttonOrderYes;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.CheckBox checkBoxDelivered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxPayment50Received;
    }
}