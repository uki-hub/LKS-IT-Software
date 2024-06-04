using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LKS_Hospital.view.Master;

namespace LKS_Hospital.view.UserControls
{
    public partial class RecommendedSpecialistRow : UserControl
    {
        int doctorID;
        string doctorName;
        string specialist;

        public RecommendedSpecialistRow(int doctorID, string doctorName, string specialist)
        {
            this.doctorID = doctorID;
            this.doctorName = doctorName;
            this.specialist = specialist;

            InitializeComponent();

            label1.Text = specialist;
            label2.Text = doctorName;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            new MasterDoctor(doctorID).Show();
        }
    }
}
