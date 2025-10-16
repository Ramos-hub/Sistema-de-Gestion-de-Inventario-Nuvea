namespace Vistas.Formularios
{
    partial class frmLogin
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
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnOlvidasteContraseña = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pbLogoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.SystemColors.Control;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(324, 135);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(164, 31);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(265, 189);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(265, 263);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 19);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(321, 340);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Padding = new System.Windows.Forms.Padding(1);
            this.btnIniciarSesion.Size = new System.Drawing.Size(167, 45);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnOlvidasteContraseña
            // 
            this.btnOlvidasteContraseña.FlatAppearance.BorderSize = 0;
            this.btnOlvidasteContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvidasteContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidasteContraseña.Location = new System.Drawing.Point(345, 404);
            this.btnOlvidasteContraseña.Name = "btnOlvidasteContraseña";
            this.btnOlvidasteContraseña.Size = new System.Drawing.Size(116, 20);
            this.btnOlvidasteContraseña.TabIndex = 6;
            this.btnOlvidasteContraseña.Text = "¿Olvidaste tu Contraseña?";
            this.btnOlvidasteContraseña.UseVisualStyleBackColor = true;
            this.btnOlvidasteContraseña.Click += new System.EventHandler(this.btnOlvidasteContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(249, 219);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(292, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(249, 292);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(292, 20);
            this.txtClave.TabIndex = 8;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // pbLogoLogin
            // 
            this.pbLogoLogin.Image = global::Vistas.Properties.Resources.Rules_;
            this.pbLogoLogin.Location = new System.Drawing.Point(269, -2);
            this.pbLogoLogin.Name = "pbLogoLogin";
            this.pbLogoLogin.Size = new System.Drawing.Size(275, 188);
            this.pbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoLogin.TabIndex = 0;
            this.pbLogoLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnOlvidasteContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.pbLogoLogin);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoLogin;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnOlvidasteContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
    }
}