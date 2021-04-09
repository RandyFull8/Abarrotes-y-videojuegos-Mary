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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private Producto producto;
        //Nuevo
        public frmNMProducto()
        {
            InitializeComponent();
        }

        //Modificar
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Producto
            {
                idProducto = idProducto
            }.GetById();
            txtId.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            txtUnidad.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;

        }

        private void frmnNMProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Producto
                    {
                        descripcion = txtDescripcion.Text,
                        unidadMedida = txtUnidad.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = txtUnidad.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa la descripción";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtUnidad.Text))
            {
                txtUnidad.ErrorText = "Ingresa una unidad";
                if (ban == false)
                {
                    txtUnidad.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresa el código";
                if (ban == false)
                {
                    txtCodigo.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresa el precio";
                if (ban == false)
                {
                    txtPrecio.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresa el stock";
                if (ban == false)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingresa la marca";
                if (ban == false)
                {
                    txtMarca.Focus();
                    ban = true;
                }
            }

            return !ban;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
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
 
                