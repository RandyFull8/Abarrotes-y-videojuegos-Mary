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
            new frmNMProveedor((int)gvProveedores.GetFocusedRowCellValue("idProveedor"))
            {
                Text = "Modificar Proveedor (" + (int)gvProveedores.GetFocusedRowCellValue("idProveedor") + ")"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Proveedor
            {
                idProveedor = (int)gvProveedores.GetFocusedRowCellValue("idProveedor")
            }.Delete();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }
    }
}