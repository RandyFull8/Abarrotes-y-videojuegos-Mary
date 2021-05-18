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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace SimiSoft
{
    public partial class frmCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }
   

        public int caseUse { get; set; }
        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // get => _name;
            caseUse = 1;
            new frmNMCliente()
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            caseUse = 2;

            ColumnView View = (ColumnView)gcClientes.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound > 0)
            {
                new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
                {
                    Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("idCliente") + ")"
                }.ShowDialog();
                clienteBindingSource.DataSource = new Cliente().GetAll();
                gvClientes.BestFitColumns();
            }

            
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcClientes.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound > 0)
            {

                if (MessageBox.Show("¿Deseas eliminar el cliente?", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cliente
                    {
                        idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
                    }.Delete();
                    clienteBindingSource.DataSource = new Cliente().GetAll();
                    gvClientes.BestFitColumns();
                    MessageBox.Show("Se borro correctamente el cliente", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Se cancelo el borrado del cliente", "Abarrotes y videojuejos Mary - 2021", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }
    }
}