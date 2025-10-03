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
            this.pblInfoInventario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pblInfoInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblInfoInventario.Controls.Add(this.pnlProductos);
            this.pblInfoInventario.Controls.Add(this.pnlUsuarios);
            this.pblInfoInventario.Controls.Add(this.pnlVentas);
            this.pblInfoInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblInfoInventario.Location = new System.Drawing.Point(0, 0);
            this.pblInfoInventario.Name = "pblInfoInventario";
            this.pblInfoInventario.Size = new System.Drawing.Size(1114, 166);
            this.pblInfoInventario.TabIndex = 10;
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
            // btnAgregar_Inventario
            // 
            this.btnAgregar_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar_Inventario.FlatAppearance.BorderSize = 0;
            this.btnAgregar_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar_Inventario.Location = new System.Drawing.Point(406, 515);
            this.btnAgregar_Inventario.Name = "btnAgregar_Inventario";
            this.btnAgregar_Inventario.Size = new System.Drawing.Size(117, 47);
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
            this.btnEditar_Inventario.Location = new System.Drawing.Point(546, 515);
            this.btnEditar_Inventario.Name = "btnEditar_Inventario";
            this.btnEditar_Inventario.Size = new System.Drawing.Size(108, 47);
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
            this.btnEliminar_Inventario.Location = new System.Drawing.Point(672, 515);
            this.btnEliminar_Inventario.Name = "btnEliminar_Inventario";
            this.btnEliminar_Inventario.Size = new System.Drawing.Size(104, 47);
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
            this.dgvInventario.Location = new System.Drawing.Point(-28, 192);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(776, 294);
            this.dgvInventario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(985, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(985, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Categoria del producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad de Produtos en Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(985, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo de barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese el nombre del producto";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(984, 273);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 25;
            // 
            // cmbCategoriaProduc
            // 
            this.cmbCategoriaProduc.FormattingEnabled = true;
            this.cmbCategoriaProduc.Location = new System.Drawing.Point(984, 324);
            this.cmbCategoriaProduc.Name = "cmbCategoriaProduc";
            this.cmbCategoriaProduc.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaProduc.TabIndex = 24;
            // 
            // nudCantidadStock
            // 
            this.nudCantidadStock.Location = new System.Drawing.Point(812, 324);
            this.nudCantidadStock.Name = "nudCantidadStock";
            this.nudCantidadStock.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadStock.TabIndex = 23;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(812, 381);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 22;
            // 
            // txtPrecioProduc
            // 
            this.txtPrecioProduc.Location = new System.Drawing.Point(812, 273);
            this.txtPrecioProduc.MaxLength = 50;
            this.txtPrecioProduc.Name = "txtPrecioProduc";
            this.txtPrecioProduc.ShortcutsEnabled = false;
            this.txtPrecioProduc.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioProduc.TabIndex = 21;
            this.txtPrecioProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProduc_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(984, 218);
            this.txtCodigoBarras.MaxLength = 100;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ShortcutsEnabled = false;
            this.txtCodigoBarras.Size = new System.Drawing.Size(118, 20);
            this.txtCodigoBarras.TabIndex = 20;
            // 
            // txtNombreProduc
            // 
            this.txtNombreProduc.Location = new System.Drawing.Point(812, 218);
            this.txtNombreProduc.MaxLength = 50;
            this.txtNombreProduc.Name = "txtNombreProduc";
            this.txtNombreProduc.ShortcutsEnabled = false;
            this.txtNombreProduc.Size = new System.Drawing.Size(123, 20);
            this.txtNombreProduc.TabIndex = 19;
            // 
            // btnLimpiarInven
            // 
            this.btnLimpiarInven.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarInven.Location = new System.Drawing.Point(255, 515);
            this.btnLimpiarInven.Name = "btnLimpiarInven";
            this.btnLimpiarInven.Size = new System.Drawing.Size(126, 47);
            this.btnLimpiarInven.TabIndex = 33;
            this.btnLimpiarInven.Text = "Limpiar";
            this.btnLimpiarInven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarInven.UseVisualStyleBackColor = false;
            this.btnLimpiarInven.Click += new System.EventHandler(this.btnLimpiarInven_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(318, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 21);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEliminar.Image = global::Vistas.Properties.Resources.seo_social_web_network_internet_262_icon_icons1;
            this.pbEliminar.Location = new System.Drawing.Point(730, 522);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(34, 26);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 17;
            this.pbEliminar.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEditar.Image = global::Vistas.Properties.Resources.edit_icon_128873;
            this.pbEditar.Location = new System.Drawing.Point(607, 522);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(34, 26);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEditar.TabIndex = 16;
            this.pbEditar.TabStop = false;
            // 
            // pbAgregar
            // 
            this.pbAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAgregar.Image = global::Vistas.Properties.Resources._1904677_add_addition_calculate_charge_create_new_plus_122527;
            this.pbAgregar.Location = new System.Drawing.Point(475, 522);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(34, 26);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregar.TabIndex = 15;
            this.pbAgregar.TabStop = false;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1114, 560);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1130, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1130, 599);
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