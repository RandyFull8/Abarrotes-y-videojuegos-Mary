using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmProveedor : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor()
            {
                Text = "Nuevo Proveedor"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcProveedores.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound >= 0)
            {
                new frmNMProveedor((int)gvProveedores.GetFocusedRowCellValue("idProveedor"))
                {
                    Text = "Modificar Proveedor (" + (int)gvProveedores.GetFocusedRowCellValue("idProveedor") + ")"
                }.ShowDialog();
                proveedorBindingSource.DataSource = new Proveedor().GetAll();
                gvProveedores.BestFitColumns();
            }

            
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ColumnView View = (ColumnView)gcProveedores.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound >= 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el proveedor?", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Proveedor
                    {
                        idProveedor = (int)gvProveedores.GetFocusedRowCellValue("idProveedor")
                    }.Delete();
                    proveedorBindingSource.DataSource = new Proveedor().GetAll();
                    gvProveedores.BestFitColumns();
                    MessageBox.Show("Se borro correctamente el proveedor", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Se cancelo el borrado del proveedor", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }
    }
}