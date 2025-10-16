namespace Vistas.Formularios
{
    partial class frmOlivdasteContraseña
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
            this.pbLogoLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCorreoRecu = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoLogin
            // 
            this.pbLogoLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoLogin.Image = global::Vistas.Properties.Resources.Rules_;
            this.pbLogoLogin.Location = new System.Drawing.Point(309, 9);
            this.pbLogoLogin.Name = "pbLogoLogin";
            this.pbLogoLogin.Size = new System.Drawing.Size(279, 144);
            this.pbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoLogin.TabIndex = 1;
            this.pbLogoLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su correo:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(496, 209);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // txtCorreoRecu
            // 
            this.txtCorreoRecu.Location = new System.Drawing.Point(287, 206);
            this.txtCorreoRecu.MaxLength = 100;
            this.txtCorreoRecu.Name = "txtCorreoRecu";
            this.txtCorreoRecu.ShortcutsEnabled = false;
            this.txtCorreoRecu.Size = new System.Drawing.Size(147, 20);
            this.txtCorreoRecu.TabIndex = 5;
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(287, 241);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(133, 35);
            this.btnEnviarCorreo.TabIndex = 6;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Location = new System.Drawing.Point(436, 241);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 35);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Volver";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(424, 334);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(15, 24);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = ".";
            // 
            // frmOlivdasteContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 441);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.txtCorreoRecu);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogoLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 483);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 480);
            this.Name = "frmOlivdasteContraseña";
            this.Text = "frmOlivdasteContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCorreoRecu;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblInfo;
    }
}