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

namespace LKS.views.Cashier
{
    public partial class PaymentForm : Form
    {
        List<string> paymentTypes = new List<string>()
        {
            "Credit Card", "Bank Transfer"
        };

        List<string> banks = new List<string>()
        {
            "BCA", "MANDIRI",  "BNI", "Master Card", "Visa"
        };

        PaymentDataAccess da = new PaymentDataAccess();

        List<string> listOrderId;

        public PaymentForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            listOrderId = da.GetOrderIdList();

            InputOrderId.DataSource = listOrderId;
            InputOrderId.SelectedIndex = -1;

            InputPaymentType.DataSource = paymentTypes;
            InputBankName.DataSource = banks;

            Clear();
        }

        void Reload()
        {
            listOrderId = da.GetOrderIdList();

            InputOrderId.DataSource = listOrderId;
            InputOrderId.SelectedIndex = -1;
        }

        void Clear()
        {
            InputOrderId.SelectedIndex = -1;

            InputPaymentType.SelectedIndex = -1;
            InputBankName.SelectedIndex = -1;

            InputCardNumber.Clear();
        }

        private void InputOrderId_SelectedValueChanged(object sender, EventArgs e)
        {
            Table.Columns.Clear();

            if (InputOrderId.SelectedValue == null) return;

            var orderList = da.GetOrderDetail(InputOrderId.Text);

            if (orderList.Rows.Count <= 0) return;

            Table.DataSource = orderList;

            double total = 0;
            for (int i = 0; i < orderList.Rows.Count; i++)
            {
                var order = orderList.Rows[i];

                total += double.Parse(order["Total"].ToString());
            }

            LabelTotal.Text = $"Total: {total.ToString()}";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            da.Pay(InputOrderId.SelectedValue.ToString().Trim(), InputPaymentType.Text, $"{InputBankName.Text} - {InputCardNumber.Text}");
            
            Reload();
            Clear();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["CashierNavForm"].Show();
        }
    }
}
