namespace Vistas.Formularios
{
    partial class frmBienvenida
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
            this.btnPrimerUso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimerUso
            // 
            this.btnPrimerUso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrimerUso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrimerUso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimerUso.FlatAppearance.BorderSize = 0;
            this.btnPrimerUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerUso.ForeColor = System.Drawing.Color.White;
            this.btnPrimerUso.Location = new System.Drawing.Point(303, 84);
            this.btnPrimerUso.Name = "btnPrimerUso";
            this.btnPrimerUso.Size = new System.Drawing.Size(183, 223);
            this.btnPrimerUso.TabIndex = 0;
            this.btnPrimerUso.Text = "Primer Uso";
            this.btnPrimerUso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimerUso.UseVisualStyleBackColor = false;
            this.btnPrimerUso.Click += new System.EventHandler(this.btnPrimerUso_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Vistas.Properties.Resources._1499345621_contact_85338;
            this.pictureBox1.Location = new System.Drawing.Point(332, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido al sistema Nuvea, empecemos con la configuración del sistema";
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrimerUso);
            this.Name = "frmBienvenida";
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimerUso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}