using LKS.data_access;
using LKS.store;
using LKS.views.Admin;
using LKS.views.Cashier;
using LKS.views.Chef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views.Login
{
    public partial class LoginForm : Form
    {
        LoginDataAccess da = new LoginDataAccess();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textboxEmail.Text;
                string password = textboxPassword.Text;

                var user = da.Login(email, password);

                MainStore.user = user;

                Form userForm = null;
                switch (user.Position)
                {
                    case "Admin":
                        userForm = new AdminNavForm();
                        break;

                    case "Chef":
                        userForm = new ChefNavForm();
                        break;

                    case "Cashier":
                        userForm = new CashierNavForm();
                        break;

                }

                if (userForm == null) throw new Exception("User tidak valid");

                this.Hide();
                userForm.Show();
            }
            catch (Exception ex)
            {
                textWarning.Text = ex.Message;
            }
        }
    }
}
