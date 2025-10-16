namespace Vistas.Formularios
{
    partial class frmInventario
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
            this.btnAgregar_Inventario = new System.Windows.Forms.Button();
            this.btnEditar_Inventario = new System.Windows.Forms.Button();
            this.btnEliminar_Inventario = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaProduc = new System.Windows.Forms.ComboBox();
            this.nudCantidadStock = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioProduc = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtNombreProduc = new System.Windows.Forms.TextBox();
            this.btnLimpiarInven = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.pblInfoInventario.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // pblInfoInventario
            // 
            this.pblInfoInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(126)))), ((int)(((byte)(118)))));
            this.pblInfoInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblInfoInventario.Controls.Add(this.pnlProductos);
            this.pblInfoInventario.Controls.Add(this.pnlUsuarios);
            this.pblInfoInventario.Controls.Add(this.pnlVentas);
            this.pblInfoInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblInfoInventario.Location = new System.Drawing.Point(0, 0);
            this.pblInfoInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pblInfoInventario.Name = "pblInfoInventario";
            this.pblInfoInventario.Size = new System.Drawing.Size(1662, 254);
            this.pblInfoInventario.TabIndex = 10;
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductos.Controls.Add(this.pbProductos);
            this.pnlProductos.Controls.Add(this.lblProductos);
            this.pnlProductos.Controls.Add(this.lblResultado_Productos);
            this.pnlProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProductos.Location = new System.Drawing.Point(484, 38);
            this.pnlProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(258, 142);
            this.pnlProductos.TabIndex = 2;
            // 
            // pbProductos
            // 
            this.pbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbProductos.Image = global::Vistas.Properties.Resources.menu_hamburger_burger_icon_176431;
            this.pbProductos.Location = new System.Drawing.Point(0, 0);
            this.pbProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbProductos.Name = "pbProductos";
            this.pbProductos.Size = new System.Drawing.Size(104, 140);
            this.pbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductos.TabIndex = 0;
            this.pbProductos.TabStop = false;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(114, 26);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(109, 25);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            // 
            // lblResultado_Productos
            // 
            this.lblResultado_Productos.AutoSize = true;
            this.lblResultado_Productos.Location = new System.Drawing.Point(114, 97);
            this.lblResultado_Productos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado_Productos.Name = "lblResultado_Productos";
            this.lblResultado_Productos.Size = new System.Drawing.Size(108, 25);
            this.lblResultado_Productos.TabIndex = 4;
            this.lblResultado_Productos.Text = "Resultado";
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.lblResultado_Usuarios);
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Controls.Add(this.pbUsuarios);
            this.pnlUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUsuarios.Location = new System.Drawing.Point(51, 37);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(258, 142);
            this.pnlUsuarios.TabIndex = 2;
            // 
            // lblResultado_Usuarios
            // 
            this.lblResultado_Usuarios.AutoSize = true;
            this.lblResultado_Usuarios.Location = new System.Drawing.Point(120, 97);
            this.lblResultado_Usuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado_Usuarios.Name = "lblResultado_Usuarios";
            this.lblResultado_Usuarios.Size = new System.Drawing.Size(108, 25);
            this.lblResultado_Usuarios.TabIndex = 2;
            this.lblResultado_Usuarios.Text = "Resultado";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(134, 26);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(97, 25);
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
            this.pbUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(107, 140);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.pnlVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVentas.Controls.Add(this.lblResultado_Ventas);
            this.pnlVentas.Controls.Add(this.pbVentas);
            this.pnlVentas.Controls.Add(this.lblVentas);
            this.pnlVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVentas.Location = new System.Drawing.Point(903, 42);
            this.pnlVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(258, 142);
            this.pnlVentas.TabIndex = 1;
            // 
            // lblResultado_Ventas
            // 
            this.lblResultado_Ventas.AutoSize = true;
            this.lblResultado_Ventas.Location = new System.Drawing.Point(120, 97);
            this.lblResultado_Ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado_Ventas.Name = "lblResultado_Ventas";
            this.lblResultado_Ventas.Size = new System.Drawing.Size(108, 25);
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
            this.pbVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(104, 140);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVentas.TabIndex = 0;
            this.pbVentas.TabStop = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(134, 26);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(80, 25);
            this.lblVentas.TabIndex = 5;
            this.lblVentas.Text = "Ventas";
            // 
            // btnAgregar_Inventario
            // 
            this.btnAgregar_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar_Inventario.FlatAppearance.BorderSize = 0;
            this.btnAgregar_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar_Inventario.Location = new System.Drawing.Point(609, 792);
            this.btnAgregar_Inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar_Inventario.Name = "btnAgregar_Inventario";
            this.btnAgregar_Inventario.Size = new System.Drawing.Size(176, 72);
            this.btnAgregar_Inventario.TabIndex = 12;
            this.btnAgregar_Inventario.Text = "Agregar";
            this.btnAgregar_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar_Inventario.UseVisualStyleBackColor = false;
            this.btnAgregar_Inventario.Click += new System.EventHandler(this.btnAgregar_Inventario_Click_1);
            // 
            // btnEditar_Inventario
            // 
            this.btnEditar_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar_Inventario.FlatAppearance.BorderSize = 0;
            this.btnEditar_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar_Inventario.Location = new System.Drawing.Point(819, 792);
            this.btnEditar_Inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar_Inventario.Name = "btnEditar_Inventario";
            this.btnEditar_Inventario.Size = new System.Drawing.Size(162, 72);
            this.btnEditar_Inventario.TabIndex = 13;
            this.btnEditar_Inventario.Text = "Editar";
            this.btnEditar_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar_Inventario.UseVisualStyleBackColor = false;
            this.btnEditar_Inventario.Click += new System.EventHandler(this.btnEditar_Inventario_Click);
            // 
            // btnEliminar_Inventario
            // 
            this.btnEliminar_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar_Inventario.FlatAppearance.BorderSize = 0;
            this.btnEliminar_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar_Inventario.Location = new System.Drawing.Point(1008, 792);
            this.btnEliminar_Inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar_Inventario.Name = "btnEliminar_Inventario";
            this.btnEliminar_Inventario.Size = new System.Drawing.Size(156, 72);
            this.btnEliminar_Inventario.TabIndex = 14;
            this.btnEliminar_Inventario.Text = "Eliminar";
            this.btnEliminar_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_Inventario.UseVisualStyleBackColor = false;
            this.btnEliminar_Inventario.Click += new System.EventHandler(this.btnEliminar_Inventario_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(-42, 295);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1164, 452);
            this.dgvInventario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1214, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1478, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1478, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Categoria del producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1214, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad de Produtos en Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1214, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1478, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo de barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1214, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese el nombre del producto";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(1476, 420);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(180, 28);
            this.cmbProveedor.TabIndex = 25;
            // 
            // cmbCategoriaProduc
            // 
            this.cmbCategoriaProduc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProduc.FormattingEnabled = true;
            this.cmbCategoriaProduc.Location = new System.Drawing.Point(1476, 498);
            this.cmbCategoriaProduc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoriaProduc.Name = "cmbCategoriaProduc";
            this.cmbCategoriaProduc.Size = new System.Drawing.Size(180, 28);
            this.cmbCategoriaProduc.TabIndex = 24;
            // 
            // nudCantidadStock
            // 
            this.nudCantidadStock.Location = new System.Drawing.Point(1218, 498);
            this.nudCantidadStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidadStock.Name = "nudCantidadStock";
            this.nudCantidadStock.Size = new System.Drawing.Size(180, 26);
            this.nudCantidadStock.TabIndex = 23;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(1218, 586);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaIngreso.TabIndex = 22;
            // 
            // txtPrecioProduc
            // 
            this.txtPrecioProduc.Location = new System.Drawing.Point(1218, 420);
            this.txtPrecioProduc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioProduc.MaxLength = 50;
            this.txtPrecioProduc.Name = "txtPrecioProduc";
            this.txtPrecioProduc.ShortcutsEnabled = false;
            this.txtPrecioProduc.Size = new System.Drawing.Size(187, 26);
            this.txtPrecioProduc.TabIndex = 21;
            this.txtPrecioProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProduc_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(1476, 335);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoBarras.MaxLength = 100;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ShortcutsEnabled = false;
            this.txtCodigoBarras.Size = new System.Drawing.Size(175, 26);
            this.txtCodigoBarras.TabIndex = 20;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // txtNombreProduc
            // 
            this.txtNombreProduc.Location = new System.Drawing.Point(1218, 335);
            this.txtNombreProduc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreProduc.MaxLength = 50;
            this.txtNombreProduc.Name = "txtNombreProduc";
            this.txtNombreProduc.ShortcutsEnabled = false;
            this.txtNombreProduc.Size = new System.Drawing.Size(182, 26);
            this.txtNombreProduc.TabIndex = 19;
            this.txtNombreProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProduc_KeyPress);
            // 
            // btnLimpiarInven
            // 
            this.btnLimpiarInven.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarInven.Location = new System.Drawing.Point(382, 792);
            this.btnLimpiarInven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarInven.Name = "btnLimpiarInven";
            this.btnLimpiarInven.Size = new System.Drawing.Size(189, 72);
            this.btnLimpiarInven.TabIndex = 33;
            this.btnLimpiarInven.Text = "Limpiar";
            this.btnLimpiarInven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarInven.UseVisualStyleBackColor = false;
            this.btnLimpiarInven.Click += new System.EventHandler(this.btnLimpiarInven_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(477, 811);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 32);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEliminar.Image = global::Vistas.Properties.Resources.seo_social_web_network_internet_262_icon_icons1;
            this.pbEliminar.Location = new System.Drawing.Point(1095, 803);
            this.pbEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(50, 39);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 17;
            this.pbEliminar.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEditar.Image = global::Vistas.Properties.Resources.edit_icon_128873;
            this.pbEditar.Location = new System.Drawing.Point(910, 803);
            this.pbEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(50, 39);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEditar.TabIndex = 16;
            this.pbEditar.TabStop = false;
            // 
            // pbAgregar
            // 
            this.pbAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAgregar.Image = global::Vistas.Properties.Resources._1904677_add_addition_calculate_charge_create_new_plus_122527;
            this.pbAgregar.Location = new System.Drawing.Point(712, 803);
            this.pbAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(50, 39);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregar.TabIndex = 15;
            this.pbAgregar.TabStop = false;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1662, 835);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiarInven);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbCategoriaProduc);
            this.Controls.Add(this.nudCantidadStock);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtPrecioProduc);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtNombreProduc);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbAgregar);
            this.Controls.Add(this.pblInfoInventario);
            this.Controls.Add(this.btnEditar_Inventario);
            this.Controls.Add(this.btnAgregar_Inventario);
            this.Controls.Add(this.btnEliminar_Inventario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1684, 891);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1684, 891);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pblInfoInventario;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.PictureBox pbProductos;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.Button btnAgregar_Inventario;
        private System.Windows.Forms.Button btnEditar_Inventario;
        private System.Windows.Forms.Button btnEliminar_Inventario;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblResultado_Productos;
        private System.Windows.Forms.Label lblResultado_Usuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblResultado_Ventas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbCategoriaProduc;
        private System.Windows.Forms.NumericUpDown nudCantidadStock;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtPrecioProduc;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtNombreProduc;
        private System.Windows.Forms.Button btnLimpiarInven;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}