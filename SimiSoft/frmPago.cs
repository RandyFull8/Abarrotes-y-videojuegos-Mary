﻿using DevExpress.XtraEditors;
using Simisoft.Buins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

   

        private void frmPago_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lupFpago.EditValue == null)
                return;
            Misc.totalPago = Convert.ToDecimal(txtPago.EditValue);
            Misc.idFPago = Convert.ToInt32(lupFpago.EditValue);
            txtCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            Clean();

            txtTotP.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtCambio.EditValue = 0;
        }

        private void Clean()
        {
            txtTotP.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
            lupFpago.EditValue = 1;

        }

        private void lupFpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (lupFpago.EditValue != null)
                    txtPago.Focus();

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (txtPago.EditValue != null)
                    if (Convert.ToDecimal(txtPago.EditValue) >= Misc.totalPago)
                    {
                        txtCambio.EditValue = (Misc.totalPago - Convert.ToDecimal(txtPago.EditValue)) * -1;
                        btnAceptar.Focus();
                    }
        }
    }
}