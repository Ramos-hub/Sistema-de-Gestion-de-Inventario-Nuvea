namespace Vistas.Formularios
{
    partial class frmCambiarContraseña
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
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.btnConfirmarContrasena = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCambiarContra = new System.Windows.Forms.Label();
            this.pbLogoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(253, 306);
            this.txtConfirmarContrasena.MaxLength = 50;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.ShortcutsEnabled = false;
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(292, 20);
            this.txtConfirmarContrasena.TabIndex = 16;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(253, 233);
            this.txtNuevaContrasena.MaxLength = 50;
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.ShortcutsEnabled = false;
            this.txtNuevaContrasena.Size = new System.Drawing.Size(292, 20);
            this.txtNuevaContrasena.TabIndex = 15;
            // 
            // btnConfirmarContrasena
            // 
            this.btnConfirmarContrasena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmarContrasena.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarContrasena.Location = new System.Drawing.Point(295, 350);
            this.btnConfirmarContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmarContrasena.Name = "btnConfirmarContrasena";
            this.btnConfirmarContrasena.Padding = new System.Windows.Forms.Padding(1);
            this.btnConfirmarContrasena.Size = new System.Drawing.Size(209, 45);
            this.btnConfirmarContrasena.TabIndex = 13;
            this.btnConfirmarContrasena.Text = "Confirmar Contraseña";
            this.btnConfirmarContrasena.UseVisualStyleBackColor = false;
            this.btnConfirmarContrasena.Click += new System.EventHandler(this.btnConfirmarContrasena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirme la Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nueva Contraseña";
            // 
            // lblCambiarContra
            // 
            this.lblCambiarContra.AutoSize = true;
            this.lblCambiarContra.BackColor = System.Drawing.SystemColors.Control;
            this.lblCambiarContra.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContra.Location = new System.Drawing.Point(289, 147);
            this.lblCambiarContra.Name = "lblCambiarContra";
            this.lblCambiarContra.Size = new System.Drawing.Size(245, 31);
            this.lblCambiarContra.TabIndex = 10;
            this.lblCambiarContra.Text = "Cambiar Contraseña";
            // 
            // pbLogoLogin
            // 
            this.pbLogoLogin.Image = global::Vistas.Properties.Resources.Rules_;
            this.pbLogoLogin.Location = new System.Drawing.Point(273, 12);
            this.pbLogoLogin.Name = "pbLogoLogin";
            this.pbLogoLogin.Size = new System.Drawing.Size(275, 188);
            this.pbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoLogin.TabIndex = 9;
            this.pbLogoLogin.TabStop = false;
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.btnConfirmarContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCambiarContra);
            this.Controls.Add(this.pbLogoLogin);
            this.Name = "frmCambiarContraseña";
            this.Text = "frmCambiarContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Button btnConfirmarContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCambiarContra;
        private System.Windows.Forms.PictureBox pbLogoLogin;
    }
}