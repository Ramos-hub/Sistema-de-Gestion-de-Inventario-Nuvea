namespace Vistas.Formularios
{
    partial class frmPrimerUso
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarPrimerUso = new System.Windows.Forms.Button();
            this.txtPrimerCorreo = new System.Windows.Forms.TextBox();
            this.txtPrimerTelefono = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreRepresentante = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.btnContinuarPrimerUso = new System.Windows.Forms.Button();
            this.lblGenerarContrasena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Rules_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarPrimerUso
            // 
            this.btnGuardarPrimerUso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPrimerUso.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuardarPrimerUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrimerUso.Location = new System.Drawing.Point(206, 337);
            this.btnGuardarPrimerUso.Name = "btnGuardarPrimerUso";
            this.btnGuardarPrimerUso.Size = new System.Drawing.Size(185, 95);
            this.btnGuardarPrimerUso.TabIndex = 41;
            this.btnGuardarPrimerUso.Text = "Guardar ";
            this.btnGuardarPrimerUso.UseVisualStyleBackColor = false;
            this.btnGuardarPrimerUso.Click += new System.EventHandler(this.btnGuardarPrimerUso_Click);
            // 
            // txtPrimerCorreo
            // 
            this.txtPrimerCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerCorreo.Location = new System.Drawing.Point(143, 121);
            this.txtPrimerCorreo.Name = "txtPrimerCorreo";
            this.txtPrimerCorreo.Size = new System.Drawing.Size(563, 20);
            this.txtPrimerCorreo.TabIndex = 40;
            // 
            // txtPrimerTelefono
            // 
            this.txtPrimerTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerTelefono.Location = new System.Drawing.Point(143, 193);
            this.txtPrimerTelefono.Name = "txtPrimerTelefono";
            this.txtPrimerTelefono.Size = new System.Drawing.Size(563, 20);
            this.txtPrimerTelefono.TabIndex = 37;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerNombre.Location = new System.Drawing.Point(143, 56);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(563, 20);
            this.txtPrimerNombre.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Número Telefónico:";
            // 
            // lblNombreRepresentante
            // 
            this.lblNombreRepresentante.AutoSize = true;
            this.lblNombreRepresentante.Location = new System.Drawing.Point(409, 93);
            this.lblNombreRepresentante.Name = "lblNombreRepresentante";
            this.lblNombreRepresentante.Size = new System.Drawing.Size(41, 13);
            this.lblNombreRepresentante.TabIndex = 32;
            this.lblNombreRepresentante.Text = "Correo:";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(409, 24);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEmpresa.TabIndex = 31;
            this.lblNombreEmpresa.Text = "Nombre:";
            // 
            // btnContinuarPrimerUso
            // 
            this.btnContinuarPrimerUso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuarPrimerUso.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnContinuarPrimerUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarPrimerUso.Location = new System.Drawing.Point(471, 337);
            this.btnContinuarPrimerUso.Name = "btnContinuarPrimerUso";
            this.btnContinuarPrimerUso.Size = new System.Drawing.Size(185, 95);
            this.btnContinuarPrimerUso.TabIndex = 44;
            this.btnContinuarPrimerUso.Text = "Continuar";
            this.btnContinuarPrimerUso.UseVisualStyleBackColor = false;
            this.btnContinuarPrimerUso.Click += new System.EventHandler(this.btnContinuarPrimerUso_Click);
            // 
            // lblGenerarContrasena
            // 
            this.lblGenerarContrasena.AutoSize = true;
            this.lblGenerarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarContrasena.Location = new System.Drawing.Point(322, 261);
            this.lblGenerarContrasena.Name = "lblGenerarContrasena";
            this.lblGenerarContrasena.Size = new System.Drawing.Size(198, 20);
            this.lblGenerarContrasena.TabIndex = 45;
            this.lblGenerarContrasena.Text = "Contrasena Automatica";
            // 
            // frmPrimerUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(830, 566);
            this.Controls.Add(this.lblGenerarContrasena);
            this.Controls.Add(this.btnContinuarPrimerUso);
            this.Controls.Add(this.btnGuardarPrimerUso);
            this.Controls.Add(this.txtPrimerCorreo);
            this.Controls.Add(this.txtPrimerTelefono);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreRepresentante);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrimerUso";
            this.Text = "frmPrimerUso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardarPrimerUso;
        private System.Windows.Forms.TextBox txtPrimerCorreo;
        private System.Windows.Forms.TextBox txtPrimerTelefono;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreRepresentante;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Button btnContinuarPrimerUso;
        private System.Windows.Forms.Label lblGenerarContrasena;
    }
}