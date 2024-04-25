namespace LKS.views
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.InputConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Form Change Password";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(157, 199);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 49);
            this.BtnSave.TabIndex = 47;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // InputConfirmPassword
            // 
            this.InputConfirmPassword.Location = new System.Drawing.Point(157, 143);
            this.InputConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.InputConfirmPassword.Name = "InputConfirmPassword";
            this.InputConfirmPassword.Size = new System.Drawing.Size(267, 22);
            this.InputConfirmPassword.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Confirm Password";
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Location = new System.Drawing.Point(157, 99);
            this.InputNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.Size = new System.Drawing.Size(267, 22);
            this.InputNewPassword.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "New Password";
            // 
            // InputOldPassword
            // 
            this.InputOldPassword.Location = new System.Drawing.Point(157, 56);
            this.InputOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.InputOldPassword.Name = "InputOldPassword";
            this.InputOldPassword.Size = new System.Drawing.Size(267, 22);
            this.InputOldPassword.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Old Password";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 9);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(61, 36);
            this.back.TabIndex = 49;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.back);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox InputConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputOldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}