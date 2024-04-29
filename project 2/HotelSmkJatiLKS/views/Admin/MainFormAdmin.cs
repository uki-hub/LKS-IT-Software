using HotelSmkJatiLKS.store;
using HotelSmkJatiLKS.views.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSmkJatiLKS.views.Admin
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
            txtWelcome.Text = $"Welcome, {MainStore.user.Name}";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MasterRoom().Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MasterRoomType().Show();
        }
    }
}
