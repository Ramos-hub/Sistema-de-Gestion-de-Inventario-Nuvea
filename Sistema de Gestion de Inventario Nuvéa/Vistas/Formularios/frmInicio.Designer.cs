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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.pnlTotalProductos = new System.Windows.Forms.Panel();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.pnlVentasDiarias = new System.Windows.Forms.Panel();
            this.lblResultadoVentas = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.lblTotalProveedores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAccesoRapido = new System.Windows.Forms.GroupBox();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.btnIrInventario = new System.Windows.Forms.Button();
            this.btnAgregarProductosIndex = new System.Windows.Forms.Button();
            this.gbProductosBajoStock = new System.Windows.Forms.GroupBox();
            this.dgvProductosBajoStock = new System.Windows.Forms.DataGridView();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTotalProductos.SuspendLayout();
            this.pnlVentasDiarias.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.gbAccesoRapido.SuspendLayout();
            this.gbProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbInicio.Controls.Add(this.pictureBox1);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Controls.Add(this.lblBienvenidos);
            this.gbInicio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicio.Location = new System.Drawing.Point(0, 0);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(800, 146);
            this.gbInicio.TabIndex = 4;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.profile_picture_user_icon_153847;
            this.pictureBox1.Location = new System.Drawing.Point(536, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "El mejor sistema de inventario";
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidos.Location = new System.Drawing.Point(3, 31);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(223, 28);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a Nuvéa";
            // 
            // pnlTotalProductos
            // 
            this.pnlTotalProductos.Controls.Add(this.lblResultadoTotal);
            this.pnlTotalProductos.Controls.Add(this.lblTotalProductos);
            this.pnlTotalProductos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTotalProductos.Location = new System.Drawing.Point(50, 165);
            this.pnlTotalProductos.Name = "pnlTotalProductos";
            this.pnlTotalProductos.Size = new System.Drawing.Size(144, 66);
            this.pnlTotalProductos.TabIndex = 5;
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Location = new System.Drawing.Point(67, 43);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(59, 16);
            this.lblResultadoTotal.TabIndex = 4;
            this.lblResultadoTotal.Text = "Resultado";
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
            this.pnlVentasDiarias.Controls.Add(this.lblResultadoVentas);
            this.pnlVentasDiarias.Controls.Add(this.lblVentasHoy);
            this.pnlVentasDiarias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentasDiarias.Location = new System.Drawing.Point(237, 165);
            this.pnlVentasDiarias.Name = "pnlVentasDiarias";
            this.pnlVentasDiarias.Size = new System.Drawing.Size(144, 66);
            this.pnlVentasDiarias.TabIndex = 6;
            // 
            // lblResultadoVentas
            // 
            this.lblResultadoVentas.AutoSize = true;
            this.lblResultadoVentas.Location = new System.Drawing.Point(82, 43);
            this.lblResultadoVentas.Name = "lblResultadoVentas";
            this.lblResultadoVentas.Size = new System.Drawing.Size(59, 16);
            this.lblResultadoVentas.TabIndex = 3;
            this.lblResultadoVentas.Text = "Resultado";
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
            this.pnlCategorias.Controls.Add(this.lblCategorias);
            this.pnlCategorias.Controls.Add(this.label3);
            this.pnlCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategorias.Location = new System.Drawing.Point(434, 165);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(144, 66);
            this.pnlCategorias.TabIndex = 6;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(84, 43);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(59, 16);
            this.lblCategorias.TabIndex = 5;
            this.lblCategorias.Text = "Resultado";
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
            this.pnlProveedores.Location = new System.Drawing.Point(636, 165);
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
            // gbAccesoRapido
            // 
            this.gbAccesoRapido.Controls.Add(this.btnVerFacturas);
            this.gbAccesoRapido.Controls.Add(this.btnVerProveedores);
            this.gbAccesoRapido.Controls.Add(this.btnIrInventario);
            this.gbAccesoRapido.Controls.Add(this.btnAgregarProductosIndex);
            this.gbAccesoRapido.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccesoRapido.Location = new System.Drawing.Point(50, 280);
            this.gbAccesoRapido.Name = "gbAccesoRapido";
            this.gbAccesoRapido.Size = new System.Drawing.Size(267, 146);
            this.gbAccesoRapido.TabIndex = 7;
            this.gbAccesoRapido.TabStop = false;
            this.gbAccesoRapido.Text = "Acceso Rápido";
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFacturas.Location = new System.Drawing.Point(148, 99);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(84, 32);
            this.btnVerFacturas.TabIndex = 3;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProveedores.Location = new System.Drawing.Point(17, 99);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(88, 32);
            this.btnVerProveedores.TabIndex = 2;
            this.btnVerProveedores.Text = "Ver Proveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = true;
            // 
            // btnIrInventario
            // 
            this.btnIrInventario.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrInventario.Location = new System.Drawing.Point(148, 38);
            this.btnIrInventario.Name = "btnIrInventario";
            this.btnIrInventario.Size = new System.Drawing.Size(84, 29);
            this.btnIrInventario.TabIndex = 1;
            this.btnIrInventario.Text = "Ir a Inventario";
            this.btnIrInventario.UseVisualStyleBackColor = true;
            this.btnIrInventario.Click += new System.EventHandler(this.btnIrInventario_Click);
            // 
            // btnAgregarProductosIndex
            // 
            this.btnAgregarProductosIndex.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosIndex.Location = new System.Drawing.Point(17, 38);
            this.btnAgregarProductosIndex.Name = "btnAgregarProductosIndex";
            this.btnAgregarProductosIndex.Size = new System.Drawing.Size(88, 29);
            this.btnAgregarProductosIndex.TabIndex = 0;
            this.btnAgregarProductosIndex.Text = "Agregar Productos";
            this.btnAgregarProductosIndex.UseVisualStyleBackColor = true;
            // 
            // gbProductosBajoStock
            // 
            this.gbProductosBajoStock.Controls.Add(this.dgvProductosBajoStock);
            this.gbProductosBajoStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductosBajoStock.Location = new System.Drawing.Point(472, 280);
            this.gbProductosBajoStock.Name = "gbProductosBajoStock";
            this.gbProductosBajoStock.Size = new System.Drawing.Size(288, 158);
            this.gbProductosBajoStock.TabIndex = 8;
            this.gbProductosBajoStock.TabStop = false;
            this.gbProductosBajoStock.Text = "Productos Bajo Stock";
            // 
            // dgvProductosBajoStock
            // 
            this.dgvProductosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBajoStock.Location = new System.Drawing.Point(15, 28);
            this.dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            this.dgvProductosBajoStock.Size = new System.Drawing.Size(267, 118);
            this.dgvProductosBajoStock.TabIndex = 0;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.gbProductosBajoStock);
            this.Controls.Add(this.gbAccesoRapido);
            this.Controls.Add(this.pnlVentasDiarias);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlTotalProductos);
            this.Controls.Add(this.gbInicio);
           
            this.Name = "frmIndex";
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
            this.gbAccesoRapido.ResumeLayout(false);
            this.gbProductosBajoStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajoStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTotalProductos;
        private System.Windows.Forms.Panel pnlVentasDiarias;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblResultadoVentas;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalProveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAccesoRapido;
        private System.Windows.Forms.GroupBox gbProductosBajoStock;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnIrInventario;
        private System.Windows.Forms.Button btnAgregarProductosIndex;
        private System.Windows.Forms.DataGridView dgvProductosBajoStock;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}