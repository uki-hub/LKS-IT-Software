﻿using LKS_Hospital.view.MainForm;
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
    public partial class NewItemPaymentForm : Form
    {
        public NewItemPaymentForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewItemPaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public string GetItem => txtItem.Text;

        public Decimal GetNominal => Decimal.Parse(txtNominal.Text);

        public string GetNotes => txtNotes.Text;

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
