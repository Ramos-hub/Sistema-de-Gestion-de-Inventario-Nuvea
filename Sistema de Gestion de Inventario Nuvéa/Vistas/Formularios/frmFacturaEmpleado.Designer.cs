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
            this.dgvMostrarHistorialFacturas = new System.Windows.Forms.DataGridView();
            this.pnlFiltrosHistorialFacturas = new System.Windows.Forms.Panel();
            this.btnRecargarFacturas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRangoHistorialHasta = new System.Windows.Forms.DateTimePicker();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.dtpRangoHistorialDesde = new System.Windows.Forms.DateTimePicker();
            this.lblRangoFacturas = new System.Windows.Forms.Label();
            this.lblHistorialFacturas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturas)).BeginInit();
            this.pnlFiltrosHistorialFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvMostrarHistorialFacturas);
            this.panel1.Location = new System.Drawing.Point(20, 258);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 425);
            this.panel1.TabIndex = 5;
            // 
            // dgvMostrarHistorialFacturas
            // 
            this.dgvMostrarHistorialFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarHistorialFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarHistorialFacturas.Location = new System.Drawing.Point(21, 18);
            this.dgvMostrarHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMostrarHistorialFacturas.Name = "dgvMostrarHistorialFacturas";
            this.dgvMostrarHistorialFacturas.RowHeadersWidth = 51;
            this.dgvMostrarHistorialFacturas.Size = new System.Drawing.Size(1125, 386);
            this.dgvMostrarHistorialFacturas.TabIndex = 0;
            // 
            // pnlFiltrosHistorialFacturas
            // 
            this.pnlFiltrosHistorialFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltrosHistorialFacturas.BackColor = System.Drawing.Color.White;
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.btnRecargarFacturas);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.label2);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.label1);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dtpRangoHistorialHasta);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.btnAplicarFiltros);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dtpRangoHistorialDesde);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblRangoFacturas);
            this.pnlFiltrosHistorialFacturas.Location = new System.Drawing.Point(0, 54);
            this.pnlFiltrosHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFiltrosHistorialFacturas.Name = "pnlFiltrosHistorialFacturas";
            this.pnlFiltrosHistorialFacturas.Size = new System.Drawing.Size(1200, 157);
            this.pnlFiltrosHistorialFacturas.TabIndex = 4;
            // 
            // btnRecargarFacturas
            // 
            this.btnRecargarFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargarFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(126)))), ((int)(((byte)(118)))));
            this.btnRecargarFacturas.FlatAppearance.BorderSize = 0;
            this.btnRecargarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarFacturas.ForeColor = System.Drawing.Color.White;
            this.btnRecargarFacturas.Location = new System.Drawing.Point(734, 65);
            this.btnRecargarFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecargarFacturas.Name = "btnRecargarFacturas";
            this.btnRecargarFacturas.Size = new System.Drawing.Size(212, 57);
            this.btnRecargarFacturas.TabIndex = 11;
            this.btnRecargarFacturas.Text = "Cargar Facturas";
            this.btnRecargarFacturas.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde:";
            // 
            // dtpRangoHistorialHasta
            // 
            this.dtpRangoHistorialHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpRangoHistorialHasta.Location = new System.Drawing.Point(402, 106);
            this.dtpRangoHistorialHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRangoHistorialHasta.Name = "dtpRangoHistorialHasta";
            this.dtpRangoHistorialHasta.Size = new System.Drawing.Size(298, 26);
            this.dtpRangoHistorialHasta.TabIndex = 8;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(126)))), ((int)(((byte)(118)))));
            this.btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(954, 65);
            this.btnAplicarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(212, 57);
            this.btnAplicarFiltros.TabIndex = 7;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            // 
            // dtpRangoHistorialDesde
            // 
            this.dtpRangoHistorialDesde.Location = new System.Drawing.Point(20, 106);
            this.dtpRangoHistorialDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRangoHistorialDesde.Name = "dtpRangoHistorialDesde";
            this.dtpRangoHistorialDesde.Size = new System.Drawing.Size(298, 26);
            this.dtpRangoHistorialDesde.TabIndex = 6;
            // 
            // lblRangoFacturas
            // 
            this.lblRangoFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRangoFacturas.AutoSize = true;
            this.lblRangoFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFacturas.Location = new System.Drawing.Point(36, 18);
            this.lblRangoFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRangoFacturas.Name = "lblRangoFacturas";
            this.lblRangoFacturas.Size = new System.Drawing.Size(163, 25);
            this.lblRangoFacturas.TabIndex = 0;
            this.lblRangoFacturas.Text = "Rango de Fechas";
            // 
            // lblHistorialFacturas
            // 
            this.lblHistorialFacturas.AutoSize = true;
            this.lblHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistorialFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialFacturas.Location = new System.Drawing.Point(0, 0);
            this.lblHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorialFacturas.Name = "lblHistorialFacturas";
            this.lblHistorialFacturas.Size = new System.Drawing.Size(348, 42);
            this.lblHistorialFacturas.TabIndex = 3;
            this.lblHistorialFacturas.Text = "Historial de Facturas";
            // 
            // frmFacturaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltrosHistorialFacturas);
            this.Controls.Add(this.lblHistorialFacturas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFacturaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturaEmpleado";
            this.Load += new System.EventHandler(this.frmFacturaEmpleado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarHistorialFacturas)).EndInit();
            this.pnlFiltrosHistorialFacturas.ResumeLayout(false);
            this.pnlFiltrosHistorialFacturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarHistorialFacturas;
        private System.Windows.Forms.Panel pnlFiltrosHistorialFacturas;
        private System.Windows.Forms.Button btnRecargarFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRangoHistorialHasta;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.DateTimePicker dtpRangoHistorialDesde;
        private System.Windows.Forms.Label lblRangoFacturas;
        private System.Windows.Forms.Label lblHistorialFacturas;
    }
}