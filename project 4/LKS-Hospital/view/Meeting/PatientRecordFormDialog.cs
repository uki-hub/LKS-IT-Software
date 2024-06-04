using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hospital.view.Meeting
{
    public partial class PatientRecordFormDialog : Form
    {
        public PatientRecordFormDialog(string record = null)
        {
            InitializeComponent();

            richTextBox1.Text = record;
        }

        public string GetRecord => richTextBox1.Text;

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
