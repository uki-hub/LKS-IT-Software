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
    public partial class MasterDoctor : Form
    {
        int? selectedDoctorId;

        DoctorDataAccess doctorDA = new DoctorDataAccess();

        List<DoctorModel> doctors;
        List<DoctorCategoryModel> doctorCategories;
        List<DoctorModel> filteredDoctors;

        public MasterDoctor(int? selectedDoctorId = null)
        {
            doctors = doctorDA.GetDoctors();
            doctorCategories = doctorDA.GetDoctorCategories();
            this.selectedDoctorId = selectedDoctorId;

            InitializeComponent();                   
        }

        void FilterDoctor()
        {
            Clear();
            dataGridView1.Rows.Clear();

            var _filteredDoctors = doctors.ToList();

            if (comboBox1.SelectedIndex > 0)
                _filteredDoctors = _filteredDoctors.Where(x => x.doctor_category_id == doctorCategories[comboBox1.SelectedIndex + 1].id).ToList();

            if (!String.IsNullOrEmpty(txtSearchDoctor.Text))
                _filteredDoctors = _filteredDoctors.Where(x => x.name.Contains(txtSearchDoctor.Text)).ToList();

            filteredDoctors = _filteredDoctors;

            foreach (var d in _filteredDoctors)
            {
                var category = doctorCategories.FirstOrDefault(x => x.id == d.doctor_category_id);

                dataGridView1.Rows.Add(d.name, d.phone_number, d.email, d.date_of_birth.ToString("dd/MM/yyyy"), category.category, d.address, d.gender, d.assigned_room);
            }

            lblLastUpdatedAt.Text = $"Last updated at {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
        }

        private void MasterDoctor_Load(object sender, EventArgs e)
        {
            var categories = doctorCategories.Select(x => x.category).ToList();
            categories.Insert(0, "select");
            comboBox1.DataSource = categories;

            FilterDoctor();

            if (selectedDoctorId.HasValue)
            {
                var doctor = doctors.FirstOrDefault(x => x.id == selectedDoctorId.Value);
                var category = doctorCategories.FirstOrDefault(x => x.id == doctor.doctor_category_id);

                txtName.Text = doctor.name;
                txtPhone.Text = doctor.phone_number;
                txtEmail.Text = doctor.email;
                txtDateOfBirth.Text = doctor.date_of_birth.ToString("dd/MM/yyyy");
                txtCategory.Text = category.category;
                txtAddress.Text = doctor.address;
                txtGender.Text = doctor.gender;
                txtRoom.Text = doctor.assigned_room;
            }
        }

        private void MasterDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDoctor();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterDoctor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var doctor = filteredDoctors[e.RowIndex];
            var category = doctorCategories.FirstOrDefault(x => x.id == doctor.doctor_category_id);

            txtName.Text = doctor.name;
            txtPhone.Text = doctor.phone_number;
            txtEmail.Text = doctor.email;
            txtDateOfBirth.Text = doctor.date_of_birth.ToString("dd/MM/yyyy");
            txtCategory.Text = category.category;
            txtAddress.Text = doctor.address;
            txtGender.Text = doctor.gender;
            txtRoom.Text = doctor.assigned_room;
        }

        void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtDateOfBirth.Clear();
            txtCategory.Clear();
            txtAddress.Clear();
            txtGender.Clear();
            txtRoom.Clear();
        }
    }
}
