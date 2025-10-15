namespace Vistas.Formularios
{
    partial class frmSoporte
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
            this.gbSoporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkVerUsuario = new System.Windows.Forms.LinkLabel();
            this.lnkDescargarUsuario = new System.Windows.Forms.LinkLabel();
            this.lnkVerTecnico = new System.Windows.Forms.LinkLabel();
            this.lnkDescargarTecnico = new System.Windows.Forms.LinkLabel();
            this.gbSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSoporte
            // 
            this.gbSoporte.Controls.Add(this.lnkDescargarTecnico);
            this.gbSoporte.Controls.Add(this.lnkVerTecnico);
            this.gbSoporte.Controls.Add(this.lnkDescargarUsuario);
            this.gbSoporte.Controls.Add(this.lnkVerUsuario);
            this.gbSoporte.Controls.Add(this.label2);
            this.gbSoporte.Controls.Add(this.label1);
            this.gbSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSoporte.Location = new System.Drawing.Point(29, 27);
            this.gbSoporte.Name = "gbSoporte";
            this.gbSoporte.Size = new System.Drawing.Size(729, 387);
            this.gbSoporte.TabIndex = 0;
            this.gbSoporte.TabStop = false;
            this.gbSoporte.Text = "Soporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Si tienes algun problema al usar el Sistema utiliza el Manual de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para dar mantenimiento y realizar actualizaciones al sistema utiliza el Manual Té" +
    "cnico";
            // 
            // lnkVerUsuario
            // 
            this.lnkVerUsuario.AutoSize = true;
            this.lnkVerUsuario.Location = new System.Drawing.Point(68, 83);
            this.lnkVerUsuario.Name = "lnkVerUsuario";
            this.lnkVerUsuario.Size = new System.Drawing.Size(165, 16);
            this.lnkVerUsuario.TabIndex = 2;
            this.lnkVerUsuario.TabStop = true;
            this.lnkVerUsuario.Text = "Ver Manual de Usuario";
            this.lnkVerUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerUsuario_LinkClicked);
            // 
            // lnkDescargarUsuario
            // 
            this.lnkDescargarUsuario.AutoSize = true;
            this.lnkDescargarUsuario.Location = new System.Drawing.Point(68, 131);
            this.lnkDescargarUsuario.Name = "lnkDescargarUsuario";
            this.lnkDescargarUsuario.Size = new System.Drawing.Size(214, 16);
            this.lnkDescargarUsuario.TabIndex = 3;
            this.lnkDescargarUsuario.TabStop = true;
            this.lnkDescargarUsuario.Text = "Descargar Manual de Usuario";
            this.lnkDescargarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDescargarUsuario_LinkClicked);
            // 
            // lnkVerTecnico
            // 
            this.lnkVerTecnico.AutoSize = true;
            this.lnkVerTecnico.Location = new System.Drawing.Point(68, 245);
            this.lnkVerTecnico.Name = "lnkVerTecnico";
            this.lnkVerTecnico.Size = new System.Drawing.Size(145, 16);
            this.lnkVerTecnico.TabIndex = 4;
            this.lnkVerTecnico.TabStop = true;
            this.lnkVerTecnico.Text = "Ver Manual Técnico";
            this.lnkVerTecnico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerTecnico_LinkClicked);
            // 
            // lnkDescargarTecnico
            // 
            this.lnkDescargarTecnico.AutoSize = true;
            this.lnkDescargarTecnico.Location = new System.Drawing.Point(68, 291);
            this.lnkDescargarTecnico.Name = "lnkDescargarTecnico";
            this.lnkDescargarTecnico.Size = new System.Drawing.Size(194, 16);
            this.lnkDescargarTecnico.TabIndex = 5;
            this.lnkDescargarTecnico.TabStop = true;
            this.lnkDescargarTecnico.Text = "Descargar Manual Técnico";
            this.lnkDescargarTecnico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDescargarTecnico_LinkClicked);
            // 
            // frmSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSoporte);
            this.Name = "frmSoporte";
            this.Text = "frmSoporte";
            this.gbSoporte.ResumeLayout(false);
            this.gbSoporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSoporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkDescargarTecnico;
        private System.Windows.Forms.LinkLabel lnkVerTecnico;
        private System.Windows.Forms.LinkLabel lnkDescargarUsuario;
        private System.Windows.Forms.LinkLabel lnkVerUsuario;
    }
}