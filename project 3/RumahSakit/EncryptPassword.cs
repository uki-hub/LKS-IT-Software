using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit
{
    public partial class EncryptPassword : Form
    {
        Database db = new Database();

        public EncryptPassword()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var username = inpCreateUsername.Text;
            var password = inpCreatePassword.Text;

            // enkripsi text password
            string passwordSecret = ConvertMD5(password);

            try
            {
                db.Execute($@"
                insert into [User]
                    (
                        Username,
                        Password
                    )
                    values
                    (
                        '{username}',
                        '{passwordSecret}'
                    )
                ");

                SuccessLabel.Text = "SUCCESS";
            }
            catch (Exception ex)
            {
                SuccessLabel.Text = "ERROR";
            }

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = inpLoginUsername.Text;
            var password = inpLoginPassword.Text;

            // enkripsi text password
            string passwordSecret = ConvertMD5(password);

            try
            {
                var userDT = db.Read($"select * from [User] where Username = '{username}' and Password = '{passwordSecret}' ");

                if (userDT.Rows.Count > 0)
                {
                    SuccessLabel.Text = "BERHASIL LOGIN";
                }
                else
                {
                    SuccessLabel.Text = "USERNAME ATAU PASSWORD SALAH";
                }
            }
            catch (Exception ex)
            {
                SuccessLabel.Text = "ERROR";
            }
        }

        //parameter text itu adalah text mentah yg belum ter enkripsi
        //using md5 = MD5.Create()
        //convert parameter text ke bytes, Encoding.ASCII.GetBytes
        //hash bytes text pakai md5.ComputeHash(textBytes)
        //bikin variable buat nampung hasil
        //looping hasil hash nya, setiap looping di convert ke .ToString("X2")
        string ConvertMD5(string text)
        {
            string secret;

            using (var md5 = MD5.Create())
            {
                var textBytes = Encoding.ASCII.GetBytes(text); //11 01 00 11 00 10 01 11 01 00 11 00 10 01
                var hash = md5.ComputeHash(textBytes); //01 10 00 10 11 01 10 00 10 11 01 10 00 10 11 01

                string sb = "";

                for (int i = 0; i < hash.Length; i++)
                    sb += hash[i].ToString("X2"); //2E 6E 06 DA A7 3B 86 EF 1B 3A 9B F7 E0 AB FB 05

                secret = sb.ToString();
            }

            return secret;
        }
    }
}
