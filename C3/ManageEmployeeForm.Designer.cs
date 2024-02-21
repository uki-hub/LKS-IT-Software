namespace C3
{
    partial class ManageEmployeeForm
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.InputEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputHandphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.InputPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(8, 46);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(633, 229);
            this.Table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form Manage Employee";
            // 
            // InputEmployeeId
            // 
            this.InputEmployeeId.Location = new System.Drawing.Point(260, 294);
            this.InputEmployeeId.Name = "InputEmployeeId";
            this.InputEmployeeId.Size = new System.Drawing.Size(209, 20);
            this.InputEmployeeId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EmployeeId";
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(260, 329);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(209, 20);
            this.InputName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // InputHandphone
            // 
            this.InputHandphone.Location = new System.Drawing.Point(260, 400);
            this.InputHandphone.Name = "InputHandphone";
            this.InputHandphone.Size = new System.Drawing.Size(209, 20);
            this.InputHandphone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Handphone";
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(260, 365);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(209, 20);
            this.InputEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(173, 482);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(92, 40);
            this.BtnInsert.TabIndex = 13;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(284, 482);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(92, 40);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(398, 482);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(92, 40);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // InputPosition
            // 
            this.InputPosition.FormattingEnabled = true;
            this.InputPosition.Location = new System.Drawing.Point(260, 438);
            this.InputPosition.Name = "InputPosition";
            this.InputPosition.Size = new System.Drawing.Size(209, 21);
            this.InputPosition.TabIndex = 16;
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 543);
            this.Controls.Add(this.InputPosition);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputHandphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table);
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputHandphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox InputPosition;
    }
}