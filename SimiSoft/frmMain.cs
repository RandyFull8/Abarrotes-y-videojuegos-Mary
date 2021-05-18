using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach(Form form in Application.OpenForms)
                if(form.GetType() == typeof(frmProducto))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Productos...");

            new frmProducto() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmCliente))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes...");

            new frmCliente() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedor))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Proveedores...");

            new frmProveedor() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
              
                DialogResult dialogo = MessageBox.Show("¿Seguro que desea salir del programa?",
                          "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogo == DialogResult.OK) { }
                else { e.Cancel = true; }          

        }

        private void btnAdminVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVentas))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas...");

            new frmVentas() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
