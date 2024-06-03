namespace LKS_Hospital.view.Master
{
    partial class MasterPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.lblLastUpdatedAt = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtGenderPatient = new System.Windows.Forms.TextBox();
            this.txtAddressPatient = new System.Windows.Forms.TextBox();
            this.txtEmailPatient = new System.Windows.Forms.TextBox();
            this.txtPhonePatient = new System.Windows.Forms.TextBox();
            this.txtNamePatient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Patient";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(80, 57);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(132, 22);
            this.txtSearchPatient.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(16, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 213);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(155, 532);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 16);
            this.labelTime.TabIndex = 44;
            // 
            // lblLastUpdatedAt
            // 
            this.lblLastUpdatedAt.AutoSize = true;
            this.lblLastUpdatedAt.Location = new System.Drawing.Point(25, 532);
            this.lblLastUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUpdatedAt.Name = "lblLastUpdatedAt";
            this.lblLastUpdatedAt.Size = new System.Drawing.Size(100, 16);
            this.lblLastUpdatedAt.TabIndex = 43;
            this.lblLastUpdatedAt.Text = "Last updated at";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Enabled = false;
            this.txtBloodType.Location = new System.Drawing.Point(545, 438);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(193, 22);
            this.txtBloodType.TabIndex = 42;
            // 
            // txtGenderPatient
            // 
            this.txtGenderPatient.Enabled = false;
            this.txtGenderPatient.Location = new System.Drawing.Point(545, 400);
            this.txtGenderPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenderPatient.Name = "txtGenderPatient";
            this.txtGenderPatient.Size = new System.Drawing.Size(193, 22);
            this.txtGenderPatient.TabIndex = 41;
            // 
            // txtAddressPatient
            // 
            this.txtAddressPatient.Enabled = false;
            this.txtAddressPatient.Location = new System.Drawing.Point(545, 326);
            this.txtAddressPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressPatient.Multiline = true;
            this.txtAddressPatient.Name = "txtAddressPatient";
            this.txtAddressPatient.Size = new System.Drawing.Size(193, 66);
            this.txtAddressPatient.TabIndex = 40;
            // 
            // txtEmailPatient
            // 
            this.txtEmailPatient.Enabled = false;
            this.txtEmailPatient.Location = new System.Drawing.Point(193, 399);
            this.txtEmailPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPatient.Name = "txtEmailPatient";
            this.txtEmailPatient.Size = new System.Drawing.Size(193, 22);
            this.txtEmailPatient.TabIndex = 37;
            // 
            // txtPhonePatient
            // 
            this.txtPhonePatient.Enabled = false;
            this.txtPhonePatient.Location = new System.Drawing.Point(193, 362);
            this.txtPhonePatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhonePatient.Name = "txtPhonePatient";
            this.txtPhonePatient.Size = new System.Drawing.Size(193, 22);
            this.txtPhonePatient.TabIndex = 36;
            // 
            // txtNamePatient
            // 
            this.txtNamePatient.Enabled = false;
            this.txtNamePatient.Location = new System.Drawing.Point(193, 326);
            this.txtNamePatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamePatient.Name = "txtNamePatient";
            this.txtNamePatient.Size = new System.Drawing.Size(193, 22);
            this.txtNamePatient.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 442);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "BloodType";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 405);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(193, 440);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(193, 22);
            this.txtDateOfBirth.TabIndex = 45;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phone Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date of Birth";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Blood Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // MasterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 581);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lblLastUpdatedAt);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.txtGenderPatient);
            this.Controls.Add(this.txtAddressPatient);
            this.Controls.Add(this.txtEmailPatient);
            this.Controls.Add(this.txtPhonePatient);
            this.Controls.Add(this.txtNamePatient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MasterPatient_FormClosed);
            this.Load += new System.EventHandler(this.MasterPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label lblLastUpdatedAt;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtGenderPatient;
        private System.Windows.Forms.TextBox txtAddressPatient;
        private System.Windows.Forms.TextBox txtEmailPatient;
        private System.Windows.Forms.TextBox txtPhonePatient;
        private System.Windows.Forms.TextBox txtNamePatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}