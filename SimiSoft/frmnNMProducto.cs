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
            //txtId.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            cbUnidad.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            cbMarca.Text = producto.marca;

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
                        //unidadMedida = txtUnidad.Text,
                        unidadMedida = (string)cbUnidad.EditValue,
                        codigo = txtCodigo.Text,
                        //descuento = Convert.ToDecimal(txtDescuento.EditValue),
                        precio = Convert.ToDecimal(txtPrecio.EditValue),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = (string)cbMarca.EditValue
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = cbUnidad.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.EditValue);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = cbMarca.Text;
                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", "Abarrotes y videojuegos Mary", MessageBoxButtons.OK,
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
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa la descripción";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(cbUnidad.Text))
            {
                cbUnidad.ErrorText = "Selecciona una unidad de medida";
                if (ban == false)
                {
                    cbUnidad.Focus();
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

            if (string.IsNullOrEmpty(cbMarca.Text))
            {
                cbMarca.ErrorText = "Selecciona una marca";
                if (ban == false)
                {
                    cbMarca.Focus();
                    ban = true;
                }
            }

            return !ban;
        }
       
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresCount = Convert.ToString(txtPrecio.Text.Length);
            int Valor = Convert.ToInt32(caracteresCount);
            if (txtPrecio.Text.Contains("."))
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        e.Handled = true;
                        return;
                    }
                }
                else
                {

                    if (Valor == 4)
                    {
                        if (!char.IsControl(e.KeyChar) && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                        }
                    }
                    else
                    {

                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }

                }
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

        int mark2 = 0;
        Boolean valuecase = false;
        private void frmNMProducto_FormClosing(object sender, FormClosingEventArgs e)
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
                DialogResult dialogo2 = MessageBox.Show("¿Seguro que deseas cancelar el llenado de producto?",
             "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo2 == DialogResult.Yes) { }
                else { e.Cancel = true; }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 
                