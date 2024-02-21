namespace C3
{
    partial class ChangePasswordForm
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
            this.InputConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputConfirmPassword
            // 
            this.InputConfirmPassword.Location = new System.Drawing.Point(127, 118);
            this.InputConfirmPassword.Name = "InputConfirmPassword";
            this.InputConfirmPassword.Size = new System.Drawing.Size(201, 20);
            this.InputConfirmPassword.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Confirm Password";
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Location = new System.Drawing.Point(127, 82);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.Size = new System.Drawing.Size(201, 20);
            this.InputNewPassword.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "New Password";
            // 
            // InputOldPassword
            // 
            this.InputOldPassword.Location = new System.Drawing.Point(127, 47);
            this.InputOldPassword.Name = "InputOldPassword";
            this.InputOldPassword.Size = new System.Drawing.Size(201, 20);
            this.InputOldPassword.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Form Change Password";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(127, 163);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(92, 40);
            this.BtnSave.TabIndex = 38;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.InputConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputOldPassword);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputOldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
    }
}