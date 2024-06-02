using RumahSakit.DataAccess;
using RumahSakit.Lib;
using RumahSakit.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.View.ChangePassword
{
    public partial class ChangePasswordPage : Form
    {
        CommonDataAccess da = new CommonDataAccess();

        Form source;

        public ChangePasswordPage(Form source)
        {
            this.source = source;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != textBox2.Text)
                {
                    MessageBox.Show("Password tidak sama");
                    return;
                }

                var passwordSecret = Common.Encrypt(textBox2.Text);

                da.ChangePassword(MainStore.User.ID, passwordSecret);

                MessageBox.Show("Password berhasil diganti");

                this.Close();
                source.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }         
        }
    }
}
