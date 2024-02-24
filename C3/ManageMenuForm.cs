using C3.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3
{
    public partial class ManageMenuForm : Form
    {
        public ManageMenuForm()
        {
            InitializeComponent();
        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            var database = new Database();

            var dt = database.Read("select * from sdsd");

            Table.DataSource = dt;
        }
    }
}
