using LKS_Hospital.dataAccess;
using LKS_Hospital.Meeting;
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

namespace LKS_Hospital.view.Payment
{
    public partial class PaymentForm : Form
    {
        PaymentDataAccess paymentDA = new PaymentDataAccess();

        int meetingId;

        PaymentModel payment;
        List<PaymentDetailModel> paymentDetails;
        PaymentDetailModel selectedPaymentDetails;

        public PaymentForm(int meetingId)
        {
            this.meetingId = meetingId;

            payment = paymentDA.GetPayment(meetingId);
            
            InitializeComponent();

            LoadPaymentTable();
        }

        void LoadPaymentTable()
        {
            paymentDetails = payment == null ? new List<PaymentDetailModel>() : paymentDA.GetPaymentDetails(payment.id);

            dataGridView1.Rows.Clear();

            foreach (var p in paymentDetails)
                dataGridView1.Rows.Add(p.item, p.nominal, p.notes, "Delete");
        }

        void Clear()
        {
            txtCardHolderName.Clear();
            txtPrimaryAccountNumber.Clear();
            inpExpireDate.Value = DateTime.Now;
            txtServiceCode.Clear();
            txtTotalPayment.Clear();
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            new ManageMeeting().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 3)
            {
                paymentDA.DeletePayment(selectedPaymentDetails.payment_id);
                LoadPaymentTable();
                Clear();
            }
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            paymentDA.UpdatePayment(
                payment.id,
                txtCardHolderName.Text,
                txtPrimaryAccountNumber.Text,
                inpExpireDate.Value,
                int.Parse(txtServiceCode.Text));

            LoadPaymentTable();
            Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new NewItemPaymentForm())
                {
                    var dialog = frm.ShowDialog();
                    if (dialog == DialogResult.OK)
                    {
                        paymentDA.AddPayment(
                            payment.id,
                            frm.GetItem,
                            frm.GetNominal,
                            frm.GetNotes);

                        LoadPaymentTable();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Terjadi Kesalahan");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedPaymentDetails = paymentDetails[e.RowIndex];

            txtCardHolderName.Text = payment.card_holder_name;
            txtPrimaryAccountNumber.Text = payment.primary_account_number;
            inpExpireDate.Value = payment.expiration_date;
            txtServiceCode.Text = payment.service_code.ToString();
            txtTotalPayment.Text = payment.total_payment.ToString();
        }
    }
}
