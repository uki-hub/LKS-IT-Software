﻿namespace LKS_Hospital.view.Master
{
    partial class MasterDoctor
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblLastUpdatedAt = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.PhoneNumber,
            this.Email,
            this.DateOfBirth,
            this.Category,
            this.Address,
            this.Gender,
            this.AssignedRoom});
            this.dataGridView1.Location = new System.Drawing.Point(16, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 250);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Location = new System.Drawing.Point(589, 57);
            this.txtSearchDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(174, 22);
            this.txtSearchDoctor.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(771, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 497);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 534);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 474);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 511);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Assigned Room";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(187, 380);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(187, 415);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(193, 22);
            this.txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(187, 452);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(187, 534);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(193, 22);
            this.txtCategory.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(539, 380);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 70);
            this.txtAddress.TabIndex = 21;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(539, 470);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(193, 22);
            this.txtGender.TabIndex = 23;
            // 
            // txtRoom
            // 
            this.txtRoom.Enabled = false;
            this.txtRoom.Location = new System.Drawing.Point(539, 508);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(193, 22);
            this.txtRoom.TabIndex = 24;
            // 
            // lblLastUpdatedAt
            // 
            this.lblLastUpdatedAt.AutoSize = true;
            this.lblLastUpdatedAt.Location = new System.Drawing.Point(19, 585);
            this.lblLastUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUpdatedAt.Name = "lblLastUpdatedAt";
            this.lblLastUpdatedAt.Size = new System.Drawing.Size(100, 16);
            this.lblLastUpdatedAt.TabIndex = 25;
            this.lblLastUpdatedAt.Text = "Last updated at";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(148, 585);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 16);
            this.labelTime.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(187, 494);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(193, 22);
            this.txtDateOfBirth.TabIndex = 27;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // AssignedRoom
            // 
            this.AssignedRoom.HeaderText = "Assigned Room";
            this.AssignedRoom.Name = "AssignedRoom";
            this.AssignedRoom.ReadOnly = true;
            // 
            // MasterDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 628);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lblLastUpdatedAt);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MasterDoctor_FormClosed);
            this.Load += new System.EventHandler(this.MasterDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblLastUpdatedAt;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedRoom;
    }
}