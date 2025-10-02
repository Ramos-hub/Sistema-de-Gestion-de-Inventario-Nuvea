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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrarHistorialFacturasEmpleado = new System.Windows.Forms.DataGridView();
            this.pnlFiltrosHistorialFacturas = new System.Windows.Forms.Panel();
            this.btnAplicarFiltrosEmpleado = new System.Windows.Forms.Button();
            this.dtpRangoHistorialEmpleado = new System.Windows.Forms.DateTimePicker();
            this.lblRangoFacturas = new System.Windows.Forms.Label();
            this.lblHistorialFacturas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturasEmpleado)).BeginInit();
            this.pnlFiltrosHistorialFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvMostrarHistorialFacturasEmpleado);
            this.panel1.Location = new System.Drawing.Point(13, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 276);
            this.panel1.TabIndex = 5;
            // 
            // dgvMostrarHistorialFacturasEmpleado
            // 
            this.dgvMostrarHistorialFacturasEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarHistorialFacturasEmpleado.Location = new System.Drawing.Point(14, 12);
            this.dgvMostrarHistorialFacturasEmpleado.Name = "dgvMostrarHistorialFacturasEmpleado";
            this.dgvMostrarHistorialFacturasEmpleado.Size = new System.Drawing.Size(750, 251);
            this.dgvMostrarHistorialFacturasEmpleado.TabIndex = 0;
            // 
            // pnlFiltrosHistorialFacturas
            // 
            this.pnlFiltrosHistorialFacturas.BackColor = System.Drawing.Color.White;
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.btnAplicarFiltrosEmpleado);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dtpRangoHistorialEmpleado);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblRangoFacturas);
            this.pnlFiltrosHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosHistorialFacturas.Location = new System.Drawing.Point(0, 28);
            this.pnlFiltrosHistorialFacturas.Name = "pnlFiltrosHistorialFacturas";
            this.pnlFiltrosHistorialFacturas.Size = new System.Drawing.Size(800, 102);
            this.pnlFiltrosHistorialFacturas.TabIndex = 4;
            // 
            // btnAplicarFiltrosEmpleado
            // 
            this.btnAplicarFiltrosEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.btnAplicarFiltrosEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltrosEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltrosEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltrosEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltrosEmpleado.Location = new System.Drawing.Point(636, 42);
            this.btnAplicarFiltrosEmpleado.Name = "btnAplicarFiltrosEmpleado";
            this.btnAplicarFiltrosEmpleado.Size = new System.Drawing.Size(141, 37);
            this.btnAplicarFiltrosEmpleado.TabIndex = 7;
            this.btnAplicarFiltrosEmpleado.Text = "Aplicar Filtros";
            this.btnAplicarFiltrosEmpleado.UseVisualStyleBackColor = false;
            this.btnAplicarFiltrosEmpleado.Click += new System.EventHandler(this.btnAplicarFiltrosEmpleado_Click);
            // 
            // dtpRangoHistorialEmpleado
            // 
            this.dtpRangoHistorialEmpleado.Location = new System.Drawing.Point(12, 52);
            this.dtpRangoHistorialEmpleado.Name = "dtpRangoHistorialEmpleado";
            this.dtpRangoHistorialEmpleado.Size = new System.Drawing.Size(200, 20);
            this.dtpRangoHistorialEmpleado.TabIndex = 6;
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
            // lblHistorialFacturas
            // 
            this.lblHistorialFacturas.AutoSize = true;
            this.lblHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistorialFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialFacturas.Location = new System.Drawing.Point(0, 0);
            this.lblHistorialFacturas.Name = "lblHistorialFacturas";
            this.lblHistorialFacturas.Size = new System.Drawing.Size(228, 28);
            this.lblHistorialFacturas.TabIndex = 3;
            this.lblHistorialFacturas.Text = "Historial de Facturas";
            // 
            // frmFacturaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltrosHistorialFacturas);
            this.Controls.Add(this.lblHistorialFacturas);
            this.Name = "frmFacturaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturaEmpleado";
            this.Load += new System.EventHandler(this.frmFacturaEmpleado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturasEmpleado)).EndInit();
            this.pnlFiltrosHistorialFacturas.ResumeLayout(false);
            this.pnlFiltrosHistorialFacturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarHistorialFacturasEmpleado;
        private System.Windows.Forms.Panel pnlFiltrosHistorialFacturas;
        private System.Windows.Forms.Button btnAplicarFiltrosEmpleado;
        private System.Windows.Forms.DateTimePicker dtpRangoHistorialEmpleado;
        private System.Windows.Forms.Label lblRangoFacturas;
        private System.Windows.Forms.Label lblHistorialFacturas;
    }
}