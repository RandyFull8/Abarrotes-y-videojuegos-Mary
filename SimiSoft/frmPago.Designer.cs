
namespace SimiSoft
{
    partial class frmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPago));
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPago = new DevExpress.XtraEditors.TextEdit();
            this.lupFpago = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCambio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFpago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Location = new System.Drawing.Point(196, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Registrar Venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPago);
            this.groupControl1.Controls.Add(this.lupFpago);
            this.groupControl1.Controls.Add(this.txtCambio);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTotP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(335, 158);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(144, 81);
            this.txtPago.Name = "txtPago";
            this.txtPago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Properties.Appearance.Options.UseFont = true;
            this.txtPago.Properties.Mask.EditMask = "c";
            this.txtPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPago.Size = new System.Drawing.Size(186, 30);
            this.txtPago.TabIndex = 7;
            // 
            // lupFpago
            // 
            this.lupFpago.Location = new System.Drawing.Point(145, 46);
            this.lupFpago.Name = "lupFpago";
            this.lupFpago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupFpago.Properties.Appearance.Options.UseFont = true;
            this.lupFpago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupFpago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idFPago", "id FPago", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Forma Pago", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupFpago.Properties.DisplayMember = "descripcion";
            this.lupFpago.Properties.NullText = "";
            this.lupFpago.Properties.ValueMember = "idFPago";
            this.lupFpago.Size = new System.Drawing.Size(185, 30);
            this.lupFpago.TabIndex = 6;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(144, 117);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Properties.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.txtCambio.Properties.Appearance.Options.UseFont = true;
            this.txtCambio.Properties.Appearance.Options.UseForeColor = true;
            this.txtCambio.Properties.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(186, 30);
            this.txtCambio.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 23);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Su Cambio:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 23);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Su Pago:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Forma Pago:";
            // 
            // txtTotP
            // 
            this.txtTotP.Location = new System.Drawing.Point(144, 9);
            this.txtTotP.Name = "txtTotP";
            this.txtTotP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotP.Properties.Appearance.Options.UseFont = true;
            this.txtTotP.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.txtTotP.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.Silver;
            this.txtTotP.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotP.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTotP.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.txtTotP.Properties.ReadOnly = true;
            this.txtTotP.Size = new System.Drawing.Size(186, 30);
            this.txtTotP.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Total a Pagar:";
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(359, 209);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmPago.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPago_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFpago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPago;
        private DevExpress.XtraEditors.LookUpEdit lupFpago;
        private DevExpress.XtraEditors.TextEdit txtCambio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}