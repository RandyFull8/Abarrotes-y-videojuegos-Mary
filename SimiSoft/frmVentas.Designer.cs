
namespace SimiSoft
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirTicket = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirRem = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bntModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bntEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.bntModificar,
            this.bntEliminar,
            this.btnImprimirTicket,
            this.btnImprimirRem,
            this.btnCancelar});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirTicket, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirRem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Caption = "Imprimir Ticket";
            this.btnImprimirTicket.Id = 4;
            this.btnImprimirTicket.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirTicket.ImageOptions.SvgImage")));
            this.btnImprimirTicket.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            // 
            // btnImprimirRem
            // 
            this.btnImprimirRem.Caption = "Imprimir Remisión";
            this.btnImprimirRem.Id = 5;
            this.btnImprimirRem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirRem.ImageOptions.SvgImage")));
            this.btnImprimirRem.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnImprimirRem.Name = "btnImprimirRem";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Id = 6;
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnCancelar.Name = "btnCancelar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(798, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
            // 
            // bntModificar
            // 
            this.bntModificar.Caption = "Modificar";
            this.bntModificar.Id = 2;
            this.bntModificar.Name = "bntModificar";
            // 
            // bntEliminar
            // 
            this.bntEliminar.Caption = "Eliminar";
            this.bntEliminar.Id = 3;
            this.bntEliminar.Name = "bntEliminar";
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVentas.Location = new System.Drawing.Point(0, 24);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.barManager1;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.Size = new System.Drawing.Size(798, 544);
            this.gcVentas.TabIndex = 10;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Simisoft.Buins.Venta);
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colidCliente,
            this.colfecha,
            this.colcantidad,
            this.colimporte,
            this.colstatus});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentas.OptionsView.ShowAutoFilterRow = true;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.OptionsColumn.AllowEdit = false;
            this.colidVenta.OptionsColumn.AllowFocus = false;
            this.colidVenta.OptionsColumn.AllowMove = false;
            this.colidVenta.OptionsColumn.AllowSize = false;
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.OptionsColumn.AllowEdit = false;
            this.colidCliente.OptionsColumn.AllowFocus = false;
            this.colidCliente.OptionsColumn.AllowMove = false;
            this.colidCliente.OptionsColumn.AllowSize = false;
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowFocus = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.AllowSize = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.OptionsColumn.AllowFocus = false;
            this.colcantidad.OptionsColumn.AllowMove = false;
            this.colcantidad.OptionsColumn.AllowSize = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.OptionsColumn.AllowFocus = false;
            this.colimporte.OptionsColumn.AllowMove = false;
            this.colimporte.OptionsColumn.AllowSize = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmVentas.IconOptions.SvgImage")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnImprimirTicket;
        private DevExpress.XtraBars.BarButtonItem btnImprimirRem;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bntModificar;
        private DevExpress.XtraBars.BarButtonItem bntEliminar;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}