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
            this.gbListaFactura = new System.Windows.Forms.GroupBox();
            this.dgvMostrarListaFacturas = new System.Windows.Forms.DataGridView();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.gbCrearFactura = new System.Windows.Forms.GroupBox();
            this.cmbProductosFactu = new System.Windows.Forms.ComboBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.txtTotalCrearFactura = new System.Windows.Forms.TextBox();
            this.cmbEstadoFacturaCrearFactura = new System.Windows.Forms.ComboBox();
            this.dtpFechaCrearFactura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClienteCrearFactura = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEditarFactura = new System.Windows.Forms.Button();
            this.btnEliminarFacturacion = new System.Windows.Forms.Button();
            this.btnLimpiarFactu = new System.Windows.Forms.Button();
            this.gbListaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturas)).BeginInit();
            this.gbCrearFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaFactura
            // 
            this.gbListaFactura.Controls.Add(this.dgvMostrarListaFacturas);
            this.gbListaFactura.Location = new System.Drawing.Point(40, 97);
            this.gbListaFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaFactura.Name = "gbListaFactura";
            this.gbListaFactura.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaFactura.Size = new System.Drawing.Size(798, 442);
            this.gbListaFactura.TabIndex = 5;
            this.gbListaFactura.TabStop = false;
            this.gbListaFactura.Text = "Lista de Facturas";
            // 
            // dgvMostrarListaFacturas
            // 
            this.dgvMostrarListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarListaFacturas.Location = new System.Drawing.Point(14, 35);
            this.dgvMostrarListaFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMostrarListaFacturas.Name = "dgvMostrarListaFacturas";
            this.dgvMostrarListaFacturas.RowHeadersWidth = 51;
            this.dgvMostrarListaFacturas.Size = new System.Drawing.Size(776, 397);
            this.dgvMostrarListaFacturas.TabIndex = 0;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(46, 29);
            this.lblFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(178, 38);
            this.lblFacturacion.TabIndex = 6;
            this.lblFacturacion.Text = "Facturacion";
            // 
            // gbCrearFactura
            // 
            this.gbCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(203)))));
            this.gbCrearFactura.Controls.Add(this.btnGuardarFactura);
            this.gbCrearFactura.Controls.Add(this.cmbProductosFactu);
            this.gbCrearFactura.Controls.Add(this.txtTotalCrearFactura);
            this.gbCrearFactura.Controls.Add(this.cmbEstadoFacturaCrearFactura);
            this.gbCrearFactura.Controls.Add(this.dtpFechaCrearFactura);
            this.gbCrearFactura.Controls.Add(this.label5);
            this.gbCrearFactura.Controls.Add(this.label4);
            this.gbCrearFactura.Controls.Add(this.label3);
            this.gbCrearFactura.Controls.Add(this.label2);
            this.gbCrearFactura.Controls.Add(this.txtNombreClienteCrearFactura);
            this.gbCrearFactura.Controls.Add(this.lblNombre);
            this.gbCrearFactura.Location = new System.Drawing.Point(861, 97);
            this.gbCrearFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrearFactura.Name = "gbCrearFactura";
            this.gbCrearFactura.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrearFactura.Size = new System.Drawing.Size(321, 612);
            this.gbCrearFactura.TabIndex = 7;
            this.gbCrearFactura.TabStop = false;
            this.gbCrearFactura.Text = "Crear Factura";
            // 
            // cmbProductosFactu
            // 
            this.cmbProductosFactu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductosFactu.FormattingEnabled = true;
            this.cmbProductosFactu.Location = new System.Drawing.Point(12, 277);
            this.cmbProductosFactu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProductosFactu.Name = "cmbProductosFactu";
            this.cmbProductosFactu.Size = new System.Drawing.Size(295, 28);
            this.cmbProductosFactu.TabIndex = 11;
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnGuardarFactura.Location = new System.Drawing.Point(84, 529);
            this.btnGuardarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(159, 52);
            this.btnGuardarFactura.TabIndex = 10;
            this.btnGuardarFactura.Text = "Guardar";
            this.btnGuardarFactura.UseVisualStyleBackColor = false;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // txtTotalCrearFactura
            // 
            this.txtTotalCrearFactura.Location = new System.Drawing.Point(10, 446);
            this.txtTotalCrearFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalCrearFactura.MaxLength = 50;
            this.txtTotalCrearFactura.Name = "txtTotalCrearFactura";
            this.txtTotalCrearFactura.ShortcutsEnabled = false;
            this.txtTotalCrearFactura.Size = new System.Drawing.Size(296, 26);
            this.txtTotalCrearFactura.TabIndex = 9;
            // 
            // cmbEstadoFacturaCrearFactura
            // 
            this.cmbEstadoFacturaCrearFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFacturaCrearFactura.FormattingEnabled = true;
            this.cmbEstadoFacturaCrearFactura.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstadoFacturaCrearFactura.Location = new System.Drawing.Point(12, 362);
            this.cmbEstadoFacturaCrearFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstadoFacturaCrearFactura.Name = "cmbEstadoFacturaCrearFactura";
            this.cmbEstadoFacturaCrearFactura.Size = new System.Drawing.Size(296, 28);
            this.cmbEstadoFacturaCrearFactura.TabIndex = 8;
            // 
            // dtpFechaCrearFactura
            // 
            this.dtpFechaCrearFactura.Location = new System.Drawing.Point(10, 163);
            this.dtpFechaCrearFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaCrearFactura.Name = "dtpFechaCrearFactura";
            this.dtpFechaCrearFactura.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaCrearFactura.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado de la factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de facturacion";
            // 
            // txtNombreClienteCrearFactura
            // 
            this.txtNombreClienteCrearFactura.Location = new System.Drawing.Point(12, 63);
            this.txtNombreClienteCrearFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreClienteCrearFactura.MaxLength = 50;
            this.txtNombreClienteCrearFactura.Name = "txtNombreClienteCrearFactura";
            this.txtNombreClienteCrearFactura.ShortcutsEnabled = false;
            this.txtNombreClienteCrearFactura.Size = new System.Drawing.Size(298, 26);
            this.txtNombreClienteCrearFactura.TabIndex = 1;
            this.txtNombreClienteCrearFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreClienteCrearFactura_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 38);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Cliente";
            // 
            // btnEditarFactura
            // 
            this.btnEditarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEditarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFactura.Location = new System.Drawing.Point(656, 566);
            this.btnEditarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarFactura.Name = "btnEditarFactura";
            this.btnEditarFactura.Size = new System.Drawing.Size(183, 74);
            this.btnEditarFactura.TabIndex = 8;
            this.btnEditarFactura.Text = "Editar";
            this.btnEditarFactura.UseVisualStyleBackColor = false;
            this.btnEditarFactura.Click += new System.EventHandler(this.btnEditarFactura_Click);
            // 
            // btnEliminarFacturacion
            // 
            this.btnEliminarFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEliminarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFacturacion.Location = new System.Drawing.Point(435, 566);
            this.btnEliminarFacturacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarFacturacion.Name = "btnEliminarFacturacion";
            this.btnEliminarFacturacion.Size = new System.Drawing.Size(183, 74);
            this.btnEliminarFacturacion.TabIndex = 9;
            this.btnEliminarFacturacion.Text = "Eliminar";
            this.btnEliminarFacturacion.UseVisualStyleBackColor = false;
            this.btnEliminarFacturacion.Click += new System.EventHandler(this.btnEliminarFacturacion_Click);
            // 
            // btnLimpiarFactu
            // 
            this.btnLimpiarFactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnLimpiarFactu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFactu.Location = new System.Drawing.Point(219, 566);
            this.btnLimpiarFactu.Name = "btnLimpiarFactu";
            this.btnLimpiarFactu.Size = new System.Drawing.Size(183, 74);
            this.btnLimpiarFactu.TabIndex = 10;
            this.btnLimpiarFactu.Text = "Limpiar";
            this.btnLimpiarFactu.UseVisualStyleBackColor = false;
            this.btnLimpiarFactu.Click += new System.EventHandler(this.btnLimpiarFactu_Click);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1200, 754);
            this.Controls.Add(this.btnEditarFactura);
            this.Controls.Add(this.btnEliminarFacturacion);
            this.Controls.Add(this.btnLimpiarFactu);
            this.Controls.Add(this.gbCrearFactura);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.gbListaFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.gbListaFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarListaFacturas)).EndInit();
            this.gbCrearFactura.ResumeLayout(false);
            this.gbCrearFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbListaFactura;
        private System.Windows.Forms.DataGridView dgvMostrarListaFacturas;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.GroupBox gbCrearFactura;
        private System.Windows.Forms.TextBox txtTotalCrearFactura;
        private System.Windows.Forms.ComboBox cmbEstadoFacturaCrearFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaCrearFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClienteCrearFactura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.Button btnEditarFactura;
        private System.Windows.Forms.Button btnEliminarFacturacion;
        private System.Windows.Forms.ComboBox cmbProductosFactu;
        private System.Windows.Forms.Button btnLimpiarFactu;
    }
}