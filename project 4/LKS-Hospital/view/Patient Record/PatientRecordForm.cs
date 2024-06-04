using LKS_Hospital.dataAccess;
using LKS_Hospital.model;
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
        MedicalRecordDataAccess da = new MedicalRecordDataAccess();

        DataTable patientRecords;
        public PatientRecordForm(PatientModel patient)
        {
            InitializeComponent();

            patientRecords = da.GetRecords(patient.id);

            dataGridView1.DataSource = patientRecords;
        }

        private void PatientRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }
    }
}
