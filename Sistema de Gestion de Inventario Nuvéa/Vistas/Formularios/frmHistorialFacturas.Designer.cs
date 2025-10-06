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
            this.lblRangoFacturas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrarHistorialFacturas = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorialFacturas.Name = "lblHistorialFacturas";
            this.lblHistorialFacturas.Size = new System.Drawing.Size(294, 36);
            this.lblHistorialFacturas.TabIndex = 0;
            this.lblHistorialFacturas.Text = "Historial de Facturas";
            // 
            // pnlFiltrosHistorialFacturas
            // 
            this.pnlFiltrosHistorialFacturas.BackColor = System.Drawing.Color.White;
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.label2);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.label1);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dateTimePicker1);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.btnAplicarFiltros);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.dtpRangoHistorial);
            this.pnlFiltrosHistorialFacturas.Controls.Add(this.lblRangoFacturas);
            this.pnlFiltrosHistorialFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosHistorialFacturas.Location = new System.Drawing.Point(0, 36);
            this.pnlFiltrosHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFiltrosHistorialFacturas.Name = "pnlFiltrosHistorialFacturas";
            this.pnlFiltrosHistorialFacturas.Size = new System.Drawing.Size(1067, 126);
            this.pnlFiltrosHistorialFacturas.TabIndex = 1;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(848, 52);
            this.btnAplicarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(188, 46);
            this.btnAplicarFiltros.TabIndex = 7;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // dtpRangoHistorial
            // 
            this.dtpRangoHistorial.Location = new System.Drawing.Point(17, 85);
            this.dtpRangoHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRangoHistorial.Name = "dtpRangoHistorial";
            this.dtpRangoHistorial.Size = new System.Drawing.Size(265, 22);
            this.dtpRangoHistorial.TabIndex = 6;
            // 
            // lblRangoFacturas
            // 
            this.lblRangoFacturas.AutoSize = true;
            this.lblRangoFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFacturas.Location = new System.Drawing.Point(32, 15);
            this.lblRangoFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRangoFacturas.Name = "lblRangoFacturas";
            this.lblRangoFacturas.Size = new System.Drawing.Size(136, 19);
            this.lblRangoFacturas.TabIndex = 0;
            this.lblRangoFacturas.Text = "Rango de Fechas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvMostrarHistorialFacturas);
            this.panel1.Location = new System.Drawing.Point(17, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 340);
            this.panel1.TabIndex = 2;
            // 
            // dgvMostrarHistorialFacturas
            // 
            this.dgvMostrarHistorialFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarHistorialFacturas.Location = new System.Drawing.Point(19, 15);
            this.dgvMostrarHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrarHistorialFacturas.Name = "dgvMostrarHistorialFacturas";
            this.dgvMostrarHistorialFacturas.RowHeadersWidth = 51;
            this.dgvMostrarHistorialFacturas.Size = new System.Drawing.Size(1000, 309);
            this.dgvMostrarHistorialFacturas.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 85);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta:";
            // 
            // frmHistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltrosHistorialFacturas);
            this.Controls.Add(this.lblHistorialFacturas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHistorialFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblRangoFacturas;
        private System.Windows.Forms.DateTimePicker dtpRangoHistorial;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarHistorialFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}