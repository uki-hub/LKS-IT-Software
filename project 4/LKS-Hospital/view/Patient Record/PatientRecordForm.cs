using LKS_Hospital.view.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hospital.view.Patient_Record
{
    public partial class PatientRecordForm : Form
    {
        public PatientRecordForm()
        {
            InitializeComponent();
        }

        private void PatientRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }
    }
}
