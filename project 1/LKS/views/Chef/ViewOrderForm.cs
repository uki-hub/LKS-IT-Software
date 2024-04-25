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

namespace LKS.views.Chef
{
    public partial class ViewOrderForm : Form
    {
        ViewOrderDataAccess da = new ViewOrderDataAccess();

        List<string> orderIdList;

        public ViewOrderForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            orderIdList = da.GetOrderIdList();

            InputOrderId.DataSource = orderIdList;
            InputOrderId.SelectedIndex = -1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ChefNavForm"].Show();
        }

        private void InputOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputOrderId.SelectedValue == null) return;

            Table.Columns.Clear();

            var orderStatusList = da.GetOrderStatus(InputOrderId.SelectedValue.ToString().Trim());

            if (orderStatusList.Rows.Count <= 0) return;          
            
            Table.Columns.Add("MenuColumn", "Menu");
            Table.Columns.Add("QtyColumn", "QTY");
            Table.Columns.Add("StatusColumn", "Status");

            for (int i = 0; i < orderStatusList.Rows.Count; i++)
            {
                var orderStaus = orderStatusList.Rows[i];

                var menu = new DataGridViewTextBoxCell(); 
                menu.Value = orderStaus["Menu"].ToString();
                menu.Tag = orderStaus["MenuID"].ToString();

                var qty = new DataGridViewTextBoxCell(); 
                qty.Value = orderStaus["Qty"].ToString();

                var status = new DataGridViewComboBoxCell();
                status.Items.Add("Pending");
                status.Items.Add("Cooking");
                status.Items.Add("Delivery");
                status.Value = orderStaus["Status"];

                var newRow = new DataGridViewRow();
                newRow.Cells.Insert(0, menu);
                newRow.Cells.Insert(1, qty);
                newRow.Cells.Insert(2, status);

                Table.Rows.Insert(i, newRow);
            }

        }

        private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;

            var orderId = orderIdList[e.RowIndex];
            var menuId = Table[0, e.RowIndex].Tag.ToString();
            var newStatus = Table[2, e.RowIndex].Value.ToString();

            da.UpdateStatus(orderId, menuId, newStatus);
        }
    }
}
