using DevExpress.XtraEditors;
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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmNVenta()
        {
            InitializeComponent();
        }

        int mark2 = 0;
        Boolean valuecase = false;

        private void frmNVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            valuecase = false;
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
                DialogResult dialogo2 = MessageBox.Show("¿Seguro que deseas cancelar el llenado de la venta?",
              "Abarrotes y videojuegos Mary - 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo2 == DialogResult.Yes) { }
                else { e.Cancel = true; }
                valuecase = true;
            }
        }
    }
}