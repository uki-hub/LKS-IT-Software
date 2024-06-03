using LKS_Hospital.dataAccess;
using LKS_Hospital.lib;
using LKS_Hospital.store;
using LKS_Hospital.view.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hospital.view.Login
{
    public partial class LoginForm : Form
    {
        AuthDataAccess da = new AuthDataAccess();

        bool toggleShowPassword = false;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValid()) return;

                var username = txtUsn.Text;
                var password = txtPass.Text;

                var passwordSecret = Common.Sha512(password);

                var user = da.Login(username, passwordSecret);

                if (user == null)
                {
                    MessageBox.Show("User Tidak Ditemukan");
                }
                else
                {
                    da.UserSigned(user.id);

                    MessageBox.Show("login berhasil");

                    MainStore.User = user;

                    this.Hide();
                    new MenuForm().ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan");
            }
        }

        bool isValid()
        {
            var isValid = !String.IsNullOrEmpty(txtUsn.Text) && !String.IsNullOrEmpty(txtPass.Text);

            if (isValid) return true;


            if (String.IsNullOrEmpty(txtUsn.Text))
                MessageBox.Show("Username tidak boleh kosong");


            if (String.IsNullOrEmpty(txtPass.Text))
                MessageBox.Show("Password tidak boleh kosong");

            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toggleShowPassword = !toggleShowPassword;
            txtPass.UseSystemPasswordChar = !toggleShowPassword;
        }
    }
}
