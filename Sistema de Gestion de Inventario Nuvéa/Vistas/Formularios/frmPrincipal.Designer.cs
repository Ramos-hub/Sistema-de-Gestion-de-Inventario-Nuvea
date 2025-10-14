namespace Vistas.Formularios
{
    partial class frmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBotonesMenu = new System.Windows.Forms.Panel();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnInventarioHistorial = new System.Windows.Forms.Button();
            this.btnInventarioProveedores = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btnFacturacionInventario = new System.Windows.Forms.Button();
            this.btnIniciInventario = new System.Windows.Forms.Button();
            this.lblLogoFacturacion = new System.Windows.Forms.Label();
            this.pnlPerfilInventario = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnCrearEmpleadoPrincipal = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlBotonesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlBotonesMenu);
            this.pnlMenu.Controls.Add(this.lblLogoFacturacion);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(138, 507);
            this.pnlMenu.TabIndex = 6;
            // 
            // pnlBotonesMenu
            // 
            this.pnlBotonesMenu.Controls.Add(this.btnCrearEmpleadoPrincipal);
            this.pnlBotonesMenu.Controls.Add(this.btnGanancias);
            this.pnlBotonesMenu.Controls.Add(this.btnInventarioHistorial);
            this.pnlBotonesMenu.Controls.Add(this.btnInventarioProveedores);
            this.pnlBotonesMenu.Controls.Add(this.btn_Inventario);
            this.pnlBotonesMenu.Controls.Add(this.btnFacturacionInventario);
            this.pnlBotonesMenu.Controls.Add(this.btnIniciInventario);
            this.pnlBotonesMenu.ForeColor = System.Drawing.Color.White;
            this.pnlBotonesMenu.Location = new System.Drawing.Point(0, 102);
            this.pnlBotonesMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotonesMenu.Name = "pnlBotonesMenu";
            this.pnlBotonesMenu.Size = new System.Drawing.Size(138, 458);
            this.pnlBotonesMenu.TabIndex = 3;
            // 
            // btnGanancias
            // 
            this.btnGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnGanancias.FlatAppearance.BorderSize = 0;
            this.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancias.Location = new System.Drawing.Point(0, 284);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(138, 29);
            this.btnGanancias.TabIndex = 4;
            this.btnGanancias.Text = "Ganancias";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnInventarioHistorial
            // 
            this.btnInventarioHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnInventarioHistorial.FlatAppearance.BorderSize = 0;
            this.btnInventarioHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioHistorial.Location = new System.Drawing.Point(0, 220);
            this.btnInventarioHistorial.Name = "btnInventarioHistorial";
            this.btnInventarioHistorial.Size = new System.Drawing.Size(138, 48);
            this.btnInventarioHistorial.TabIndex = 3;
            this.btnInventarioHistorial.Text = "Historial de Facturas";
            this.btnInventarioHistorial.UseVisualStyleBackColor = false;
            this.btnInventarioHistorial.Click += new System.EventHandler(this.btnInventarioHistorial_Click);
            // 
            // btnInventarioProveedores
            // 
            this.btnInventarioProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnInventarioProveedores.FlatAppearance.BorderSize = 0;
            this.btnInventarioProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioProveedores.Location = new System.Drawing.Point(0, 168);
            this.btnInventarioProveedores.Name = "btnInventarioProveedores";
            this.btnInventarioProveedores.Size = new System.Drawing.Size(138, 29);
            this.btnInventarioProveedores.TabIndex = 3;
            this.btnInventarioProveedores.Text = "Proveedores";
            this.btnInventarioProveedores.UseVisualStyleBackColor = false;
            this.btnInventarioProveedores.Click += new System.EventHandler(this.btnInventarioProveedores_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btn_Inventario.FlatAppearance.BorderSize = 0;
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventario.Location = new System.Drawing.Point(0, 112);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(138, 29);
            this.btn_Inventario.TabIndex = 2;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = false;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btnFacturacionInventario
            // 
            this.btnFacturacionInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnFacturacionInventario.FlatAppearance.BorderSize = 0;
            this.btnFacturacionInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionInventario.Location = new System.Drawing.Point(0, 52);
            this.btnFacturacionInventario.Name = "btnFacturacionInventario";
            this.btnFacturacionInventario.Size = new System.Drawing.Size(138, 29);
            this.btnFacturacionInventario.TabIndex = 1;
            this.btnFacturacionInventario.Text = "Facturación";
            this.btnFacturacionInventario.UseVisualStyleBackColor = false;
            this.btnFacturacionInventario.Click += new System.EventHandler(this.btnFacturacionInventario_Click);
            // 
            // btnIniciInventario
            // 
            this.btnIniciInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnIniciInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciInventario.FlatAppearance.BorderSize = 0;
            this.btnIniciInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciInventario.Location = new System.Drawing.Point(0, 0);
            this.btnIniciInventario.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciInventario.Name = "btnIniciInventario";
            this.btnIniciInventario.Size = new System.Drawing.Size(138, 29);
            this.btnIniciInventario.TabIndex = 0;
            this.btnIniciInventario.Text = "Inicio";
            this.btnIniciInventario.UseVisualStyleBackColor = false;
            this.btnIniciInventario.Click += new System.EventHandler(this.btnIniciInventario_Click);
            // 
            // lblLogoFacturacion
            // 
            this.lblLogoFacturacion.AutoSize = true;
            this.lblLogoFacturacion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoFacturacion.ForeColor = System.Drawing.Color.White;
            this.lblLogoFacturacion.Location = new System.Drawing.Point(37, 23);
            this.lblLogoFacturacion.Name = "lblLogoFacturacion";
            this.lblLogoFacturacion.Size = new System.Drawing.Size(61, 22);
            this.lblLogoFacturacion.TabIndex = 0;
            this.lblLogoFacturacion.Text = "Nuvéa";
            // 
            // pnlPerfilInventario
            // 
            this.pnlPerfilInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.pnlPerfilInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerfilInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerfilInventario.Location = new System.Drawing.Point(138, 0);
            this.pnlPerfilInventario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPerfilInventario.Name = "pnlPerfilInventario";
            this.pnlPerfilInventario.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPerfilInventario.Size = new System.Drawing.Size(662, 45);
            this.pnlPerfilInventario.TabIndex = 11;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(138, 45);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(662, 462);
            this.pnlCentral.TabIndex = 12;
            // 
            // btnCrearEmpleadoPrincipal
            // 
            this.btnCrearEmpleadoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnCrearEmpleadoPrincipal.FlatAppearance.BorderSize = 0;
            this.btnCrearEmpleadoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEmpleadoPrincipal.Location = new System.Drawing.Point(0, 319);
            this.btnCrearEmpleadoPrincipal.Name = "btnCrearEmpleadoPrincipal";
            this.btnCrearEmpleadoPrincipal.Size = new System.Drawing.Size(138, 29);
            this.btnCrearEmpleadoPrincipal.TabIndex = 5;
            this.btnCrearEmpleadoPrincipal.Text = "Crear Empleado";
            this.btnCrearEmpleadoPrincipal.UseVisualStyleBackColor = false;
            this.btnCrearEmpleadoPrincipal.Click += new System.EventHandler(this.btnCrearEmpleadoPrincipal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlPerfilInventario);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlBotonesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotonesMenu;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnInventarioHistorial;
        private System.Windows.Forms.Button btnInventarioProveedores;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btnFacturacionInventario;
        private System.Windows.Forms.Button btnIniciInventario;
        private System.Windows.Forms.Label lblLogoFacturacion;
        private System.Windows.Forms.Panel pnlPerfilInventario;
        private System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnCrearEmpleadoPrincipal;
    }
}