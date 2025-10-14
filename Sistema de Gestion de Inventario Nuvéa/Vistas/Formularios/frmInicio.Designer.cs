namespace Vistas.Formularios
{
    partial class frmIndex
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.pnlTotalProductos = new System.Windows.Forms.Panel();
            this.lbltotalResultadosIni = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.pnlVentasDiarias = new System.Windows.Forms.Panel();
            this.lblResultadoVentasIni = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.lblCategoriasIni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.lblTotalProveedores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbProductosBajoStock = new System.Windows.Forms.GroupBox();
            this.dgvProductosBajoStock = new System.Windows.Forms.DataGridView();
            this.chartVentasUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTotalProductos.SuspendLayout();
            this.pnlVentasDiarias.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.gbProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInicio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbInicio.Controls.Add(this.pictureBox1);
            this.gbInicio.Controls.Add(this.lblBienvenidos);
            this.gbInicio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicio.Location = new System.Drawing.Point(0, 0);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(994, 158);
            this.gbInicio.TabIndex = 4;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Vistas.Properties.Resources.icons8_configuración_del_administrador_100;
            this.pictureBox1.Location = new System.Drawing.Point(801, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidos.Location = new System.Drawing.Point(20, 54);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(223, 28);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a Nuvéa";
            // 
            // pnlTotalProductos
            // 
            this.pnlTotalProductos.Controls.Add(this.lbltotalResultadosIni);
            this.pnlTotalProductos.Controls.Add(this.lblTotalProductos);
            this.pnlTotalProductos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTotalProductos.Location = new System.Drawing.Point(16, 190);
            this.pnlTotalProductos.Name = "pnlTotalProductos";
            this.pnlTotalProductos.Size = new System.Drawing.Size(144, 66);
            this.pnlTotalProductos.TabIndex = 5;
            // 
            // lbltotalResultadosIni
            // 
            this.lbltotalResultadosIni.AutoSize = true;
            this.lbltotalResultadosIni.Location = new System.Drawing.Point(67, 43);
            this.lbltotalResultadosIni.Name = "lbltotalResultadosIni";
            this.lbltotalResultadosIni.Size = new System.Drawing.Size(59, 16);
            this.lbltotalResultadosIni.TabIndex = 4;
            this.lbltotalResultadosIni.Text = "Resultado";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(35, 16);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(106, 16);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "Total de Productos";
            // 
            // pnlVentasDiarias
            // 
            this.pnlVentasDiarias.Controls.Add(this.lblResultadoVentasIni);
            this.pnlVentasDiarias.Controls.Add(this.lblVentasHoy);
            this.pnlVentasDiarias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentasDiarias.Location = new System.Drawing.Point(266, 190);
            this.pnlVentasDiarias.Name = "pnlVentasDiarias";
            this.pnlVentasDiarias.Size = new System.Drawing.Size(144, 66);
            this.pnlVentasDiarias.TabIndex = 6;
            // 
            // lblResultadoVentasIni
            // 
            this.lblResultadoVentasIni.AutoSize = true;
            this.lblResultadoVentasIni.Location = new System.Drawing.Point(82, 43);
            this.lblResultadoVentasIni.Name = "lblResultadoVentasIni";
            this.lblResultadoVentasIni.Size = new System.Drawing.Size(59, 16);
            this.lblResultadoVentasIni.TabIndex = 3;
            this.lblResultadoVentasIni.Text = "Resultado";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(60, 16);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(81, 16);
            this.lblVentasHoy.TabIndex = 2;
            this.lblVentasHoy.Text = "Ventas de hoy";
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.lblCategoriasIni);
            this.pnlCategorias.Controls.Add(this.label3);
            this.pnlCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategorias.Location = new System.Drawing.Point(528, 190);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(144, 66);
            this.pnlCategorias.TabIndex = 6;
            // 
            // lblCategoriasIni
            // 
            this.lblCategoriasIni.AutoSize = true;
            this.lblCategoriasIni.Location = new System.Drawing.Point(84, 43);
            this.lblCategoriasIni.Name = "lblCategoriasIni";
            this.lblCategoriasIni.Size = new System.Drawing.Size(59, 16);
            this.lblCategoriasIni.TabIndex = 5;
            this.lblCategoriasIni.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categorias";
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.Controls.Add(this.lblTotalProveedores);
            this.pnlProveedores.Controls.Add(this.label5);
            this.pnlProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProveedores.Location = new System.Drawing.Point(781, 190);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(144, 66);
            this.pnlProveedores.TabIndex = 6;
            // 
            // lblTotalProveedores
            // 
            this.lblTotalProveedores.AutoSize = true;
            this.lblTotalProveedores.Location = new System.Drawing.Point(82, 43);
            this.lblTotalProveedores.Name = "lblTotalProveedores";
            this.lblTotalProveedores.Size = new System.Drawing.Size(59, 16);
            this.lblTotalProveedores.TabIndex = 6;
            this.lblTotalProveedores.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Proveedores";
            // 
            // gbProductosBajoStock
            // 
            this.gbProductosBajoStock.Controls.Add(this.dgvProductosBajoStock);
            this.gbProductosBajoStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductosBajoStock.Location = new System.Drawing.Point(441, 299);
            this.gbProductosBajoStock.Name = "gbProductosBajoStock";
            this.gbProductosBajoStock.Size = new System.Drawing.Size(531, 312);
            this.gbProductosBajoStock.TabIndex = 8;
            this.gbProductosBajoStock.TabStop = false;
            this.gbProductosBajoStock.Text = "Productos Bajo Stock";
            // 
            // dgvProductosBajoStock
            // 
            this.dgvProductosBajoStock.AllowUserToAddRows = false;
            this.dgvProductosBajoStock.AllowUserToDeleteRows = false;
            this.dgvProductosBajoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBajoStock.Location = new System.Drawing.Point(6, 28);
            this.dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            this.dgvProductosBajoStock.ReadOnly = true;
            this.dgvProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosBajoStock.Size = new System.Drawing.Size(519, 278);
            this.dgvProductosBajoStock.TabIndex = 0;
            // 
            // chartVentasUsuarios
            // 
            this.chartVentasUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartVentasUsuarios.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVentasUsuarios.Legends.Add(legend3);
            this.chartVentasUsuarios.Location = new System.Drawing.Point(16, 299);
            this.chartVentasUsuarios.Name = "chartVentasUsuarios";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVentasUsuarios.Series.Add(series3);
            this.chartVentasUsuarios.Size = new System.Drawing.Size(414, 312);
            this.chartVentasUsuarios.TabIndex = 9;
            this.chartVentasUsuarios.Text = "chart1";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(994, 643);
            this.Controls.Add(this.chartVentasUsuarios);
            this.Controls.Add(this.gbProductosBajoStock);
            this.Controls.Add(this.pnlVentasDiarias);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlTotalProductos);
            this.Controls.Add(this.gbInicio);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndex";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTotalProductos.ResumeLayout(false);
            this.pnlTotalProductos.PerformLayout();
            this.pnlVentasDiarias.ResumeLayout(false);
            this.pnlVentasDiarias.PerformLayout();
            this.pnlCategorias.ResumeLayout(false);
            this.pnlCategorias.PerformLayout();
            this.pnlProveedores.ResumeLayout(false);
            this.pnlProveedores.PerformLayout();
            this.gbProductosBajoStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Panel pnlTotalProductos;
        private System.Windows.Forms.Panel pnlVentasDiarias;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Label lbltotalResultadosIni;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblResultadoVentasIni;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label lblCategoriasIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalProveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProductosBajoStock;
        private System.Windows.Forms.DataGridView dgvProductosBajoStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasUsuarios;
    }
}