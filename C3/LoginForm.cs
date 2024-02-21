using C3.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3
{
    public partial class LoginForm : Form
    {
        Common c;

        public LoginForm()
        {
            c = new Common();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            c.add();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminNavigationForm().ShowDialog();
            this.Show();
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = c.count.ToString();
            c.add();
        }
    }
}
