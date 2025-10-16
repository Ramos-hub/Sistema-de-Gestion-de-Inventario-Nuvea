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
            this.gbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(126)))), ((int)(((byte)(118)))));
            this.gbInicio.Controls.Add(this.pictureBox1);
            this.gbInicio.Controls.Add(this.lblBienvenidos);
            this.gbInicio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicio.Location = new System.Drawing.Point(0, 0);
            this.gbInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Size = new System.Drawing.Size(1491, 243);
            this.gbInicio.TabIndex = 4;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Vistas.Properties.Resources.icons8_configuración_del_administrador_100;
            this.pictureBox1.Location = new System.Drawing.Point(1202, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 189);
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
            this.lblBienvenidos.Location = new System.Drawing.Point(30, 83);
            this.lblBienvenidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(339, 41);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a Nuvéa";
            // 
            // pnlTotalProductos
            // 
            this.pnlTotalProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlTotalProductos.Controls.Add(this.lbltotalResultadosIni);
            this.pnlTotalProductos.Controls.Add(this.lblTotalProductos);
            this.pnlTotalProductos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTotalProductos.Location = new System.Drawing.Point(24, 292);
            this.pnlTotalProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTotalProductos.Name = "pnlTotalProductos";
            this.pnlTotalProductos.Size = new System.Drawing.Size(216, 102);
            this.pnlTotalProductos.TabIndex = 5;
            // 
            // lbltotalResultadosIni
            // 
            this.lbltotalResultadosIni.AutoSize = true;
            this.lbltotalResultadosIni.Location = new System.Drawing.Point(100, 66);
            this.lbltotalResultadosIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalResultadosIni.Name = "lbltotalResultadosIni";
            this.lbltotalResultadosIni.Size = new System.Drawing.Size(91, 23);
            this.lbltotalResultadosIni.TabIndex = 4;
            this.lbltotalResultadosIni.Text = "Resultado";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(52, 25);
            this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(164, 23);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "Total de Productos";
            // 
            // pnlVentasDiarias
            // 
            this.pnlVentasDiarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlVentasDiarias.Controls.Add(this.lblResultadoVentasIni);
            this.pnlVentasDiarias.Controls.Add(this.lblVentasHoy);
            this.pnlVentasDiarias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentasDiarias.Location = new System.Drawing.Point(399, 292);
            this.pnlVentasDiarias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVentasDiarias.Name = "pnlVentasDiarias";
            this.pnlVentasDiarias.Size = new System.Drawing.Size(216, 102);
            this.pnlVentasDiarias.TabIndex = 6;
            // 
            // lblResultadoVentasIni
            // 
            this.lblResultadoVentasIni.AutoSize = true;
            this.lblResultadoVentasIni.Location = new System.Drawing.Point(123, 66);
            this.lblResultadoVentasIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoVentasIni.Name = "lblResultadoVentasIni";
            this.lblResultadoVentasIni.Size = new System.Drawing.Size(91, 23);
            this.lblResultadoVentasIni.TabIndex = 3;
            this.lblResultadoVentasIni.Text = "Resultado";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(90, 25);
            this.lblVentasHoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(126, 23);
            this.lblVentasHoy.TabIndex = 2;
            this.lblVentasHoy.Text = "Ventas de hoy";
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlCategorias.Controls.Add(this.lblCategoriasIni);
            this.pnlCategorias.Controls.Add(this.label3);
            this.pnlCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategorias.Location = new System.Drawing.Point(792, 292);
            this.pnlCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(216, 102);
            this.pnlCategorias.TabIndex = 6;
            // 
            // lblCategoriasIni
            // 
            this.lblCategoriasIni.AutoSize = true;
            this.lblCategoriasIni.Location = new System.Drawing.Point(126, 66);
            this.lblCategoriasIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriasIni.Name = "lblCategoriasIni";
            this.lblCategoriasIni.Size = new System.Drawing.Size(91, 23);
            this.lblCategoriasIni.TabIndex = 5;
            this.lblCategoriasIni.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categorias";
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlProveedores.Controls.Add(this.lblTotalProveedores);
            this.pnlProveedores.Controls.Add(this.label5);
            this.pnlProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProveedores.Location = new System.Drawing.Point(1172, 292);
            this.pnlProveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(216, 102);
            this.pnlProveedores.TabIndex = 6;
            // 
            // lblTotalProveedores
            // 
            this.lblTotalProveedores.AutoSize = true;
            this.lblTotalProveedores.Location = new System.Drawing.Point(123, 66);
            this.lblTotalProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProveedores.Name = "lblTotalProveedores";
            this.lblTotalProveedores.Size = new System.Drawing.Size(91, 23);
            this.lblTotalProveedores.TabIndex = 6;
            this.lblTotalProveedores.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Proveedores";
            // 
            // gbProductosBajoStock
            // 
            this.gbProductosBajoStock.Controls.Add(this.dgvProductosBajoStock);
            this.gbProductosBajoStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductosBajoStock.Location = new System.Drawing.Point(662, 460);
            this.gbProductosBajoStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductosBajoStock.Name = "gbProductosBajoStock";
            this.gbProductosBajoStock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductosBajoStock.Size = new System.Drawing.Size(796, 480);
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
            this.dgvProductosBajoStock.Location = new System.Drawing.Point(9, 43);
            this.dgvProductosBajoStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            this.dgvProductosBajoStock.ReadOnly = true;
            this.dgvProductosBajoStock.RowHeadersWidth = 62;
            this.dgvProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosBajoStock.Size = new System.Drawing.Size(778, 428);
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
            this.chartVentasUsuarios.Location = new System.Drawing.Point(24, 460);
            this.chartVentasUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartVentasUsuarios.Name = "chartVentasUsuarios";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVentasUsuarios.Series.Add(series3);
            this.chartVentasUsuarios.Size = new System.Drawing.Size(621, 480);
            this.chartVentasUsuarios.TabIndex = 9;
            this.chartVentasUsuarios.Text = "chart1";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(172)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1491, 989);
            this.Controls.Add(this.chartVentasUsuarios);
            this.Controls.Add(this.gbProductosBajoStock);
            this.Controls.Add(this.pnlVentasDiarias);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlTotalProductos);
            this.Controls.Add(this.gbInicio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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