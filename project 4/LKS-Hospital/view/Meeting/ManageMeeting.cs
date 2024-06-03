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

        List<MeetingModel> meetings;
        List<PatientRecordModel> records;

        public ManageMeeting()
        {
            meetings = da.GetMeetings();

            InitializeComponent();
        }

        private void ManageMeeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }
    }
}
