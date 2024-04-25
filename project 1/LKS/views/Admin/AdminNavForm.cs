using LKS.lib;
using LKS.store;
using LKS.views.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views.Admin
{
    public partial class AdminNavForm : Form
    {

        public AdminNavForm()
        {
            InitializeComponent();

            username.Text = $"Welcome, {MainStore.user.Name}";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            MainStore.Clear();
            this.Close();
            new LoginForm().Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageEmployeeForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMenuForm().Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMemberForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm("AdminNavForm").Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportForm().Show();
        }
    }
}
