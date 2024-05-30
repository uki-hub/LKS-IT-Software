using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.View.DynamicForm.Components
{
    public partial class FieldNewUser : UserControl
    {
        Action OnRemove;

        public FieldNewUser(Action OnRemove)
        {
            InitializeComponent();

            this.OnRemove = OnRemove;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnRemove();
        }
    }
}
