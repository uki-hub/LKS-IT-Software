using LKS_Hospital.dataAccess;
using LKS_Hospital.lib;
using LKS_Hospital.model;
using LKS_Hospital.view.MainForm;
using LKS_Hospital.view.UserControls;
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
    public partial class MasterICD11Form : Form
    {
        MasterICD11DataAccess da = new MasterICD11DataAccess();
        ICDDataAccess iCDDataAccess = new ICDDataAccess();

        List<ICD11Model> iCD11s;
        List<ICD11ExclusionModel> iCD11Exclusions;

        public MasterICD11Form()
        {
            iCD11s = iCDDataAccess.GetICD11s();
            iCD11Exclusions = iCDDataAccess.GetICD11Exclusions();

            InitializeComponent();

            comboBox1.DataSource = Common.mapData(iCD11s, (x, i) => $"{++i}) {x.name}");
        }

        private void MasterICD11Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new MasterDoctor().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new MasterDoctor().ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var icd11 = iCD11s[comboBox1.SelectedIndex];
            var exclusion = iCD11Exclusions.FirstOrDefault(x => x.icd11_id == icd11.id);
            var specialist = da.GetSpecialist(icd11.id);

            lblDesc.Text = icd11.description;
            lblExclusion.Text = exclusion?.exclusion ?? "-";

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in specialist.Rows)
                flowLayoutPanel1.Controls.Add(new RecommendedSpecialistRow(
                        int.Parse(row["doctor_id"].ToString()),
                        row["doctor_name"].ToString(),
                        row["category"].ToString()
                    ));
        }
    }
}
