using RumahSakit.DataAccess;
using RumahSakit.Model;
using RumahSakit.Store;
using RumahSakit.View.ChangePassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.View.Membership
{
    public partial class MembershipPage : Form
    {
        MembershipDataAccess da = new MembershipDataAccess();

        MembershipModel membership;
        public MembershipPage()
        {
            InitializeComponent();

            membership = da.GetMembership(MainStore.User.ID);

            label1.Text = $"Nama: {membership.Nama}";
            label2.Text = $"No HP: {membership.NoHP}";
            label3.Text = $"Expired: {membership.Expired.ToShortDateString()}";

            if (String.IsNullOrEmpty(membership.Photo))
            {
                pictureBox1.ImageLocation = @"P:\.repos\LKS\project 3\RumahSakit\Images\DefaultPhoto.png";
            }
            else
            {
                pictureBox1.ImageLocation = membership.Photo;
            }

        }

        private void MembershipPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            pictureBox1.ImageLocation = openFileDialog1.FileName;

            da.UpdatePhoto(membership.UserID, openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordPage(this).ShowDialog();

        }
    }
}
