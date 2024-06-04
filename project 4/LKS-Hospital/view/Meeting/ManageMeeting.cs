using LKS_Hospital.dataAccess;
using LKS_Hospital.model;
using LKS_Hospital.view.MainForm;
using LKS_Hospital.view.Meeting;
using LKS_Hospital.view.Payment;
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
        DataRow selectedMeeting;
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

        void updateRecordTable()
        {
            records = da.GetPatientRecords(int.Parse(selectedMeeting["patientId"].ToString()));

            dataGridView2.Rows.Clear();

            foreach (var r in records)
                dataGridView2.Rows.Add(r.notes, "Edit", "Delete");
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

            selectedMeeting = meetingData.Rows[e.RowIndex];

            updateRecordTable();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var record = records[e.RowIndex];

                switch (e.ColumnIndex)
                {
                    case 1:
                        using (var frm = new PatientRecordFormDialog(record.notes))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                da.UpdateRecord(
                                    record.id,
                                    frm.GetRecord
                                );

                                updateRecordTable();
                            }
                        }


                        break;

                    case 2:
                        da.DeleteRecord(record.id);

                        records.RemoveAt(e.RowIndex);

                        updateRecordTable();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan");
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if(e.ColumnIndex == 5)
            {
                this.Hide();
                new PaymentForm(int.Parse(selectedMeeting["meetingId"].ToString())).ShowDialog();
            }
        }
    }
}
