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

        public bool validasi()
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //validaasi input
            var valid = validasi();

            if (valid)
            {
                //cek email password ke database
                
                //validasi user apakah ada di database
                if(true)
                {
                    //pindah view sesuai posisi user nya
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
