namespace Vistas.Formularios
{
    partial class frmFacturaEmpleado
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
            this.gbCrearFacturaEmpleado = new System.Windows.Forms.GroupBox();
            this.btnGuardarFacturaEmpleado = new System.Windows.Forms.Button();
            this.txtTotalCrearFacturaEmpleado = new System.Windows.Forms.TextBox();
            this.cmbEstadoFacturaCrearFacturaEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombreProductoCrearFacturaEmpleado = new System.Windows.Forms.TextBox();
            this.dtpFechaCrearFacturaEmpleado = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClienteCrearFacturaEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFacturacionEmpleado = new System.Windows.Forms.Label();
            this.gbListaFacturaEmpleado = new System.Windows.Forms.GroupBox();
            this.dgvMostrarListaFacturasEmpleado = new System.Windows.Forms.DataGridView();
            this.gbBuscarFacturasEmpleado = new System.Windows.Forms.GroupBox();
            this.btnAplicarFiltrosEmpleado = new System.Windows.Forms.Button();
            this.dtmFiltroFechaEmpleado = new System.Windows.Forms.DateTimePicker();
            this.txtNombreClienteEmpleado = new System.Windows.Forms.TextBox();
            this.lblfech = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cmbEstadoEmpleado = new System.Windows.Forms.ComboBox();
            this.gbCrearFacturaEmpleado.SuspendLayout();
            this.gbListaFacturaEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturasEmpleado)).BeginInit();
            this.gbBuscarFacturasEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearFacturaEmpleado
            // 
            this.gbCrearFacturaEmpleado.Controls.Add(this.btnGuardarFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.txtTotalCrearFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.cmbEstadoFacturaCrearFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.txtNombreProductoCrearFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.dtpFechaCrearFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.label5);
            this.gbCrearFacturaEmpleado.Controls.Add(this.label4);
            this.gbCrearFacturaEmpleado.Controls.Add(this.label3);
            this.gbCrearFacturaEmpleado.Controls.Add(this.label2);
            this.gbCrearFacturaEmpleado.Controls.Add(this.txtNombreClienteCrearFacturaEmpleado);
            this.gbCrearFacturaEmpleado.Controls.Add(this.lblNombre);
            this.gbCrearFacturaEmpleado.Location = new System.Drawing.Point(569, 52);
            this.gbCrearFacturaEmpleado.Name = "gbCrearFacturaEmpleado";
            this.gbCrearFacturaEmpleado.Size = new System.Drawing.Size(214, 398);
            this.gbCrearFacturaEmpleado.TabIndex = 11;
            this.gbCrearFacturaEmpleado.TabStop = false;
            this.gbCrearFacturaEmpleado.Text = "Crear Factura";
            // 
            // btnGuardarFacturaEmpleado
            // 
            this.btnGuardarFacturaEmpleado.Location = new System.Drawing.Point(56, 344);
            this.btnGuardarFacturaEmpleado.Name = "btnGuardarFacturaEmpleado";
            this.btnGuardarFacturaEmpleado.Size = new System.Drawing.Size(106, 34);
            this.btnGuardarFacturaEmpleado.TabIndex = 10;
            this.btnGuardarFacturaEmpleado.Text = "Guardar";
            this.btnGuardarFacturaEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtTotalCrearFacturaEmpleado
            // 
            this.txtTotalCrearFacturaEmpleado.Location = new System.Drawing.Point(9, 305);
            this.txtTotalCrearFacturaEmpleado.Name = "txtTotalCrearFacturaEmpleado";
            this.txtTotalCrearFacturaEmpleado.Size = new System.Drawing.Size(199, 20);
            this.txtTotalCrearFacturaEmpleado.TabIndex = 9;
            // 
            // cmbEstadoFacturaCrearFacturaEmpleado
            // 
            this.cmbEstadoFacturaCrearFacturaEmpleado.FormattingEnabled = true;
            this.cmbEstadoFacturaCrearFacturaEmpleado.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstadoFacturaCrearFacturaEmpleado.Location = new System.Drawing.Point(8, 235);
            this.cmbEstadoFacturaCrearFacturaEmpleado.Name = "cmbEstadoFacturaCrearFacturaEmpleado";
            this.cmbEstadoFacturaCrearFacturaEmpleado.Size = new System.Drawing.Size(199, 21);
            this.cmbEstadoFacturaCrearFacturaEmpleado.TabIndex = 8;
            // 
            // txtNombreProductoCrearFacturaEmpleado
            // 
            this.txtNombreProductoCrearFacturaEmpleado.Location = new System.Drawing.Point(9, 171);
            this.txtNombreProductoCrearFacturaEmpleado.Name = "txtNombreProductoCrearFacturaEmpleado";
            this.txtNombreProductoCrearFacturaEmpleado.Size = new System.Drawing.Size(199, 20);
            this.txtNombreProductoCrearFacturaEmpleado.TabIndex = 7;
            // 
            // dtpFechaCrearFacturaEmpleado
            // 
            this.dtpFechaCrearFacturaEmpleado.Location = new System.Drawing.Point(7, 106);
            this.dtpFechaCrearFacturaEmpleado.Name = "dtpFechaCrearFacturaEmpleado";
            this.dtpFechaCrearFacturaEmpleado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCrearFacturaEmpleado.TabIndex = 6;
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
            // txtNombreClienteCrearFacturaEmpleado
            // 
            this.txtNombreClienteCrearFacturaEmpleado.Location = new System.Drawing.Point(8, 41);
            this.txtNombreClienteCrearFacturaEmpleado.Name = "txtNombreClienteCrearFacturaEmpleado";
            this.txtNombreClienteCrearFacturaEmpleado.Size = new System.Drawing.Size(200, 20);
            this.txtNombreClienteCrearFacturaEmpleado.TabIndex = 1;
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
            // lblFacturacionEmpleado
            // 
            this.lblFacturacionEmpleado.AutoSize = true;
            this.lblFacturacionEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionEmpleado.Location = new System.Drawing.Point(17, 1);
            this.lblFacturacionEmpleado.Name = "lblFacturacionEmpleado";
            this.lblFacturacionEmpleado.Size = new System.Drawing.Size(119, 25);
            this.lblFacturacionEmpleado.TabIndex = 10;
            this.lblFacturacionEmpleado.Text = "Facturacion";
            // 
            // gbListaFacturaEmpleado
            // 
            this.gbListaFacturaEmpleado.Controls.Add(this.dgvMostrarListaFacturasEmpleado);
            this.gbListaFacturaEmpleado.Location = new System.Drawing.Point(31, 223);
            this.gbListaFacturaEmpleado.Name = "gbListaFacturaEmpleado";
            this.gbListaFacturaEmpleado.Size = new System.Drawing.Size(456, 227);
            this.gbListaFacturaEmpleado.TabIndex = 9;
            this.gbListaFacturaEmpleado.TabStop = false;
            this.gbListaFacturaEmpleado.Text = "Lista de Facturas";
            // 
            // dgvMostrarListaFacturasEmpleado
            // 
            this.dgvMostrarListaFacturasEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarListaFacturasEmpleado.Location = new System.Drawing.Point(9, 23);
            this.dgvMostrarListaFacturasEmpleado.Name = "dgvMostrarListaFacturasEmpleado";
            this.dgvMostrarListaFacturasEmpleado.Size = new System.Drawing.Size(441, 184);
            this.dgvMostrarListaFacturasEmpleado.TabIndex = 0;
            // 
            // gbBuscarFacturasEmpleado
            // 
            this.gbBuscarFacturasEmpleado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbBuscarFacturasEmpleado.Controls.Add(this.btnAplicarFiltrosEmpleado);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.dtmFiltroFechaEmpleado);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.txtNombreClienteEmpleado);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.lblfech);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.lbl2);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.lblestado);
            this.gbBuscarFacturasEmpleado.Controls.Add(this.cmbEstadoEmpleado);
            this.gbBuscarFacturasEmpleado.Location = new System.Drawing.Point(22, 52);
            this.gbBuscarFacturasEmpleado.Name = "gbBuscarFacturasEmpleado";
            this.gbBuscarFacturasEmpleado.Size = new System.Drawing.Size(465, 123);
            this.gbBuscarFacturasEmpleado.TabIndex = 8;
            this.gbBuscarFacturasEmpleado.TabStop = false;
            this.gbBuscarFacturasEmpleado.Text = "Buscar Facturas";
            // 
            // btnAplicarFiltrosEmpleado
            // 
            this.btnAplicarFiltrosEmpleado.Location = new System.Drawing.Point(315, 78);
            this.btnAplicarFiltrosEmpleado.Name = "btnAplicarFiltrosEmpleado";
            this.btnAplicarFiltrosEmpleado.Size = new System.Drawing.Size(148, 36);
            this.btnAplicarFiltrosEmpleado.TabIndex = 8;
            this.btnAplicarFiltrosEmpleado.Text = "Aplicar";
            this.btnAplicarFiltrosEmpleado.UseVisualStyleBackColor = true;
            // 
            // dtmFiltroFechaEmpleado
            // 
            this.dtmFiltroFechaEmpleado.Location = new System.Drawing.Point(246, 45);
            this.dtmFiltroFechaEmpleado.Name = "dtmFiltroFechaEmpleado";
            this.dtmFiltroFechaEmpleado.Size = new System.Drawing.Size(217, 20);
            this.dtmFiltroFechaEmpleado.TabIndex = 7;
            // 
            // txtNombreClienteEmpleado
            // 
            this.txtNombreClienteEmpleado.Location = new System.Drawing.Point(120, 45);
            this.txtNombreClienteEmpleado.Name = "txtNombreClienteEmpleado";
            this.txtNombreClienteEmpleado.Size = new System.Drawing.Size(111, 20);
            this.txtNombreClienteEmpleado.TabIndex = 6;
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
            // cmbEstadoEmpleado
            // 
            this.cmbEstadoEmpleado.FormattingEnabled = true;
            this.cmbEstadoEmpleado.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstadoEmpleado.Location = new System.Drawing.Point(9, 45);
            this.cmbEstadoEmpleado.Name = "cmbEstadoEmpleado";
            this.cmbEstadoEmpleado.Size = new System.Drawing.Size(81, 21);
            this.cmbEstadoEmpleado.TabIndex = 0;
            // 
            // frmFacturaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCrearFacturaEmpleado);
            this.Controls.Add(this.lblFacturacionEmpleado);
            this.Controls.Add(this.gbListaFacturaEmpleado);
            this.Controls.Add(this.gbBuscarFacturasEmpleado);
            this.Name = "frmFacturaEmpleado";
            this.Text = "frmFacturaEmpleado";
            this.gbCrearFacturaEmpleado.ResumeLayout(false);
            this.gbCrearFacturaEmpleado.PerformLayout();
            this.gbListaFacturaEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturasEmpleado)).EndInit();
            this.gbBuscarFacturasEmpleado.ResumeLayout(false);
            this.gbBuscarFacturasEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearFacturaEmpleado;
        private System.Windows.Forms.Button btnGuardarFacturaEmpleado;
        private System.Windows.Forms.TextBox txtTotalCrearFacturaEmpleado;
        private System.Windows.Forms.ComboBox cmbEstadoFacturaCrearFacturaEmpleado;
        private System.Windows.Forms.TextBox txtNombreProductoCrearFacturaEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaCrearFacturaEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClienteCrearFacturaEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFacturacionEmpleado;
        private System.Windows.Forms.GroupBox gbListaFacturaEmpleado;
        private System.Windows.Forms.DataGridView dgvMostrarListaFacturasEmpleado;
        private System.Windows.Forms.GroupBox gbBuscarFacturasEmpleado;
        private System.Windows.Forms.Button btnAplicarFiltrosEmpleado;
        private System.Windows.Forms.DateTimePicker dtmFiltroFechaEmpleado;
        private System.Windows.Forms.TextBox txtNombreClienteEmpleado;
        private System.Windows.Forms.Label lblfech;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cmbEstadoEmpleado;
    }
}