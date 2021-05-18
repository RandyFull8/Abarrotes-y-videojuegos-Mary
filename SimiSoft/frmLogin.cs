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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //
        }
        Boolean mark = true;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(new Usuario
                {
                    username = txtUsuario.Text,
                    password = txtPassword.Text
                }.Login()!= null)
                {
                    //XtraMessageBox.Show("Acceso correcto");
                    mark = false;
                    frmBienvenida frmBienvenida = new frmBienvenida();
                    frmBienvenida.ShowDialog();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("Error en las credenciales");

                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
            }

        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.ErrorText = "Ingresa un usuario";
                txtUsuario.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.ErrorText = "Ingresa una contraseña";
                if (ban == false)
                {
                    txtPassword.Focus();
                    ban = true;
                }
            }

                return !ban;
        }

        private void txtUusuario_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
           
        }

        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mark == false)
            {
                //nada
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea salir de la aplicación?",
               "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogo == DialogResult.OK) { }
                else { e.Cancel = true; }
            }
        }
    }
}