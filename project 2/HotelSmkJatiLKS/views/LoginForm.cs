using HotelSmkJatiLKS.dataaccess;
using HotelSmkJatiLKS.store;
using HotelSmkJatiLKS.views.Admin;
using HotelSmkJatiLKS.views.FrontDesk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSmkJatiLKS.views.Login
{
    public partial class LoginForm : Form
    {
        LoginDataAccess da = new LoginDataAccess();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsn.Text;
                string password = txtPass.Text;

                var user = da.Login(username, password);

                MainStore.user = user;

                Form newForm = null;
                switch (user.JobID)
                {
                    case "1":
                        newForm = new MainFormAdmin();
                        break;

                    case "2":
                        //newForm = new CustomerForm();
                        break;
                }

                if (user.Address == null) throw new Exception("akun tidak ditemukan");

                this.Hide();
                newForm.Show();
            }
            catch (Exception ex)
            {
                txtWarning.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReservationForm().Show();
        }
    }
}
