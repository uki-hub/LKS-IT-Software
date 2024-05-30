using RumahSakit.View.DynamicForm.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit
{
    public partial class DynamicView : Form
    {
        public DynamicView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Tambah User

            layoutUser.Controls.Add(new FieldNewUser(() => layoutUser.Controls.RemoveAt(0)));
        }
    }
}
