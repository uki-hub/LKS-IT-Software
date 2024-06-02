using RumahSakit.DataAccess;
using RumahSakit.Lib;
using RumahSakit.Model;
using RumahSakit.View.Login;
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
    public partial class ResepsionisPage : Form
    {
        ResepsionisDataAccess da = new ResepsionisDataAccess();
        List<PasienModel> listPasien;
        Timer timer;

        public ResepsionisPage()
        {
            InitializeComponent();

            listPasien = new List<PasienModel>();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblWaktu.Text = DateTime.Now.ToShortTimeString();

            var listPasienBaru = da.GetListPasien();

            if (listPasien.Count != listPasienBaru.Count)
            {
                listPasien = listPasienBaru;
                LoadPasien();
            }                

            label1.Text = listPasien.OrderBy(x => x.NomorAntrian).FirstOrDefault()?.NomorAntrian.ToString();
        }

        void LoadPasien()
        {
            var tabel = new DataTable();

            tabel.Columns.Add("Nomor Antrian");
            tabel.Columns.Add("Nama");
            tabel.Columns.Add("HP");

            foreach (var pasien in listPasien)
            {
                tabel.Rows.Add(pasien.NomorAntrian, pasien.Nama, pasien.NoHP);
            }

            table.DataSource = tabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DaftarPasienPage().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DaftarMembershipPage().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Common.ClearData();
            this.Close();
            new LoginPage().Show();
        }
    }
}
