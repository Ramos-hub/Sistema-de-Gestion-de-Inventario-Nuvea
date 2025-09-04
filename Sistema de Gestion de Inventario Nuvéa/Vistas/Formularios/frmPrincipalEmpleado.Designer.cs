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
            this.btnPerfilInventario = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBotonesMenu = new System.Windows.Forms.Panel();
            this.btnInventarioEmpleado = new System.Windows.Forms.Button();
            this.btnFacturacionEmpleado = new System.Windows.Forms.Button();
            this.btnInicioEmpleado = new System.Windows.Forms.Button();
            this.lblLogoFacturacion = new System.Windows.Forms.Label();
            this.pnlPerfilInventario.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBotonesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentralEmpleado
            // 
            this.pnlCentralEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralEmpleado.Location = new System.Drawing.Point(138, 45);
            this.pnlCentralEmpleado.Name = "pnlCentralEmpleado";
            this.pnlCentralEmpleado.Size = new System.Drawing.Size(662, 405);
            this.pnlCentralEmpleado.TabIndex = 15;
            // 
            // pnlPerfilInventario
            // 
            this.pnlPerfilInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.pnlPerfilInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerfilInventario.Controls.Add(this.btnPerfilInventario);
            this.pnlPerfilInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerfilInventario.Location = new System.Drawing.Point(138, 0);
            this.pnlPerfilInventario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPerfilInventario.Name = "pnlPerfilInventario";
            this.pnlPerfilInventario.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPerfilInventario.Size = new System.Drawing.Size(662, 45);
            this.pnlPerfilInventario.TabIndex = 14;
            // 
            // btnPerfilInventario
            // 
            this.btnPerfilInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPerfilInventario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilInventario.Location = new System.Drawing.Point(536, 10);
            this.btnPerfilInventario.Name = "btnPerfilInventario";
            this.btnPerfilInventario.Size = new System.Drawing.Size(114, 23);
            this.btnPerfilInventario.TabIndex = 0;
            this.btnPerfilInventario.Text = "Administrador";
            this.btnPerfilInventario.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.pnlMenu.Controls.Add(this.pnlBotonesMenu);
            this.pnlMenu.Controls.Add(this.lblLogoFacturacion);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(138, 450);
            this.pnlMenu.TabIndex = 13;
            // 
            // pnlBotonesMenu
            // 
            this.pnlBotonesMenu.Controls.Add(this.btnInventarioEmpleado);
            this.pnlBotonesMenu.Controls.Add(this.btnFacturacionEmpleado);
            this.pnlBotonesMenu.Controls.Add(this.btnInicioEmpleado);
            this.pnlBotonesMenu.ForeColor = System.Drawing.Color.White;
            this.pnlBotonesMenu.Location = new System.Drawing.Point(0, 102);
            this.pnlBotonesMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotonesMenu.Name = "pnlBotonesMenu";
            this.pnlBotonesMenu.Size = new System.Drawing.Size(138, 458);
            this.pnlBotonesMenu.TabIndex = 3;
            // 
            // btnInventarioEmpleado
            // 
            this.btnInventarioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.btnInventarioEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInventarioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioEmpleado.Location = new System.Drawing.Point(0, 147);
            this.btnInventarioEmpleado.Name = "btnInventarioEmpleado";
            this.btnInventarioEmpleado.Size = new System.Drawing.Size(138, 29);
            this.btnInventarioEmpleado.TabIndex = 2;
            this.btnInventarioEmpleado.Text = "Inventario";
            this.btnInventarioEmpleado.UseVisualStyleBackColor = false;
            this.btnInventarioEmpleado.Click += new System.EventHandler(this.btnInventarioEmpleado_Click);
            // 
            // btnFacturacionEmpleado
            // 
            this.btnFacturacionEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.btnFacturacionEmpleado.FlatAppearance.BorderSize = 0;
            this.btnFacturacionEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionEmpleado.Location = new System.Drawing.Point(0, 72);
            this.btnFacturacionEmpleado.Name = "btnFacturacionEmpleado";
            this.btnFacturacionEmpleado.Size = new System.Drawing.Size(138, 29);
            this.btnFacturacionEmpleado.TabIndex = 1;
            this.btnFacturacionEmpleado.Text = "Facturación";
            this.btnFacturacionEmpleado.UseVisualStyleBackColor = false;
            this.btnFacturacionEmpleado.Click += new System.EventHandler(this.btnFacturacionEmpleado_Click);
            // 
            // btnInicioEmpleado
            // 
            this.btnInicioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.btnInicioEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicioEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInicioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnInicioEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioEmpleado.Name = "btnInicioEmpleado";
            this.btnInicioEmpleado.Size = new System.Drawing.Size(138, 29);
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
            this.lblLogoFacturacion.Location = new System.Drawing.Point(37, 23);
            this.lblLogoFacturacion.Name = "lblLogoFacturacion";
            this.lblLogoFacturacion.Size = new System.Drawing.Size(61, 22);
            this.lblLogoFacturacion.TabIndex = 0;
            this.lblLogoFacturacion.Text = "Nuvéa";
            // 
            // frmPrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCentralEmpleado);
            this.Controls.Add(this.pnlPerfilInventario);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipalEmpleado";
            this.Text = "frmPrincipalEmpleado";
            this.pnlPerfilInventario.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlBotonesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlCentralEmpleado;
        private System.Windows.Forms.Panel pnlPerfilInventario;
        private System.Windows.Forms.Button btnPerfilInventario;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBotonesMenu;
        private System.Windows.Forms.Button btnInventarioEmpleado;
        private System.Windows.Forms.Button btnFacturacionEmpleado;
        private System.Windows.Forms.Button btnInicioEmpleado;
        private System.Windows.Forms.Label lblLogoFacturacion;
    }
}