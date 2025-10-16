namespace Vistas.Formularios
{
    partial class frmIndexEmpleado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbBajoStockEmp = new System.Windows.Forms.GroupBox();
            this.dgvProductosBajoStockEmpleado = new System.Windows.Forms.DataGridView();
            this.pnlVentasEmp = new System.Windows.Forms.Panel();
            this.lblVentasEmp = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.pnlCategoriasEmp = new System.Windows.Forms.Panel();
            this.lblCategoriasEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTotalProductosEmp = new System.Windows.Forms.Panel();
            this.lblTotalProdEmp = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.gbInicioEmp = new System.Windows.Forms.GroupBox();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.lblBienvenidosEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProductos)).BeginInit();
            this.gbBajoStockEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStockEmpleado)).BeginInit();
            this.pnlVentasEmp.SuspendLayout();
            this.pnlCategoriasEmp.SuspendLayout();
            this.pnlTotalProductosEmp.SuspendLayout();
            this.gbInicioEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTopProductos
            // 
            this.chartTopProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartTopProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopProductos.Legends.Add(legend2);
            this.chartTopProductos.Location = new System.Drawing.Point(24, 484);
            this.chartTopProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTopProductos.Name = "chartTopProductos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProductos.Series.Add(series2);
            this.chartTopProductos.Size = new System.Drawing.Size(621, 480);
            this.chartTopProductos.TabIndex = 16;
            this.chartTopProductos.Text = "chart1";
            // 
            // gbBajoStockEmp
            // 
            this.gbBajoStockEmp.Controls.Add(this.dgvProductosBajoStockEmpleado);
            this.gbBajoStockEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBajoStockEmp.Location = new System.Drawing.Point(662, 484);
            this.gbBajoStockEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBajoStockEmp.Name = "gbBajoStockEmp";
            this.gbBajoStockEmp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBajoStockEmp.Size = new System.Drawing.Size(796, 480);
            this.gbBajoStockEmp.TabIndex = 15;
            this.gbBajoStockEmp.TabStop = false;
            this.gbBajoStockEmp.Text = "Productos Bajo Stock";
            // 
            // dgvProductosBajoStockEmpleado
            // 
            this.dgvProductosBajoStockEmpleado.AllowUserToAddRows = false;
            this.dgvProductosBajoStockEmpleado.AllowUserToDeleteRows = false;
            this.dgvProductosBajoStockEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosBajoStockEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBajoStockEmpleado.Location = new System.Drawing.Point(9, 43);
            this.dgvProductosBajoStockEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductosBajoStockEmpleado.Name = "dgvProductosBajoStockEmpleado";
            this.dgvProductosBajoStockEmpleado.ReadOnly = true;
            this.dgvProductosBajoStockEmpleado.RowHeadersWidth = 62;
            this.dgvProductosBajoStockEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosBajoStockEmpleado.Size = new System.Drawing.Size(778, 428);
            this.dgvProductosBajoStockEmpleado.TabIndex = 0;
            // 
            // pnlVentasEmp
            // 
            this.pnlVentasEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlVentasEmp.Controls.Add(this.lblVentasEmp);
            this.pnlVentasEmp.Controls.Add(this.lblVentasHoy);
            this.pnlVentasEmp.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentasEmp.Location = new System.Drawing.Point(650, 325);
            this.pnlVentasEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVentasEmp.Name = "pnlVentasEmp";
            this.pnlVentasEmp.Size = new System.Drawing.Size(216, 102);
            this.pnlVentasEmp.TabIndex = 12;
            // 
            // lblVentasEmp
            // 
            this.lblVentasEmp.AutoSize = true;
            this.lblVentasEmp.Location = new System.Drawing.Point(123, 66);
            this.lblVentasEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasEmp.Name = "lblVentasEmp";
            this.lblVentasEmp.Size = new System.Drawing.Size(91, 23);
            this.lblVentasEmp.TabIndex = 3;
            this.lblVentasEmp.Text = "Resultado";
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
            // pnlCategoriasEmp
            // 
            this.pnlCategoriasEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlCategoriasEmp.Controls.Add(this.lblCategoriasEmp);
            this.pnlCategoriasEmp.Controls.Add(this.label3);
            this.pnlCategoriasEmp.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategoriasEmp.Location = new System.Drawing.Point(1170, 325);
            this.pnlCategoriasEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCategoriasEmp.Name = "pnlCategoriasEmp";
            this.pnlCategoriasEmp.Size = new System.Drawing.Size(216, 102);
            this.pnlCategoriasEmp.TabIndex = 13;
            // 
            // lblCategoriasEmp
            // 
            this.lblCategoriasEmp.AutoSize = true;
            this.lblCategoriasEmp.Location = new System.Drawing.Point(126, 66);
            this.lblCategoriasEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriasEmp.Name = "lblCategoriasEmp";
            this.lblCategoriasEmp.Size = new System.Drawing.Size(91, 23);
            this.lblCategoriasEmp.TabIndex = 5;
            this.lblCategoriasEmp.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categorias";
            // 
            // pnlTotalProductosEmp
            // 
            this.pnlTotalProductosEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlTotalProductosEmp.Controls.Add(this.lblTotalProdEmp);
            this.pnlTotalProductosEmp.Controls.Add(this.lblTotalProductos);
            this.pnlTotalProductosEmp.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTotalProductosEmp.Location = new System.Drawing.Point(155, 325);
            this.pnlTotalProductosEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTotalProductosEmp.Name = "pnlTotalProductosEmp";
            this.pnlTotalProductosEmp.Size = new System.Drawing.Size(216, 102);
            this.pnlTotalProductosEmp.TabIndex = 11;
            // 
            // lblTotalProdEmp
            // 
            this.lblTotalProdEmp.AutoSize = true;
            this.lblTotalProdEmp.Location = new System.Drawing.Point(100, 66);
            this.lblTotalProdEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProdEmp.Name = "lblTotalProdEmp";
            this.lblTotalProdEmp.Size = new System.Drawing.Size(91, 23);
            this.lblTotalProdEmp.TabIndex = 4;
            this.lblTotalProdEmp.Text = "Resultado";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(27, 9);
            this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(164, 23);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "Total de Productos";
            // 
            // gbInicioEmp
            // 
            this.gbInicioEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInicioEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(126)))), ((int)(((byte)(118)))));
            this.gbInicioEmp.Controls.Add(this.pbEmpleado);
            this.gbInicioEmp.Controls.Add(this.lblBienvenidosEmp);
            this.gbInicioEmp.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicioEmp.Location = new System.Drawing.Point(2, 14);
            this.gbInicioEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicioEmp.Name = "gbInicioEmp";
            this.gbInicioEmp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicioEmp.Size = new System.Drawing.Size(1491, 243);
            this.gbInicioEmp.TabIndex = 10;
            this.gbInicioEmp.TabStop = false;
            this.gbInicioEmp.Text = "Inicio";
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmpleado.Image = global::Vistas.Properties.Resources.icons8_usuario_100;
            this.pbEmpleado.Location = new System.Drawing.Point(1199, 44);
            this.pbEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(248, 189);
            this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpleado.TabIndex = 2;
            this.pbEmpleado.TabStop = false;
            // 
            // lblBienvenidosEmp
            // 
            this.lblBienvenidosEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenidosEmp.AutoSize = true;
            this.lblBienvenidosEmp.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidosEmp.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidosEmp.Location = new System.Drawing.Point(30, 120);
            this.lblBienvenidosEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenidosEmp.Name = "lblBienvenidosEmp";
            this.lblBienvenidosEmp.Size = new System.Drawing.Size(339, 41);
            this.lblBienvenidosEmp.TabIndex = 0;
            this.lblBienvenidosEmp.Text = "Bienvenidos a Nuvéa";
            // 
            // frmIndexEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(172)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1491, 989);
            this.Controls.Add(this.chartTopProductos);
            this.Controls.Add(this.gbBajoStockEmp);
            this.Controls.Add(this.pnlVentasEmp);
            this.Controls.Add(this.pnlCategoriasEmp);
            this.Controls.Add(this.pnlTotalProductosEmp);
            this.Controls.Add(this.gbInicioEmp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIndexEmpleado";
            this.Text = "frmIndexEmpleado";
            this.Load += new System.EventHandler(this.frmIndexEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProductos)).EndInit();
            this.gbBajoStockEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStockEmpleado)).EndInit();
            this.pnlVentasEmp.ResumeLayout(false);
            this.pnlVentasEmp.PerformLayout();
            this.pnlCategoriasEmp.ResumeLayout(false);
            this.pnlCategoriasEmp.PerformLayout();
            this.pnlTotalProductosEmp.ResumeLayout(false);
            this.pnlTotalProductosEmp.PerformLayout();
            this.gbInicioEmp.ResumeLayout(false);
            this.gbInicioEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
        private System.Windows.Forms.GroupBox gbBajoStockEmp;
        private System.Windows.Forms.DataGridView dgvProductosBajoStockEmpleado;
        private System.Windows.Forms.Panel pnlVentasEmp;
        private System.Windows.Forms.Label lblVentasEmp;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Panel pnlCategoriasEmp;
        private System.Windows.Forms.Label lblCategoriasEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTotalProductosEmp;
        private System.Windows.Forms.Label lblTotalProdEmp;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.GroupBox gbInicioEmp;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private System.Windows.Forms.Label lblBienvenidosEmp;
    }
}