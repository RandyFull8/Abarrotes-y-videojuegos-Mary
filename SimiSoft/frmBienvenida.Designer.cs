
namespace SimiSoft
{
    partial class frmBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.lblAbarrotes = new DevExpress.XtraEditors.LabelControl();
            this.lblBienvenido = new DevExpress.XtraEditors.LabelControl();
            this.timerInicio = new System.Windows.Forms.Timer(this.components);
            this.timerFinal = new System.Windows.Forms.Timer(this.components);
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.cpbCargando = new CircularProgressBar.CircularProgressBar();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.panelNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panelNombre.Controls.Add(this.lblAbarrotes);
            this.panelNombre.Enabled = false;
            this.panelNombre.Location = new System.Drawing.Point(-8, -6);
            this.panelNombre.Margin = new System.Windows.Forms.Padding(6);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(1150, 92);
            this.panelNombre.TabIndex = 1;
            // 
            // lblAbarrotes
            // 
            this.lblAbarrotes.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbarrotes.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAbarrotes.Appearance.Options.UseFont = true;
            this.lblAbarrotes.Appearance.Options.UseForeColor = true;
            this.lblAbarrotes.Enabled = false;
            this.lblAbarrotes.Location = new System.Drawing.Point(66, 29);
            this.lblAbarrotes.Margin = new System.Windows.Forms.Padding(6);
            this.lblAbarrotes.Name = "lblAbarrotes";
            this.lblAbarrotes.Size = new System.Drawing.Size(421, 39);
            this.lblAbarrotes.TabIndex = 2;
            this.lblAbarrotes.Text = "Abarrotes y videojuegos Mary";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Appearance.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.lblBienvenido.Appearance.Options.UseFont = true;
            this.lblBienvenido.Appearance.Options.UseForeColor = true;
            this.lblBienvenido.Enabled = false;
            this.lblBienvenido.Location = new System.Drawing.Point(472, 98);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(6);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(415, 104);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // timerInicio
            // 
            this.timerInicio.Interval = 30;
            this.timerInicio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerFinal
            // 
            this.timerFinal.Interval = 30;
            this.timerFinal.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblUsername
            // 
            this.lblUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUsername.Appearance.Options.UseFont = true;
            this.lblUsername.Appearance.Options.UseForeColor = true;
            this.lblUsername.Enabled = false;
            this.lblUsername.Location = new System.Drawing.Point(512, 210);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(223, 39);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Acceso correcto";
            // 
            // cpbCargando
            // 
            this.cpbCargando.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCargando.AnimationSpeed = 500;
            this.cpbCargando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.cpbCargando.Enabled = false;
            this.cpbCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cpbCargando.ForeColor = System.Drawing.Color.Silver;
            this.cpbCargando.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.cpbCargando.InnerMargin = 2;
            this.cpbCargando.InnerWidth = -1;
            this.cpbCargando.Location = new System.Drawing.Point(472, 317);
            this.cpbCargando.Margin = new System.Windows.Forms.Padding(6);
            this.cpbCargando.MarqueeAnimationSpeed = 2000;
            this.cpbCargando.Name = "cpbCargando";
            this.cpbCargando.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.cpbCargando.OuterMargin = -25;
            this.cpbCargando.OuterWidth = 26;
            this.cpbCargando.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.cpbCargando.ProgressWidth = 25;
            this.cpbCargando.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cpbCargando.Size = new System.Drawing.Size(280, 262);
            this.cpbCargando.StartAngle = 270;
            this.cpbCargando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbCargando.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCargando.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCargando.SubscriptText = "";
            this.cpbCargando.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCargando.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCargando.SuperscriptText = "%";
            this.cpbCargando.TabIndex = 4;
            this.cpbCargando.Text = "0";
            this.cpbCargando.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbCargando.Value = 68;
            // 
            // pbPerfil
            // 
            this.pbPerfil.Enabled = false;
            this.pbPerfil.Image = global::SimiSoft.Properties.Resources.perfil;
            this.pbPerfil.Location = new System.Drawing.Point(-8, 85);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(6);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(412, 529);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerfil.TabIndex = 5;
            this.pbPerfil.TabStop = false;
            // 
            // frmBienvenida
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 612);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.cpbCargando);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNombre;
        private DevExpress.XtraEditors.LabelControl lblAbarrotes;
        private DevExpress.XtraEditors.LabelControl lblBienvenido;
        private System.Windows.Forms.Timer timerInicio;
        private System.Windows.Forms.Timer timerFinal;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private CircularProgressBar.CircularProgressBar cpbCargando;
        private System.Windows.Forms.PictureBox pbPerfil;
    }
}