using RumahSakit.DataAccess;
using RumahSakit.Lib;
using RumahSakit.Store;
using RumahSakit.View.Membership;
using RumahSakit.View.Resepsionis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.View.Login
{
    public partial class LoginPage : Form
    {
        LoginDataAccess da = new LoginDataAccess();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var username = textBox1.Text;
                var password = textBox2.Text; //mentah

                var passwordSecret = Common.Encrypt(password);

                var user = da.Login(username, passwordSecret);

                if (user == null)
                {
                    MessageBox.Show("User Tidak Ditemukan");
                }
                else
                {
                    MainStore.User = user;

                    MessageBox.Show($"{user.Username} Berhasil Login");

                    switch (user.Posisi)
                    {
                        case "resepsionis":
                            this.Hide();
                            new ResepsionisPage().ShowDialog();
                            break;

                        case "doktor":
                            break;

                        case "apoteker":
                            break;

                        case "membership":
                            this.Hide();
                            new MembershipPage().ShowDialog();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Terjadi Keselahan");
            }


        }
    }
}
