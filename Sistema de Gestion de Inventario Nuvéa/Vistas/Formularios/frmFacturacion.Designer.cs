namespace Vistas.Formularios
{
    partial class frmFacturacion
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
            this.gbBuscarFacturas = new System.Windows.Forms.GroupBox();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.dtmFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblfech = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gbListaFactura = new System.Windows.Forms.GroupBox();
            this.dgvMostrarListaFacturas = new System.Windows.Forms.DataGridView();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.gbCrearFactura = new System.Windows.Forms.GroupBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.txtTotalCrearFactura = new System.Windows.Forms.TextBox();
            this.cmbEstadoFacturaCrearFactura = new System.Windows.Forms.ComboBox();
            this.txtNombreProductoCrearFactura = new System.Windows.Forms.TextBox();
            this.dtpFechaCrearFactura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClienteCrearFactura = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbBuscarFacturas.SuspendLayout();
            this.gbListaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturas)).BeginInit();
            this.gbCrearFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscarFacturas
            // 
            this.gbBuscarFacturas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbBuscarFacturas.Controls.Add(this.btnAplicarFiltros);
            this.gbBuscarFacturas.Controls.Add(this.dtmFiltroFecha);
            this.gbBuscarFacturas.Controls.Add(this.txtNombreCliente);
            this.gbBuscarFacturas.Controls.Add(this.lblfech);
            this.gbBuscarFacturas.Controls.Add(this.lbl2);
            this.gbBuscarFacturas.Controls.Add(this.lblestado);
            this.gbBuscarFacturas.Controls.Add(this.cmbEstado);
            this.gbBuscarFacturas.Location = new System.Drawing.Point(27, 80);
            this.gbBuscarFacturas.Name = "gbBuscarFacturas";
            this.gbBuscarFacturas.Size = new System.Drawing.Size(465, 123);
            this.gbBuscarFacturas.TabIndex = 4;
            this.gbBuscarFacturas.TabStop = false;
            this.gbBuscarFacturas.Text = "Buscar Facturas";
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(315, 78);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(148, 36);
            this.btnAplicarFiltros.TabIndex = 8;
            this.btnAplicarFiltros.Text = "Aplicar";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            // 
            // dtmFiltroFecha
            // 
            this.dtmFiltroFecha.Location = new System.Drawing.Point(246, 45);
            this.dtmFiltroFecha.Name = "dtmFiltroFecha";
            this.dtmFiltroFecha.Size = new System.Drawing.Size(217, 20);
            this.dtmFiltroFecha.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(120, 45);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(111, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // lblfech
            // 
            this.lblfech.AutoSize = true;
            this.lblfech.Location = new System.Drawing.Point(243, 29);
            this.lblfech.Name = "lblfech";
            this.lblfech.Size = new System.Drawing.Size(37, 13);
            this.lblfech.TabIndex = 5;
            this.lblfech.Text = "Fecha";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(117, 29);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Nombre";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(6, 29);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 3;
            this.lblestado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(9, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(81, 21);
            this.cmbEstado.TabIndex = 0;
            // 
            // gbListaFactura
            // 
            this.gbListaFactura.Controls.Add(this.dgvMostrarListaFacturas);
            this.gbListaFactura.Location = new System.Drawing.Point(36, 251);
            this.gbListaFactura.Name = "gbListaFactura";
            this.gbListaFactura.Size = new System.Drawing.Size(456, 227);
            this.gbListaFactura.TabIndex = 5;
            this.gbListaFactura.TabStop = false;
            this.gbListaFactura.Text = "Lista de Facturas";
            // 
            // dgvMostrarListaFacturas
            // 
            this.dgvMostrarListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarListaFacturas.Location = new System.Drawing.Point(9, 23);
            this.dgvMostrarListaFacturas.Name = "dgvMostrarListaFacturas";
            this.dgvMostrarListaFacturas.Size = new System.Drawing.Size(441, 184);
            this.dgvMostrarListaFacturas.TabIndex = 0;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(22, 29);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(119, 25);
            this.lblFacturacion.TabIndex = 6;
            this.lblFacturacion.Text = "Facturacion";
            // 
            // gbCrearFactura
            // 
            this.gbCrearFactura.Controls.Add(this.btnGuardarFactura);
            this.gbCrearFactura.Controls.Add(this.txtTotalCrearFactura);
            this.gbCrearFactura.Controls.Add(this.cmbEstadoFacturaCrearFactura);
            this.gbCrearFactura.Controls.Add(this.txtNombreProductoCrearFactura);
            this.gbCrearFactura.Controls.Add(this.dtpFechaCrearFactura);
            this.gbCrearFactura.Controls.Add(this.label5);
            this.gbCrearFactura.Controls.Add(this.label4);
            this.gbCrearFactura.Controls.Add(this.label3);
            this.gbCrearFactura.Controls.Add(this.label2);
            this.gbCrearFactura.Controls.Add(this.txtNombreClienteCrearFactura);
            this.gbCrearFactura.Controls.Add(this.lblNombre);
            this.gbCrearFactura.Location = new System.Drawing.Point(574, 80);
            this.gbCrearFactura.Name = "gbCrearFactura";
            this.gbCrearFactura.Size = new System.Drawing.Size(214, 398);
            this.gbCrearFactura.TabIndex = 7;
            this.gbCrearFactura.TabStop = false;
            this.gbCrearFactura.Text = "Crear Factura";
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Location = new System.Drawing.Point(56, 344);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(106, 34);
            this.btnGuardarFactura.TabIndex = 10;
            this.btnGuardarFactura.Text = "Guardar";
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            // 
            // txtTotalCrearFactura
            // 
            this.txtTotalCrearFactura.Location = new System.Drawing.Point(9, 305);
            this.txtTotalCrearFactura.Name = "txtTotalCrearFactura";
            this.txtTotalCrearFactura.Size = new System.Drawing.Size(199, 20);
            this.txtTotalCrearFactura.TabIndex = 9;
            // 
            // cmbEstadoFacturaCrearFactura
            // 
            this.cmbEstadoFacturaCrearFactura.FormattingEnabled = true;
            this.cmbEstadoFacturaCrearFactura.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstadoFacturaCrearFactura.Location = new System.Drawing.Point(8, 235);
            this.cmbEstadoFacturaCrearFactura.Name = "cmbEstadoFacturaCrearFactura";
            this.cmbEstadoFacturaCrearFactura.Size = new System.Drawing.Size(199, 21);
            this.cmbEstadoFacturaCrearFactura.TabIndex = 8;
            // 
            // txtNombreProductoCrearFactura
            // 
            this.txtNombreProductoCrearFactura.Location = new System.Drawing.Point(9, 171);
            this.txtNombreProductoCrearFactura.Name = "txtNombreProductoCrearFactura";
            this.txtNombreProductoCrearFactura.Size = new System.Drawing.Size(199, 20);
            this.txtNombreProductoCrearFactura.TabIndex = 7;
            // 
            // dtpFechaCrearFactura
            // 
            this.dtpFechaCrearFactura.Location = new System.Drawing.Point(7, 106);
            this.dtpFechaCrearFactura.Name = "dtpFechaCrearFactura";
            this.dtpFechaCrearFactura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCrearFactura.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado de la factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de facturacion";
            // 
            // txtNombreClienteCrearFactura
            // 
            this.txtNombreClienteCrearFactura.Location = new System.Drawing.Point(8, 41);
            this.txtNombreClienteCrearFactura.Name = "txtNombreClienteCrearFactura";
            this.txtNombreClienteCrearFactura.Size = new System.Drawing.Size(200, 20);
            this.txtNombreClienteCrearFactura.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Cliente";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.gbCrearFactura);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.gbListaFactura);
            this.Controls.Add(this.gbBuscarFacturas);
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.gbBuscarFacturas.ResumeLayout(false);
            this.gbBuscarFacturas.PerformLayout();
            this.gbListaFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturas)).EndInit();
            this.gbCrearFactura.ResumeLayout(false);
            this.gbCrearFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBuscarFacturas;
        private System.Windows.Forms.Label lblfech;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox gbListaFactura;
        private System.Windows.Forms.DataGridView dgvMostrarListaFacturas;
        private System.Windows.Forms.DateTimePicker dtmFiltroFecha;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.GroupBox gbCrearFactura;
        private System.Windows.Forms.TextBox txtTotalCrearFactura;
        private System.Windows.Forms.ComboBox cmbEstadoFacturaCrearFactura;
        private System.Windows.Forms.TextBox txtNombreProductoCrearFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaCrearFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClienteCrearFactura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarFactura;
    }
}