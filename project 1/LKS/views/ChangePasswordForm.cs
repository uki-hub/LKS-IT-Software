using LKS.data_access;
using LKS.store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views
{
    public partial class ChangePasswordForm : Form
    {
        string from;

        ManageEmployeesDataAccess da = new ManageEmployeesDataAccess();

        public ChangePasswordForm(string from)
        {
            InitializeComponent();

            this.from = from;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[this.from].Show();
        }

        void Clear()
        {
            InputOldPassword.Clear();
            InputNewPassword.Clear();
            InputConfirmPassword.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputNewPassword.Text != InputConfirmPassword.Text)
                {
                    //password tidak sama
                    return;
                }

                da.ChangePassword(MainStore.user.EmployeeID, InputOldPassword.Text, InputConfirmPassword.Text);
                Clear();
            }
            catch (Exception ex)
            {
                // gagal ganti password
            }

           
            
        }
    }
}
