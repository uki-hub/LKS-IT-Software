using LKS_Hospital.Meeting;
using LKS_Hospital.store;
using LKS_Hospital.view.Login;
using LKS_Hospital.view.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hospital.view.MainForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MasterICD11Form().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MasterDoctor().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MasterPatient().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MeetingForm().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMeeting().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainStore.Clear();
            this.Close();
            new LoginForm().Show();
        }
    }
}
