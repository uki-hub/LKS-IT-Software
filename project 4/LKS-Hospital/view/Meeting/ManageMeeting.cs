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

namespace LKS_Hospital.Meeting
{
    public partial class ManageMeeting : Form
    {
        ManageMeetingDataAccess da = new ManageMeetingDataAccess();

        DataTable meetingData;
        List<PatientRecordModel> records;

        public ManageMeeting()
        {
            meetingData = da.GetMeetings();

            InitializeComponent();

            foreach (DataRow item in meetingData.Rows)
            {
                dataGridView1.Rows.Add(
                    DateTime.Parse(item["Date"].ToString()).ToString("dd-MM-yyyy"),
                    item["Name"],
                    item["DoctorCategory"],
                    item["DoctorName"],
                    item["Queue"],
                    "Payment");
            }
        }

        private void ManageMeeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dataGridView2.Rows.Clear();

            records = da.GetPatientRecords(int.Parse(meetingData.Rows[e.RowIndex]["patientId"].ToString()));

            foreach (var r in records)
            {
                dataGridView2.Rows.Add(r.notes, "Edit", "Delete");
            }
        }
    }
}
