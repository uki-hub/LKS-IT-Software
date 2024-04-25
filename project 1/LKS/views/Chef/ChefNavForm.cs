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

namespace LKS.views.Chef
{
    public partial class ChefNavForm : Form
    {
        public ChefNavForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewOrderForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm("ChefNavForm").Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainStore.Clear();
            this.Close();
            new LoginForm().Show();
        }
    }
}
