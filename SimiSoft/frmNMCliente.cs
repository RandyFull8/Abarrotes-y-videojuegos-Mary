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
            //txtId.Text = cliente.idCliente.ToString();
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
               // XtraMessageBox.Show(txtDescuento.Text);
                if (cliente == null)
                {
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                        razonSocial = txtRazon.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.EditValue),
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        mark2 = 1;
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
                    cliente.descuento = Convert.ToDecimal(txtDescuento.EditValue);
                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente modificado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        mark2 = 2;
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

        int mark2 = 0;
        Boolean valuecase = false;
        private void frmNMCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mark2 == 1)
            {
                valuecase = true;
            }
            if(mark2 == 2)
            {
                valuecase = true;
            }
            if(valuecase==false)
            {
                DialogResult dialogo2 = MessageBox.Show("¿Seguro que deseas cancelar el llenado de cliente?",
              "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo2 == DialogResult.Yes) { }
                else { e.Cancel = true; }
               
            }
        }
    }
}