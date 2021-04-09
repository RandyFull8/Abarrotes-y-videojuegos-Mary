using DevExpress.XtraEditors;
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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private Cliente cliente;
        //Nuevo
        public frmNMCliente()
        {
            InitializeComponent();
        }

        //Modificar
        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                idCliente = idCliente
            }.GetById();
            txtId.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
            txtRazon.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();
        }

        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                        razonSocial = txtRazon.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text),
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la inserción", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    cliente.nombre = txtNombre.Text;
                    cliente.razonSocial = txtRazon.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);
                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente modificado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificación", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa un nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtRazon.Text))
            {
                txtRazon.ErrorText = "Ingresa una razón social";
                if (ban == false)
                {
                    txtRazon.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa un teléfono";
                if (ban == false)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa el descuento";
                if (ban == false)
                {
                    txtDescuento.Focus();
                    ban = true;
                }
            }

            return !ban;
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}