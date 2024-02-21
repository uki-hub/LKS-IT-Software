namespace C3
{
    partial class PaymentForm
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
            this.InputPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.InputBankName = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputPaymentType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPosition
            // 
            this.InputPosition.FormattingEnabled = true;
            this.InputPosition.Location = new System.Drawing.Point(246, 43);
            this.InputPosition.Name = "InputPosition";
            this.InputPosition.Size = new System.Drawing.Size(209, 21);
            this.InputPosition.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Order Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Form View Order";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(6, 85);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(633, 229);
            this.Table.TabIndex = 32;
            // 
            // InputBankName
            // 
            this.InputBankName.FormattingEnabled = true;
            this.InputBankName.Location = new System.Drawing.Point(263, 406);
            this.InputBankName.Name = "InputBankName";
            this.InputBankName.Size = new System.Drawing.Size(209, 21);
            this.InputBankName.TabIndex = 48;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(284, 443);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(92, 40);
            this.BtnUpdate.TabIndex = 46;
            this.BtnUpdate.Text = "Save";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Bank Name";
            // 
            // InputCardNumber
            // 
            this.InputCardNumber.Location = new System.Drawing.Point(263, 367);
            this.InputCardNumber.Name = "InputCardNumber";
            this.InputCardNumber.Size = new System.Drawing.Size(209, 20);
            this.InputCardNumber.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Card Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Payment Type";
            // 
            // InputPaymentType
            // 
            this.InputPaymentType.FormattingEnabled = true;
            this.InputPaymentType.Location = new System.Drawing.Point(263, 332);
            this.InputPaymentType.Name = "InputPaymentType";
            this.InputPaymentType.Size = new System.Drawing.Size(209, 21);
            this.InputPaymentType.TabIndex = 49;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 498);
            this.Controls.Add(this.InputPaymentType);
            this.Controls.Add(this.InputBankName);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox InputBankName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox InputPaymentType;
    }
}