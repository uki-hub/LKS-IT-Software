using LKS.store;
using LKS.views.Chef;
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

namespace LKS.views.Cashier
{
    public partial class CashierNavForm : Form
    {
        public CashierNavForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaymentForm().Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainStore.Clear();
            this.Close();
            new LoginForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm("CashierNavForm").Show();
        }
    }
}
