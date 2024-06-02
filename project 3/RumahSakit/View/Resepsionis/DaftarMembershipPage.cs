using RumahSakit.DataAccess;
using RumahSakit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.View.Resepsionis
{
    public partial class DaftarMembershipPage : Form
    {
        ResepsionisDataAccess da = new ResepsionisDataAccess();

        public DaftarMembershipPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var newMembership = new MembershipModel();
                newMembership.Nama = textBox1.Text;
                newMembership.NoHP = textBox2.Text;
                newMembership.Expired = dateTimePicker1.Value;

                da.DaftarMembership(newMembership);

                MessageBox.Show("Berhasil daftar membership");

                this.Hide();

                new ResepsionisPage().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan: {ex.Message}");
            }
        }
    }
}
