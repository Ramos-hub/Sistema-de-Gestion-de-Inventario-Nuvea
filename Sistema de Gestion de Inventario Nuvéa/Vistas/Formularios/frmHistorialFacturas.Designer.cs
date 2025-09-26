namespace Vistas.Formularios
{
    partial class frmHistorialFacturas
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
            this.lblHistorialFacturas = new System.Windows.Forms.Label();
            this.pnlFiltrosHistorialFacturas = new System.Windows.Forms.Panel();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.dtpRangoHistorial = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoHistorial = new System.Windows.Forms.ComboBox();
            this.txtClienteHistorial = new System.Windows.Forms.TextBox();
            this.lblClienteHistorial = new System.Windows.Forms.Label();
            this.lblEstadoHistorial = new System.Windows.Forms.Label();
            this.lblRangoFacturas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrarHistorialFacturas = new System.Windows.Forms.DataGridView();
            this.pnlFiltrosHistorialFacturas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorialFacturas
            // 
            this.lblHistorialFacturas.AutoSize = true;
            this.lblHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistorialFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialFacturas.Location = new System.Drawing.Point(0, 0);
            this.lblHistorialFacturas.Name = "lblHistorialFacturas";
            this.lblHistorialFacturas.Size = new System.Drawing.Size(228, 28);
            this.lblHistorialFacturas.TabIndex = 0;
            this.lblHistorialFacturas.Text = "Historial de Facturas";
            // 
            // pnlFiltrosHistorialFacturas
            // 
            this.pnlFiltrosHistorialFacturas.BackColor = System.Drawing.Color.White;
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.btnAplicarFiltros);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dtpRangoHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.cmbEstadoHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.txtClienteHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblClienteHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblEstadoHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblRangoFacturas);
            this.pnlFiltrosHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosHistorialFacturas.Location = new System.Drawing.Point(0, 28);
            this.pnlFiltrosHistorialFacturas.Name = "pnlFiltrosHistorialFacturas";
            this.pnlFiltrosHistorialFacturas.Size = new System.Drawing.Size(800, 102);
            this.pnlFiltrosHistorialFacturas.TabIndex = 1;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(636, 42);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(141, 37);
            this.btnAplicarFiltros.TabIndex = 7;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // dtpRangoHistorial
            // 
            this.dtpRangoHistorial.Location = new System.Drawing.Point(12, 52);
            this.dtpRangoHistorial.Name = "dtpRangoHistorial";
            this.dtpRangoHistorial.Size = new System.Drawing.Size(200, 20);
            this.dtpRangoHistorial.TabIndex = 6;
            // 
            // cmbEstadoHistorial
            // 
            this.cmbEstadoHistorial.FormattingEnabled = true;
            this.cmbEstadoHistorial.Items.AddRange(new object[] {
            "Pagada ",
            "Pendiente"});
            this.cmbEstadoHistorial.Location = new System.Drawing.Point(241, 51);
            this.cmbEstadoHistorial.Name = "cmbEstadoHistorial";
            this.cmbEstadoHistorial.Size = new System.Drawing.Size(141, 21);
            this.cmbEstadoHistorial.TabIndex = 5;
            // 
            // txtClienteHistorial
            // 
            this.txtClienteHistorial.Location = new System.Drawing.Point(429, 52);
            this.txtClienteHistorial.Name = "txtClienteHistorial";
            this.txtClienteHistorial.ShortcutsEnabled = false;
            this.txtClienteHistorial.Size = new System.Drawing.Size(141, 20);
            this.txtClienteHistorial.TabIndex = 4;
            // 
            // lblClienteHistorial
            // 
            this.lblClienteHistorial.AutoSize = true;
            this.lblClienteHistorial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteHistorial.Location = new System.Drawing.Point(439, 12);
            this.lblClienteHistorial.Name = "lblClienteHistorial";
            this.lblClienteHistorial.Size = new System.Drawing.Size(51, 17);
            this.lblClienteHistorial.TabIndex = 2;
            this.lblClienteHistorial.Text = "Cliente";
            // 
            // lblEstadoHistorial
            // 
            this.lblEstadoHistorial.AutoSize = true;
            this.lblEstadoHistorial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoHistorial.Location = new System.Drawing.Point(253, 12);
            this.lblEstadoHistorial.Name = "lblEstadoHistorial";
            this.lblEstadoHistorial.Size = new System.Drawing.Size(49, 17);
            this.lblEstadoHistorial.TabIndex = 1;
            this.lblEstadoHistorial.Text = "Estado";
            // 
            // lblRangoFacturas
            // 
            this.lblRangoFacturas.AutoSize = true;
            this.lblRangoFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFacturas.Location = new System.Drawing.Point(24, 12);
            this.lblRangoFacturas.Name = "lblRangoFacturas";
            this.lblRangoFacturas.Size = new System.Drawing.Size(111, 17);
            this.lblRangoFacturas.TabIndex = 0;
            this.lblRangoFacturas.Text = "Rango de Fechas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvMostrarHistorialFacturas);
            this.panel1.Location = new System.Drawing.Point(13, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 276);
            this.panel1.TabIndex = 2;
            // 
            // dgvMostrarHistorialFacturas
            // 
            this.dgvMostrarHistorialFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarHistorialFacturas.Location = new System.Drawing.Point(14, 12);
            this.dgvMostrarHistorialFacturas.Name = "dgvMostrarHistorialFacturas";
            this.dgvMostrarHistorialFacturas.Size = new System.Drawing.Size(750, 251);
            this.dgvMostrarHistorialFacturas.TabIndex = 0;
            // 
            // frmHistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltrosHistorialFacturas);
            this.Controls.Add(this.lblHistorialFacturas);
            this.Name = "frmHistorialFacturas";
            this.Text = "frmHistorialFacturas";
            this.Load += new System.EventHandler(this.frmHistorialFacturas_Load);
            this.pnlFiltrosHistorialFacturas.ResumeLayout(false);
            this.pnlFiltrosHistorialFacturas.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorialFacturas;
        private System.Windows.Forms.Panel pnlFiltrosHistorialFacturas;
        private System.Windows.Forms.Label lblClienteHistorial;
        private System.Windows.Forms.Label lblEstadoHistorial;
        private System.Windows.Forms.Label lblRangoFacturas;
        private System.Windows.Forms.DateTimePicker dtpRangoHistorial;
        private System.Windows.Forms.ComboBox cmbEstadoHistorial;
        private System.Windows.Forms.TextBox txtClienteHistorial;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarHistorialFacturas;
    }
}