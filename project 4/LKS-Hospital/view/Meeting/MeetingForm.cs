using LKS_Hospital.dataAccess;
using LKS_Hospital.model;
using LKS_Hospital.view.MainForm;
using LKS_Hospital.view.Master;
using LKS_Hospital.view.Patient_Record;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hospital.Meeting
{
    public partial class MeetingForm : Form
    {
        DoctorDataAccess doctorDA = new DoctorDataAccess();
        MeetingDataAccess meetingDA = new MeetingDataAccess();

        PatientModel searchedPatient;
        List<DoctorCategoryModel> doctorCategories;
        List<DoctorModel> doctors;
        List<DoctorModel> filteredDoctors;

        public MeetingForm()
        {
            doctorCategories = doctorDA.GetDoctorCategories();
            doctors = doctorDA.GetDoctors();

            InitializeComponent();

            comboCategory.DataSource = doctorCategories.Select(x => x.category).ToList();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void linkViewPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new MasterPatient().ShowDialog();
        }

        private void linkViewPatientReco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new PatientRecordForm().ShowDialog();
        }

        private void linkViewDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new MasterDoctor().ShowDialog();
        }

        private void MeetingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            searchedPatient = meetingDA.SearchPatientByName(txtPatientName.Text);

            if (searchedPatient == null)
            {
                linkViewPatient.Text = "";
                linkViewPatientReco.Text = "";
            } else
            {
                linkViewPatient.Text = "View Patient Data";
                linkViewPatientReco.Text = "View Patient Record";
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = doctorCategories[comboCategory.SelectedIndex];

            filteredDoctors = doctors.Where(x => x.doctor_category_id == category.id).ToList();


            var names = filteredDoctors.Select(x => x.name).ToList();
            names.Insert(0, "Select");

            comboName.DataSource = names;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateQueueNumber();
        }

        void UpdateQueueNumber()
        {
            if (comboName.SelectedIndex == 0) return;

            var doctor = filteredDoctors[comboName.SelectedIndex];

            lblQueue.Text = meetingDA.GenerateQueueNumber(doctor.id, dateTimePicker1.Value).ToString();
        }

        private void comboName_TextUpdate(object sender, EventArgs e)
        {
            UpdateQueueNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            
            try
            {
                var doctor = filteredDoctors[comboName.SelectedIndex];
                meetingDA.SaveMeeting(searchedPatient.id, doctor.id, doctor.assigned_room, int.Parse(lblQueue.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi Kesalahan");
            }
        }

        bool IsValid()
        {
            if (String.IsNullOrEmpty(txtPatientName.Text))
            {
                MessageBox.Show("Nama pasien tidak bisa kosong");
                return false;
            }

            if (comboName.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih doktor terlebih dahulu");
                return false;
            }

            if (!meetingDA.IsScheduleValid(filteredDoctors[comboName.SelectedIndex].id, dateTimePicker1.Value))
            {
                MessageBox.Show("Jadwal meeting tidak tersedia");
                return false;
            }

            return true;
        }
    }
}
