namespace RumahSakit.View.Resepsionis
{
    partial class ResepsionisPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Daftar Pasien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Daftar Membership";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 57);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(932, 437);
            this.table.TabIndex = 3;
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(12, 19);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(64, 25);
            this.lblWaktu.TabIndex = 4;
            this.lblWaktu.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nomor Urut: 1";
            // 
            // ResepsionisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ResepsionisPage";
            this.Text = "ResepsionisPage";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label label1;
    }
}