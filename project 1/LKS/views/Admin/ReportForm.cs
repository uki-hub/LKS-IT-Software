using LKS.data_access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views.Admin
{
    public partial class ReportForm : Form
    {
        ReportDataAccess da = new ReportDataAccess();

        List<DateTime> dateList;

        public ReportForm()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            dateList = da.GetDateList();
            dateList = dateList.Select(d => new DateTime(d.Year, d.Month, 1)).Distinct().ToList();

            var monthNameList = dateList.Select(date => date.ToString("MMMM")).ToList();

            InputFrom.DataSource = monthNameList;
            InputTo.DataSource = monthNameList;

            InputFrom.SelectedIndex = -1;
            InputTo.SelectedIndex = -1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["AdminNavForm"].Show();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Table.Columns.Clear();

            var _dateFrom = dateList[InputFrom.SelectedIndex];
            var dateFrom = new DateTime(_dateFrom.Year, _dateFrom.Month, 1);
            
            var _dateTo = dateList[InputTo.SelectedIndex];
            var dateTo = new DateTime(_dateTo.Year, _dateTo.Month + 1, 1);
            dateTo = dateTo.AddDays(-1);

            var data = da.GetReport(dateFrom, dateTo);

            if (data.Rows.Count <= 0) return;

            Table.DataSource = data;
        }
    }
}
