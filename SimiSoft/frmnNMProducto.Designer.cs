
namespace SimiSoft
{
    partial class frmNMProducto
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
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecio = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.lblUnidad = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblBandera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(42, 40);
            this.lblId.Margin = new System.Windows.Forms.Padding(6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(42, 544);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(6);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 25);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(42, 460);
            this.lblStock.Margin = new System.Windows.Forms.Padding(6);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 25);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(42, 371);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 25);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(42, 281);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 25);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(42, 194);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(6);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(147, 25);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Unidad Medida:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(42, 113);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(644, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(462, 281);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 44);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(216, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 40);
            this.txtId.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(216, 275);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 50;
            this.txtCodigo.Size = new System.Drawing.Size(200, 40);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(216, 446);
            this.txtStock.Margin = new System.Windows.Forms.Padding(6);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.MaxLength = 4;
            this.txtStock.Size = new System.Drawing.Size(200, 40);
            this.txtStock.TabIndex = 5;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(216, 358);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.MaxLength = 7;
            this.txtPrecio.Size = new System.Drawing.Size(200, 40);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(216, 538);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.MaxLength = 100;
            this.txtMarca.Size = new System.Drawing.Size(200, 40);
            this.txtMarca.TabIndex = 6;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(216, 188);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(6);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.MaxLength = 50;
            this.txtUnidad.Size = new System.Drawing.Size(200, 40);
            this.txtUnidad.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 108);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 150;
            this.txtDescripcion.Size = new System.Drawing.Size(200, 40);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblBandera
            // 
            this.lblBandera.AutoSize = true;
            this.lblBandera.Location = new System.Drawing.Point(666, 502);
            this.lblBandera.Name = "lblBandera";
            this.lblBandera.Size = new System.Drawing.Size(0, 25);
            this.lblBandera.TabIndex = 14;
            // 
            // frmNMProducto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(840, 619);
            this.Controls.Add(this.lblBandera);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblId);
            this.IconOptions.Image = global::SimiSoft.Properties.Resources.icons8_nachos_16;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmnNMProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNMProducto_FormClosing);
            this.Load += new System.EventHandler(this.frmnNMProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.LabelControl lblMarca;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.LabelControl lblPrecio;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblUnidad;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label lblBandera;
    }
}