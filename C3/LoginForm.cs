using C3.lib;
using C3.Lib;
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
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool Validasi()
        {
            //clear pesan error
            LabelPesan.Text = "";

            var isEmailKosong = String.IsNullOrEmpty(InputEmail.Text);
            var isPasswordKososng = String.IsNullOrEmpty(InputPassword.Text);

            if (isEmailKosong) LabelPesan.Text = "Email tidak boleh kosong";

            if (isPasswordKososng) LabelPesan.Text += "\nPassword tidak boleh kosong";

            if (isEmailKosong || isPasswordKososng) return false; //input tidak valid

            return true; //input valid
        } 

        public class UserModel
        {
            public string Nama { get; set; }
            public string Posisi { get; set; }
        }

        public UserModel Login()
        {
            //dapetin data berdasarkan email dan password

            var email = InputEmail.Text;
            var password = InputPassword.Text;

            var dt = new Database().Read($"select * from Msemployee where Email = '{email}' and password = '{password}' ");

            if(dt.Rows.Count == 0) // datatable yg didapet(dt) dri DataBase jumlah nya 0 baris
            {
                //user tidak ditemukan
                MessageBox.Show($"Email atau Password Salah");
                return null; //return disini agar kode stop sampai sini, bila user tidak ditemukan
            }

            var nama = dt.Rows[0]["Name"]; //ambil DataTable(dt) baris ke 0(index) lalu ambil dari kolum Name
            var posisi = dt.Rows[0]["Position"];

            MessageBox.Show($"Selamat Datang {posisi} {nama}");
            return new UserModel()
            {
                Nama = "sd",
                Posisi = "asdasd"
            }; //user ditemukan
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            //validaasi input
            var valid = Validasi();

            if (valid)
            {
                //cek email password ke database
                var user = Login();

                

                //validasi user apakah ada di database
                if (user != null)
                {
                    user.Posisi; //posisi user

                    //switch
                    //pindah view sesuai posisi user nya
                    //Admin
                    //Chef
                    //Cashier
                } else
                {
                    //pesan user tidak ditemukan
                }
            }

        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
