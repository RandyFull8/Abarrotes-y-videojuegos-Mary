﻿
namespace SimiSoft
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnEliminar,
            this.btnModificar,
            this.btnNuevo});
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnNuevo.Id = 3;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 1;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6);
            this.barDockControlTop.Size = new System.Drawing.Size(1348, 46);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 842);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 796);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 796);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Simisoft.Buins.Producto);
            // 
            // gcProductos
            // 
            this.gcProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gcProductos.DataSource = this.productoBindingSource;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcProductos.Location = new System.Drawing.Point(0, 46);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.Margin = new System.Windows.Forms.Padding(6);
            this.gcProductos.MenuManager = this.barManager1;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.Size = new System.Drawing.Size(1348, 796);
            this.gcProductos.TabIndex = 9;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProducto,
            this.coldescripcion,
            this.colunidadMedida,
            this.colcodigo,
            this.colprecio,
            this.colstock,
            this.colmarca,
            this.colactivo});
            this.gvProductos.DetailHeight = 673;
            this.gvProductos.FixedLineWidth = 4;
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gvProductos.OptionsView.ColumnAutoWidth = false;
            this.gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductos.OptionsView.ShowAutoFilterRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "ID";
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 40;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.OptionsColumn.AllowEdit = false;
            this.colidProducto.OptionsColumn.AllowFocus = false;
            this.colidProducto.OptionsColumn.AllowMove = false;
            this.colidProducto.OptionsFilter.AllowFilter = false;
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            this.colidProducto.Width = 150;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 40;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.OptionsFilter.AllowFilter = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 150;
            // 
            // colunidadMedida
            // 
            this.colunidadMedida.Caption = "UnidadMedida";
            this.colunidadMedida.FieldName = "unidadMedida";
            this.colunidadMedida.MinWidth = 40;
            this.colunidadMedida.Name = "colunidadMedida";
            this.colunidadMedida.OptionsColumn.AllowEdit = false;
            this.colunidadMedida.OptionsColumn.AllowFocus = false;
            this.colunidadMedida.OptionsColumn.AllowMove = false;
            this.colunidadMedida.OptionsFilter.AllowFilter = false;
            this.colunidadMedida.Visible = true;
            this.colunidadMedida.VisibleIndex = 2;
            this.colunidadMedida.Width = 150;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.MinWidth = 40;
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.OptionsColumn.AllowFocus = false;
            this.colcodigo.OptionsColumn.AllowMove = false;
            this.colcodigo.OptionsFilter.AllowFilter = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 3;
            this.colcodigo.Width = 150;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.MinWidth = 40;
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.AllowEdit = false;
            this.colprecio.OptionsColumn.AllowFocus = false;
            this.colprecio.OptionsColumn.AllowMove = false;
            this.colprecio.OptionsFilter.AllowFilter = false;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 150;
            // 
            // colstock
            // 
            this.colstock.Caption = "Stock";
            this.colstock.FieldName = "stock";
            this.colstock.MinWidth = 40;
            this.colstock.Name = "colstock";
            this.colstock.OptionsColumn.AllowEdit = false;
            this.colstock.OptionsColumn.AllowFocus = false;
            this.colstock.OptionsColumn.AllowMove = false;
            this.colstock.OptionsFilter.AllowFilter = false;
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 5;
            this.colstock.Width = 150;
            // 
            // colmarca
            // 
            this.colmarca.Caption = "Marca";
            this.colmarca.FieldName = "marca";
            this.colmarca.MinWidth = 40;
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.AllowEdit = false;
            this.colmarca.OptionsColumn.AllowFocus = false;
            this.colmarca.OptionsColumn.AllowMove = false;
            this.colmarca.OptionsFilter.AllowFilter = false;
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 6;
            this.colmarca.Width = 150;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 40;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 150;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::SimiSoft.Properties.Resources.blue_and_white_abstract_background_vector;
            this.ClientSize = new System.Drawing.Size(1348, 842);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::SimiSoft.Properties.Resources.icons8_nachos_16;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colunidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}