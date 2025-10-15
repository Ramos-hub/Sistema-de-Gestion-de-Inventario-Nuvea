namespace Vistas.Formularios
{
    partial class frmInventarioEmpleado
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
            this.dgvInventarioEmpleado = new System.Windows.Forms.DataGridView();
            this.pblInfoInventario = new System.Windows.Forms.Panel();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.pbProductos = new System.Windows.Forms.PictureBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblResultado_Productos = new System.Windows.Forms.Label();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblResultado_Usuarios = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.lblResultado_Ventas = new System.Windows.Forms.Label();
            this.pbVentas = new System.Windows.Forms.PictureBox();
            this.lblVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioEmpleado)).BeginInit();
            this.pblInfoInventario.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarioEmpleado
            // 
            this.dgvInventarioEmpleado.AllowUserToAddRows = false;
            this.dgvInventarioEmpleado.AllowUserToDeleteRows = false;
            this.dgvInventarioEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventarioEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioEmpleado.Location = new System.Drawing.Point(12, 182);
            this.dgvInventarioEmpleado.Name = "dgvInventarioEmpleado";
            this.dgvInventarioEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioEmpleado.Size = new System.Drawing.Size(986, 355);
            this.dgvInventarioEmpleado.TabIndex = 40;
            // 
            // pblInfoInventario
            // 
            this.pblInfoInventario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pblInfoInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblInfoInventario.Controls.Add(this.pnlProductos);
            this.pblInfoInventario.Controls.Add(this.pnlUsuarios);
            this.pblInfoInventario.Controls.Add(this.pnlVentas);
            this.pblInfoInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblInfoInventario.Location = new System.Drawing.Point(0, 0);
            this.pblInfoInventario.Name = "pblInfoInventario";
            this.pblInfoInventario.Size = new System.Drawing.Size(1010, 166);
            this.pblInfoInventario.TabIndex = 33;
            // 
            // pnlProductos
            // 
            this.pnlProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductos.Controls.Add(this.pbProductos);
            this.pnlProductos.Controls.Add(this.lblProductos);
            this.pnlProductos.Controls.Add(this.lblResultado_Productos);
            this.pnlProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProductos.Location = new System.Drawing.Point(323, 25);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(173, 93);
            this.pnlProductos.TabIndex = 2;
            // 
            // pbProductos
            // 
            this.pbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbProductos.Image = global::Vistas.Properties.Resources.menu_hamburger_burger_icon_176431;
            this.pbProductos.Location = new System.Drawing.Point(0, 0);
            this.pbProductos.Name = "pbProductos";
            this.pbProductos.Size = new System.Drawing.Size(70, 91);
            this.pbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductos.TabIndex = 0;
            this.pbProductos.TabStop = false;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(76, 17);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(77, 16);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            // 
            // lblResultado_Productos
            // 
            this.lblResultado_Productos.AutoSize = true;
            this.lblResultado_Productos.Location = new System.Drawing.Point(76, 63);
            this.lblResultado_Productos.Name = "lblResultado_Productos";
            this.lblResultado_Productos.Size = new System.Drawing.Size(78, 16);
            this.lblResultado_Productos.TabIndex = 4;
            this.lblResultado_Productos.Text = "Resultado";
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.lblResultado_Usuarios);
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Controls.Add(this.pbUsuarios);
            this.pnlUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUsuarios.Location = new System.Drawing.Point(34, 24);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(173, 93);
            this.pnlUsuarios.TabIndex = 2;
            // 
            // lblResultado_Usuarios
            // 
            this.lblResultado_Usuarios.AutoSize = true;
            this.lblResultado_Usuarios.Location = new System.Drawing.Point(80, 63);
            this.lblResultado_Usuarios.Name = "lblResultado_Usuarios";
            this.lblResultado_Usuarios.Size = new System.Drawing.Size(78, 16);
            this.lblResultado_Usuarios.TabIndex = 2;
            this.lblResultado_Usuarios.Text = "Resultado";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(89, 17);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(69, 16);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.profile_picture_user_icon_153847;
            this.pbUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(72, 91);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // pnlVentas
            // 
            this.pnlVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVentas.Controls.Add(this.lblResultado_Ventas);
            this.pnlVentas.Controls.Add(this.pbVentas);
            this.pnlVentas.Controls.Add(this.lblVentas);
            this.pnlVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentas.Location = new System.Drawing.Point(602, 27);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(173, 93);
            this.pnlVentas.TabIndex = 1;
            // 
            // lblResultado_Ventas
            // 
            this.lblResultado_Ventas.AutoSize = true;
            this.lblResultado_Ventas.Location = new System.Drawing.Point(80, 63);
            this.lblResultado_Ventas.Name = "lblResultado_Ventas";
            this.lblResultado_Ventas.Size = new System.Drawing.Size(78, 16);
            this.lblResultado_Ventas.TabIndex = 6;
            this.lblResultado_Ventas.Text = "Resultado";
            // 
            // pbVentas
            // 
            this.pbVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbVentas.Image = global::Vistas.Properties.Resources.dollar_symbol_icon_icons_com_73598;
            this.pbVentas.Location = new System.Drawing.Point(0, 0);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(70, 91);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVentas.TabIndex = 0;
            this.pbVentas.TabStop = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(89, 17);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(55, 16);
            this.lblVentas.TabIndex = 5;
            this.lblVentas.Text = "Ventas";
            // 
            // frmInventarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 549);
            this.Controls.Add(this.dgvInventarioEmpleado);
            this.Controls.Add(this.pblInfoInventario);
            this.Name = "frmInventarioEmpleado";
            this.Text = "frmInventarioEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioEmpleado)).EndInit();
            this.pblInfoInventario.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInventarioEmpleado;
        private System.Windows.Forms.Panel pblInfoInventario;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.PictureBox pbProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblResultado_Productos;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label lblResultado_Usuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblResultado_Ventas;
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.Label lblVentas;
    }
}