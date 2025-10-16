namespace Vistas.Formularios
{
    partial class frmPrincipalEmpleado
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
            this.pnlCentralEmpleado = new System.Windows.Forms.Panel();
            this.pnlPerfilInventario = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBotonesMenu = new System.Windows.Forms.Panel();
            this.btnCambiarContraseñaEm = new System.Windows.Forms.Button();
            this.btnSoporteEm = new System.Windows.Forms.Button();
            this.btnInventarioEmpleado = new System.Windows.Forms.Button();
            this.btnFacturacionEmpleado = new System.Windows.Forms.Button();
            this.btnInicioEmpleado = new System.Windows.Forms.Button();
            this.lblLogoFacturacion = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlPerfilInventario.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBotonesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentralEmpleado
            // 
            this.pnlCentralEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralEmpleado.Location = new System.Drawing.Point(207, 68);
            this.pnlCentralEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCentralEmpleado.Name = "pnlCentralEmpleado";
            this.pnlCentralEmpleado.Size = new System.Drawing.Size(993, 624);
            this.pnlCentralEmpleado.TabIndex = 15;
            // 
            // pnlPerfilInventario
            // 
            this.pnlPerfilInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.pnlPerfilInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerfilInventario.Controls.Add(this.btnCerrarSesion);
            this.pnlPerfilInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerfilInventario.Location = new System.Drawing.Point(207, 0);
            this.pnlPerfilInventario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPerfilInventario.Name = "pnlPerfilInventario";
            this.pnlPerfilInventario.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPerfilInventario.Size = new System.Drawing.Size(993, 68);
            this.pnlPerfilInventario.TabIndex = 14;
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(207, 692);
            this.pnlMenu.TabIndex = 13;
            // 
            // pnlBotonesMenu
            // 
            this.pnlBotonesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.pnlBotonesMenu.Controls.Add(this.btnCambiarContraseñaEm);
            this.pnlBotonesMenu.Controls.Add(this.btnSoporteEm);
            this.pnlBotonesMenu.Controls.Add(this.btnInventarioEmpleado);
            this.pnlBotonesMenu.Controls.Add(this.btnFacturacionEmpleado);
            this.pnlBotonesMenu.Controls.Add(this.btnInicioEmpleado);
            this.pnlBotonesMenu.ForeColor = System.Drawing.Color.White;
            this.pnlBotonesMenu.Location = new System.Drawing.Point(0, 157);
            this.pnlBotonesMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotonesMenu.Name = "pnlBotonesMenu";
            this.pnlBotonesMenu.Size = new System.Drawing.Size(207, 705);
            this.pnlBotonesMenu.TabIndex = 3;
            // 
            // btnCambiarContraseñaEm
            // 
            this.btnCambiarContraseñaEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnCambiarContraseñaEm.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseñaEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseñaEm.Location = new System.Drawing.Point(0, 350);
            this.btnCambiarContraseñaEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarContraseñaEm.Name = "btnCambiarContraseñaEm";
            this.btnCambiarContraseñaEm.Size = new System.Drawing.Size(207, 86);
            this.btnCambiarContraseñaEm.TabIndex = 4;
            this.btnCambiarContraseñaEm.Text = "Cambiar Contraseña";
            this.btnCambiarContraseñaEm.UseVisualStyleBackColor = false;
            this.btnCambiarContraseñaEm.Click += new System.EventHandler(this.btnCambiarContraseñaEm_Click);
            // 
            // btnSoporteEm
            // 
            this.btnSoporteEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnSoporteEm.FlatAppearance.BorderSize = 0;
            this.btnSoporteEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoporteEm.Location = new System.Drawing.Point(4, 262);
            this.btnSoporteEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSoporteEm.Name = "btnSoporteEm";
            this.btnSoporteEm.Size = new System.Drawing.Size(207, 45);
            this.btnSoporteEm.TabIndex = 3;
            this.btnSoporteEm.Text = "Soporte";
            this.btnSoporteEm.UseVisualStyleBackColor = false;
            this.btnSoporteEm.Click += new System.EventHandler(this.btnSoporteEm_Click);
            // 
            // btnInventarioEmpleado
            // 
            this.btnInventarioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnInventarioEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInventarioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioEmpleado.Location = new System.Drawing.Point(4, 173);
            this.btnInventarioEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventarioEmpleado.Name = "btnInventarioEmpleado";
            this.btnInventarioEmpleado.Size = new System.Drawing.Size(207, 45);
            this.btnInventarioEmpleado.TabIndex = 2;
            this.btnInventarioEmpleado.Text = "Inventario";
            this.btnInventarioEmpleado.UseVisualStyleBackColor = false;
            this.btnInventarioEmpleado.Click += new System.EventHandler(this.btnInventarioEmpleado_Click);
            // 
            // btnFacturacionEmpleado
            // 
            this.btnFacturacionEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnFacturacionEmpleado.FlatAppearance.BorderSize = 0;
            this.btnFacturacionEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionEmpleado.Location = new System.Drawing.Point(-4, 86);
            this.btnFacturacionEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFacturacionEmpleado.Name = "btnFacturacionEmpleado";
            this.btnFacturacionEmpleado.Size = new System.Drawing.Size(207, 45);
            this.btnFacturacionEmpleado.TabIndex = 1;
            this.btnFacturacionEmpleado.Text = "Historial Facturas";
            this.btnFacturacionEmpleado.UseVisualStyleBackColor = false;
            this.btnFacturacionEmpleado.Click += new System.EventHandler(this.btnFacturacionEmpleado_Click);
            // 
            // btnInicioEmpleado
            // 
            this.btnInicioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnInicioEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicioEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInicioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnInicioEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioEmpleado.Name = "btnInicioEmpleado";
            this.btnInicioEmpleado.Size = new System.Drawing.Size(207, 45);
            this.btnInicioEmpleado.TabIndex = 0;
            this.btnInicioEmpleado.Text = "Inicio";
            this.btnInicioEmpleado.UseVisualStyleBackColor = false;
            this.btnInicioEmpleado.Click += new System.EventHandler(this.btnInicioEmpleado_Click);
            // 
            // lblLogoFacturacion
            // 
            this.lblLogoFacturacion.AutoSize = true;
            this.lblLogoFacturacion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoFacturacion.ForeColor = System.Drawing.Color.White;
            this.lblLogoFacturacion.Location = new System.Drawing.Point(56, 35);
            this.lblLogoFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoFacturacion.Name = "lblLogoFacturacion";
            this.lblLogoFacturacion.Size = new System.Drawing.Size(92, 31);
            this.lblLogoFacturacion.TabIndex = 0;
            this.lblLogoFacturacion.Text = "Nuvéa";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.Location = new System.Drawing.Point(769, 15);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(207, 36);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlCentralEmpleado);
            this.Controls.Add(this.pnlPerfilInventario);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipalEmpleado";
            this.Text = "frmPrincipalEmpleado";
            this.pnlPerfilInventario.ResumeLayout(false);
            this.pnlPerfilInventario.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlBotonesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlCentralEmpleado;
        private System.Windows.Forms.Panel pnlPerfilInventario;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBotonesMenu;
        private System.Windows.Forms.Button btnInventarioEmpleado;
        private System.Windows.Forms.Button btnFacturacionEmpleado;
        private System.Windows.Forms.Button btnInicioEmpleado;
        private System.Windows.Forms.Label lblLogoFacturacion;
        private System.Windows.Forms.Button btnCambiarContraseñaEm;
        private System.Windows.Forms.Button btnSoporteEm;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}