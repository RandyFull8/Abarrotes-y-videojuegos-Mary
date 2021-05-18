
namespace SimiSoft
{
    partial class frmNVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.gpCodigo = new DevExpress.XtraEditors.GroupControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.gpCliente = new DevExpress.XtraEditors.GroupControl();
            this.lupCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.gcVentaDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvVentaDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gpSummary = new DevExpress.XtraEditors.GroupControl();
            this.lbltCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.lbltPago = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lbltTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lbltDesc = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lbltSub = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gpCodigo)).BeginInit();
            this.gpCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCliente)).BeginInit();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpSummary)).BeginInit();
            this.gpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCodigo
            // 
            this.gpCodigo.Controls.Add(this.txtCodigo);
            this.gpCodigo.Controls.Add(this.lblCodigo);
            this.gpCodigo.Location = new System.Drawing.Point(12, 54);
            this.gpCodigo.Name = "gpCodigo";
            this.gpCodigo.ShowCaption = false;
            this.gpCodigo.Size = new System.Drawing.Size(1040, 65);
            this.gpCodigo.TabIndex = 3;
            this.gpCodigo.Text = "groupControl2";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(61, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(273, 40);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(8, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.lupCliente);
            this.gpCliente.Controls.Add(this.lblCliente);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.ShowCaption = false;
            this.gpCliente.Size = new System.Drawing.Size(1040, 36);
            this.gpCliente.TabIndex = 2;
            this.gpCliente.Text = "groupControl1";
            // 
            // lupCliente
            // 
            this.lupCliente.Location = new System.Drawing.Point(61, 7);
            this.lupCliente.Name = "lupCliente";
            this.lupCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lupCliente.Properties.Appearance.Options.UseFont = true;
            this.lupCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Cliente", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("razonSocial", "razon Social", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descuento", "descuento", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupCliente.Properties.DisplayMember = "nombre";
            this.lupCliente.Properties.NullText = "";
            this.lupCliente.Properties.ValueMember = "idCliente";
            this.lupCliente.Size = new System.Drawing.Size(273, 22);
            this.lupCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(7, 11);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // gcVentaDetalle
            // 
            this.gcVentaDetalle.Location = new System.Drawing.Point(12, 125);
            this.gcVentaDetalle.MainView = this.gvVentaDetalle;
            this.gcVentaDetalle.Name = "gcVentaDetalle";
            this.gcVentaDetalle.Size = new System.Drawing.Size(1040, 474);
            this.gcVentaDetalle.TabIndex = 4;
            this.gcVentaDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentaDetalle});
            // 
            // gvVentaDetalle
            // 
            this.gvVentaDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.Row.Options.UseFont = true;
            this.gvVentaDetalle.GridControl = this.gcVentaDetalle;
            this.gvVentaDetalle.Name = "gvVentaDetalle";
            this.gvVentaDetalle.OptionsSelection.MultiSelect = true;
            this.gvVentaDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentaDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvVentaDetalle.OptionsView.ShowFooter = true;
            this.gvVentaDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gpSummary
            // 
            this.gpSummary.Controls.Add(this.lbltCambio);
            this.gpSummary.Controls.Add(this.lblCambio);
            this.gpSummary.Controls.Add(this.lbltPago);
            this.gpSummary.Controls.Add(this.lblPago);
            this.gpSummary.Controls.Add(this.lbltTotal);
            this.gpSummary.Controls.Add(this.lblTotal);
            this.gpSummary.Controls.Add(this.lbltDesc);
            this.gpSummary.Controls.Add(this.lblDescuento);
            this.gpSummary.Controls.Add(this.lbltSub);
            this.gpSummary.Controls.Add(this.lblSubtotal);
            this.gpSummary.Location = new System.Drawing.Point(12, 605);
            this.gpSummary.Name = "gpSummary";
            this.gpSummary.ShowCaption = false;
            this.gpSummary.Size = new System.Drawing.Size(1040, 95);
            this.gpSummary.TabIndex = 5;
            this.gpSummary.Text = "groupControl3";
            // 
            // lbltCambio
            // 
            this.lbltCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltCambio.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbltCambio.Appearance.Options.UseFont = true;
            this.lbltCambio.Appearance.Options.UseForeColor = true;
            this.lbltCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltCambio.Location = new System.Drawing.Point(872, 55);
            this.lbltCambio.Name = "lbltCambio";
            this.lbltCambio.Size = new System.Drawing.Size(146, 23);
            this.lbltCambio.TabIndex = 9;
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Location = new System.Drawing.Point(763, 55);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(92, 19);
            this.lblCambio.TabIndex = 8;
            this.lblCambio.Text = "Su Cambio:";
            // 
            // lbltPago
            // 
            this.lbltPago.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltPago.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbltPago.Appearance.Options.UseFont = true;
            this.lbltPago.Appearance.Options.UseForeColor = true;
            this.lbltPago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltPago.Location = new System.Drawing.Point(872, 14);
            this.lbltPago.Name = "lbltPago";
            this.lbltPago.Size = new System.Drawing.Size(146, 23);
            this.lbltPago.TabIndex = 7;
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.Location = new System.Drawing.Point(783, 15);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(72, 19);
            this.lblPago.TabIndex = 6;
            this.lblPago.Text = "Su Pago:";
            // 
            // lbltTotal
            // 
            this.lbltTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbltTotal.Appearance.Options.UseFont = true;
            this.lbltTotal.Appearance.Options.UseForeColor = true;
            this.lbltTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltTotal.Location = new System.Drawing.Point(619, 15);
            this.lbltTotal.Name = "lbltTotal";
            this.lbltTotal.Size = new System.Drawing.Size(146, 23);
            this.lbltTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(551, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lbltDesc
            // 
            this.lbltDesc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltDesc.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbltDesc.Appearance.Options.UseFont = true;
            this.lbltDesc.Appearance.Options.UseForeColor = true;
            this.lbltDesc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltDesc.Location = new System.Drawing.Point(373, 14);
            this.lbltDesc.Name = "lbltDesc";
            this.lbltDesc.Size = new System.Drawing.Size(146, 23);
            this.lbltDesc.TabIndex = 3;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Appearance.Options.UseFont = true;
            this.lblDescuento.Location = new System.Drawing.Point(267, 15);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 19);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lbltSub
            // 
            this.lbltSub.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltSub.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbltSub.Appearance.Options.UseFont = true;
            this.lbltSub.Appearance.Options.UseForeColor = true;
            this.lbltSub.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltSub.Location = new System.Drawing.Point(101, 14);
            this.lbltSub.Name = "lbltSub";
            this.lbltSub.Size = new System.Drawing.Size(146, 23);
            this.lbltSub.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Appearance.Options.UseFont = true;
            this.lblSubtotal.Location = new System.Drawing.Point(7, 15);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 19);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "SubTotal:";
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 712);
            this.Controls.Add(this.gpSummary);
            this.Controls.Add(this.gcVentaDetalle);
            this.Controls.Add(this.gpCodigo);
            this.Controls.Add(this.gpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNVenta.IconOptions.SvgImage")));
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNVenta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gpCodigo)).EndInit();
            this.gpCodigo.ResumeLayout(false);
            this.gpCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCliente)).EndInit();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpSummary)).EndInit();
            this.gpSummary.ResumeLayout(false);
            this.gpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.GroupControl gpCliente;
        private DevExpress.XtraEditors.LookUpEdit lupCliente;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraGrid.GridControl gcVentaDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentaDetalle;
        private DevExpress.XtraEditors.GroupControl gpSummary;
        private DevExpress.XtraEditors.LabelControl lbltCambio;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LabelControl lbltPago;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lbltTotal;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lbltDesc;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lbltSub;
        private DevExpress.XtraEditors.LabelControl lblSubtotal;
    }
}