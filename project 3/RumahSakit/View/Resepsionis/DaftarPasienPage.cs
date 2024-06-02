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
    public partial class DaftarPasienPage : Form
    {
        ResepsionisDataAccess da = new ResepsionisDataAccess();

        DataTable listMembership;

        public DaftarPasienPage()
        {
            listMembership = new MembershipDataAccess().GetListMembershipDataTable();

            InitializeComponent();

            listMembership.Columns.Remove("ID");
            listMembership.Columns.Remove("NoHp");
            listMembership.Columns.Remove("Expired");
            listMembership.Columns.Remove("Photo");
            listMembership.Columns.Remove("UserID");

            comboBox1.DataSource = listMembership.AsEnumerable().Select(x => x["Nama"]).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var newPasien = new PasienModel();
                newPasien.Nama = textBox1.Text;
                newPasien.NoHP = textBox2.Text;
                newPasien.Kelamin = textBox3.Text;
                newPasien.Umur = int.Parse(numericUpDown1.Value.ToString());
                newPasien.Photo = pictureBox1.ImageLocation;

                da.DaftarPasien(newPasien);

                MessageBox.Show("Berhasil Daftar Pasien");

                this.Hide();
                new ResepsionisPage().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Daftar Pasien: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
