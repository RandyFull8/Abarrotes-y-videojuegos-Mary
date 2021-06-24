using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using Simisoft.Buins;
using System;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto()
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcProductos.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound >= 0)
            {
                new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
                {
                    Text = "Modificar Producto (" + (int)gvProductos.GetFocusedRowCellValue("idProducto") + ")"
                }.ShowDialog();
                productoBindingSource.DataSource = new Producto().GetAll();
                gvProductos.BestFitColumns();
            }

            
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ColumnView View = (ColumnView)gcProductos.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound >= 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el producto?", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Producto
                    {
                        idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto")
                    }.Delete();
                    productoBindingSource.DataSource = new Producto().GetAll();
                    gvProductos.BestFitColumns();
                    MessageBox.Show("Se borro correctamente el producto", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Se cancelo el borrado del producto", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }
    }
}