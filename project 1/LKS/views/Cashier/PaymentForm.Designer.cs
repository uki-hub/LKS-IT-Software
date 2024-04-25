namespace LKS.views.Cashier
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
            this.InputPaymentType = new System.Windows.Forms.ComboBox();
            this.InputBankName = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputOrderId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPaymentType
            // 
            this.InputPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputPaymentType.FormattingEnabled = true;
            this.InputPaymentType.Location = new System.Drawing.Point(334, 421);
            this.InputPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.InputPaymentType.Name = "InputPaymentType";
            this.InputPaymentType.Size = new System.Drawing.Size(277, 24);
            this.InputPaymentType.TabIndex = 60;
            // 
            // InputBankName
            // 
            this.InputBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputBankName.FormattingEnabled = true;
            this.InputBankName.Location = new System.Drawing.Point(334, 512);
            this.InputBankName.Margin = new System.Windows.Forms.Padding(4);
            this.InputBankName.Name = "InputBankName";
            this.InputBankName.Size = new System.Drawing.Size(277, 24);
            this.InputBankName.TabIndex = 59;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(391, 558);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 35);
            this.BtnSave.TabIndex = 58;
            this.BtnSave.Text = "PAY";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Bank Name";
            // 
            // InputCardNumber
            // 
            this.InputCardNumber.Location = new System.Drawing.Point(334, 464);
            this.InputCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.InputCardNumber.Name = "InputCardNumber";
            this.InputCardNumber.Size = new System.Drawing.Size(277, 22);
            this.InputCardNumber.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 467);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Card Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 424);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Payment Type";
            // 
            // InputOrderId
            // 
            this.InputOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputOrderId.FormattingEnabled = true;
            this.InputOrderId.Location = new System.Drawing.Point(333, 63);
            this.InputOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.InputOrderId.Name = "InputOrderId";
            this.InputOrderId.Size = new System.Drawing.Size(277, 24);
            this.InputOrderId.TabIndex = 53;
            this.InputOrderId.SelectedValueChanged += new System.EventHandler(this.InputOrderId_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Order Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Payment";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(13, 115);
            this.Table.Margin = new System.Windows.Forms.Padding(4);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersWidth = 51;
            this.Table.Size = new System.Drawing.Size(844, 282);
            this.Table.TabIndex = 50;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(619, 401);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(79, 20);
            this.LabelTotal.TabIndex = 61;
            this.LabelTotal.Text = "Total : 0";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(61, 36);
            this.back.TabIndex = 62;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 606);
            this.Controls.Add(this.back);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.InputPaymentType);
            this.Controls.Add(this.InputBankName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputOrderId);
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

        private System.Windows.Forms.ComboBox InputPaymentType;
        private System.Windows.Forms.ComboBox InputBankName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox InputOrderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button back;
    }
}