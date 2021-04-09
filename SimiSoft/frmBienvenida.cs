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
    public partial class frmBienvenida : DevExpress.XtraEditors.XtraForm
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cpbCargando.Value += 1;
            cpbCargando.Text = cpbCargando.Value.ToString();
            if (cpbCargando.Value == 100)
            {
                timerInicio.Stop();
                timerFinal.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timerFinal.Stop();
                this.Close();
            }
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            
            this.Opacity = 0.0;
            cpbCargando.Value = 0;
            cpbCargando.Minimum = 0;
            cpbCargando.Maximum = 100;
            timerInicio.Start();
        }
    }
}