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

namespace LKS_Hospital.view.Master
{
    public partial class MasterPatient : Form
    {
        int? selectedPatientId;

        PatientDataAccess patientDA = new PatientDataAccess();

        List<PatientModel> patients;
        List<PatientModel> filteredPatients;
        public MasterPatient(int? selectedPatientId = null)
        {
            patients = patientDA.GetPatients();
            this.selectedPatientId = selectedPatientId;

            InitializeComponent();
        }

        private void MasterPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        void FilterPatients()
        {
            Clear();
            dataGridView1.Rows.Clear();

            var _filteredPatients = patients.ToList();

            if (!String.IsNullOrEmpty(txtSearchPatient.Text))
                _filteredPatients = _filteredPatients.Where(x => x.name.Contains(txtSearchPatient.Text)).ToList();

            filteredPatients = _filteredPatients;

            foreach (var d in _filteredPatients)
            {
                dataGridView1.Rows.Add(d.name, d.phone_number, d.email, d.date_of_birth.ToString("dd/MM/yyyy"), d.address, d.gender, d.blood_type);
            }

            lblLastUpdatedAt.Text = $"Last updated at {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
        }

        void Clear()
        {
            txtNamePatient.Clear();
            txtPhonePatient.Clear();
            txtEmailPatient.Clear();
            txtDateOfBirth.Clear();
            txtAddressPatient.Clear();
            txtGenderPatient.Clear();
            txtBloodType.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var patient = filteredPatients[e.RowIndex];

            txtNamePatient.Text = patient.name;
            txtPhonePatient.Text = patient.phone_number;
            txtEmailPatient.Text = patient.email;
            txtDateOfBirth.Text = patient.date_of_birth.ToString("dd/MM/yyyy");
            txtAddressPatient.Text = patient.address;
            txtGenderPatient.Text = patient.gender;
            txtBloodType.Text = patient.blood_type;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterPatients();
        }

        private void MasterPatient_Load(object sender, EventArgs e)
        {
            FilterPatients();

            if(selectedPatientId.HasValue)
            {
                var patient = patients.FirstOrDefault(x => x.id == selectedPatientId.Value);

                txtNamePatient.Text = patient.name;
                txtPhonePatient.Text = patient.phone_number;
                txtEmailPatient.Text = patient.email;
                txtDateOfBirth.Text = patient.date_of_birth.ToString("dd/MM/yyyy");
                txtAddressPatient.Text = patient.address;
                txtGenderPatient.Text = patient.gender;
                txtBloodType.Text = patient.blood_type;
            }
        }
    }
}
