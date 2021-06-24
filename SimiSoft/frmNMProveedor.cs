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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private Proveedor proveedor;
        //Nuevo
        public frmNMProveedor()
        {
            InitializeComponent();
        }

        //Modificar
        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                idProveedor = idProveedor
            }.GetById();
            //txtId.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.nombre;
            txtEmpresa.Text = proveedor.empresa;
            txtTelefono.Text = proveedor.telefono;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        nombre = txtNombre.Text,
                        empresa=txtEmpresa.Text,
                        telefono = txtTelefono.Text,
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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
                    proveedor.nombre = txtNombre.Text;
                    proveedor.empresa = txtEmpresa.Text;
                    proveedor.telefono = txtTelefono.Text;
                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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

            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                txtEmpresa.ErrorText = "Ingresa una empresa";
                if (ban == false)
                {
                    txtEmpresa.Focus();
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


            return !ban;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {

        }

        int mark2 = 0;
        Boolean valuecase = false;
        private void frmNMProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mark2 == 1)
            {
                valuecase = true;
            }
            if (mark2 == 2)
            {
                valuecase = true;
            }
            if (valuecase == false)
            {
                DialogResult dialogo2 = MessageBox.Show("¿Seguro que deseas cancelar el llenado de cliente?",
             "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo2 == DialogResult.Yes) { }
                else { e.Cancel = true; }
            }
        }
    }
}