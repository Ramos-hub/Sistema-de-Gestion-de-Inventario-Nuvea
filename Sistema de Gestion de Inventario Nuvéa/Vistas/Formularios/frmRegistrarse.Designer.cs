namespace Vistas.Formularios
{
    partial class frmRegistrarse
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
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtCorreoRegis = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioRegis = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.txtRegistrarseContra = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(310, 325);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(188, 56);
            this.btnCrearCuenta.TabIndex = 17;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtCorreoRegis
            // 
            this.txtCorreoRegis.Location = new System.Drawing.Point(260, 233);
            this.txtCorreoRegis.Name = "txtCorreoRegis";
            this.txtCorreoRegis.Size = new System.Drawing.Size(284, 20);
            this.txtCorreoRegis.TabIndex = 16;
            // 
            // txtNombreUsuarioRegis
            // 
            this.txtNombreUsuarioRegis.Location = new System.Drawing.Point(260, 182);
            this.txtNombreUsuarioRegis.Name = "txtNombreUsuarioRegis";
            this.txtNombreUsuarioRegis.Size = new System.Drawing.Size(284, 20);
            this.txtNombreUsuarioRegis.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(257, 214);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(104, 16);
            this.lblCorreo.TabIndex = 13;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(257, 163);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(109, 16);
            this.lblNombreUsuario.TabIndex = 12;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.Location = new System.Drawing.Point(327, 116);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(141, 31);
            this.lblRegistrarse.TabIndex = 11;
            this.lblRegistrarse.Text = "Registrarse";
            // 
            // txtRegistrarseContra
            // 
            this.txtRegistrarseContra.Location = new System.Drawing.Point(260, 284);
            this.txtRegistrarseContra.Name = "txtRegistrarseContra";
            this.txtRegistrarseContra.Size = new System.Drawing.Size(284, 20);
            this.txtRegistrarseContra.TabIndex = 19;
            this.txtRegistrarseContra.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(257, 265);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(66, 16);
            this.lblContraseña.TabIndex = 18;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(473, 387);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 36);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Vistas.Properties.Resources.Logo_Nuvéa;
            this.pbLogo.Location = new System.Drawing.Point(260, 22);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(253, 91);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // frmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtRegistrarseContra);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtCorreoRegis);
            this.Controls.Add(this.txtNombreUsuarioRegis);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmRegistrarse";
            this.Text = "frmRegistrarse";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtCorreoRegis;
        private System.Windows.Forms.TextBox txtNombreUsuarioRegis;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtRegistrarseContra;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnVolver;
    }
}