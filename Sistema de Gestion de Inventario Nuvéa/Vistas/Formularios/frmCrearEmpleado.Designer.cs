namespace Vistas.Formularios
{
    partial class frmCrearEmpleado
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
            this.dgvVerEmpleadosCreados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClaveCrearEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnLimpiarCrearEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.txtNumTelCrearU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContrasenaAuto = new System.Windows.Forms.Label();
            this.btnAñadirCuenta = new System.Windows.Forms.Button();
            this.txtCorreoRegisCrearU = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioRegisCrearU = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEmpleadosCreados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerEmpleadosCreados
            // 
            this.dgvVerEmpleadosCreados.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerEmpleadosCreados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEmpleadosCreados.Location = new System.Drawing.Point(12, 26);
            this.dgvVerEmpleadosCreados.Name = "dgvVerEmpleadosCreados";
            this.dgvVerEmpleadosCreados.ReadOnly = true;
            this.dgvVerEmpleadosCreados.RowHeadersWidth = 62;
            this.dgvVerEmpleadosCreados.Size = new System.Drawing.Size(458, 412);
            this.dgvVerEmpleadosCreados.TabIndex = 23;
            this.dgvVerEmpleadosCreados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerEmpleadosCreados_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(203)))));
            this.groupBox1.Controls.Add(this.txtClaveCrearEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditarEmpleado);
            this.groupBox1.Controls.Add(this.btnLimpiarCrearEmpleado);
            this.groupBox1.Controls.Add(this.btnEliminarEmpleado);
            this.groupBox1.Controls.Add(this.txtNumTelCrearU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblContrasenaAuto);
            this.groupBox1.Controls.Add(this.btnAñadirCuenta);
            this.groupBox1.Controls.Add(this.txtCorreoRegisCrearU);
            this.groupBox1.Controls.Add(this.txtNombreUsuarioRegisCrearU);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Location = new System.Drawing.Point(476, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 415);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // txtClaveCrearEmpleado
            // 
            this.txtClaveCrearEmpleado.Location = new System.Drawing.Point(9, 233);
            this.txtClaveCrearEmpleado.MaxLength = 50;
            this.txtClaveCrearEmpleado.Name = "txtClaveCrearEmpleado";
            this.txtClaveCrearEmpleado.ShortcutsEnabled = false;
            this.txtClaveCrearEmpleado.Size = new System.Drawing.Size(284, 20);
            this.txtClaveCrearEmpleado.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Clave:";
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpleado.Location = new System.Drawing.Point(171, 272);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(97, 50);
            this.btnEditarEmpleado.TabIndex = 37;
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnLimpiarCrearEmpleado
            // 
            this.btnLimpiarCrearEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnLimpiarCrearEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCrearEmpleado.Location = new System.Drawing.Point(171, 328);
            this.btnLimpiarCrearEmpleado.Name = "btnLimpiarCrearEmpleado";
            this.btnLimpiarCrearEmpleado.Size = new System.Drawing.Size(97, 50);
            this.btnLimpiarCrearEmpleado.TabIndex = 36;
            this.btnLimpiarCrearEmpleado.Text = "Limpiar";
            this.btnLimpiarCrearEmpleado.UseVisualStyleBackColor = false;
            this.btnLimpiarCrearEmpleado.Click += new System.EventHandler(this.btnLimpiarCrearEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(42, 328);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(97, 50);
            this.btnEliminarEmpleado.TabIndex = 35;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // txtNumTelCrearU
            // 
            this.txtNumTelCrearU.Location = new System.Drawing.Point(9, 175);
            this.txtNumTelCrearU.MaxLength = 8;
            this.txtNumTelCrearU.Name = "txtNumTelCrearU";
            this.txtNumTelCrearU.ShortcutsEnabled = false;
            this.txtNumTelCrearU.Size = new System.Drawing.Size(284, 20);
            this.txtNumTelCrearU.TabIndex = 34;
            this.txtNumTelCrearU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTelCrearU_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Num.Teléfono";
            // 
            // lblContrasenaAuto
            // 
            this.lblContrasenaAuto.AutoSize = true;
            this.lblContrasenaAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaAuto.Location = new System.Drawing.Point(47, 214);
            this.lblContrasenaAuto.Name = "lblContrasenaAuto";
            this.lblContrasenaAuto.Size = new System.Drawing.Size(0, 20);
            this.lblContrasenaAuto.TabIndex = 32;
            // 
            // btnAñadirCuenta
            // 
            this.btnAñadirCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnAñadirCuenta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCuenta.Location = new System.Drawing.Point(42, 272);
            this.btnAñadirCuenta.Name = "btnAñadirCuenta";
            this.btnAñadirCuenta.Size = new System.Drawing.Size(97, 50);
            this.btnAñadirCuenta.TabIndex = 31;
            this.btnAñadirCuenta.Text = "Añadir Empleado";
            this.btnAñadirCuenta.UseVisualStyleBackColor = false;
            this.btnAñadirCuenta.Click += new System.EventHandler(this.btnAñadirCuenta_Click);
            // 
            // txtCorreoRegisCrearU
            // 
            this.txtCorreoRegisCrearU.Location = new System.Drawing.Point(9, 118);
            this.txtCorreoRegisCrearU.MaxLength = 100;
            this.txtCorreoRegisCrearU.Name = "txtCorreoRegisCrearU";
            this.txtCorreoRegisCrearU.ShortcutsEnabled = false;
            this.txtCorreoRegisCrearU.Size = new System.Drawing.Size(284, 20);
            this.txtCorreoRegisCrearU.TabIndex = 30;
            // 
            // txtNombreUsuarioRegisCrearU
            // 
            this.txtNombreUsuarioRegisCrearU.Location = new System.Drawing.Point(9, 59);
            this.txtNombreUsuarioRegisCrearU.MaxLength = 50;
            this.txtNombreUsuarioRegisCrearU.Name = "txtNombreUsuarioRegisCrearU";
            this.txtNombreUsuarioRegisCrearU.ShortcutsEnabled = false;
            this.txtNombreUsuarioRegisCrearU.Size = new System.Drawing.Size(284, 20);
            this.txtNombreUsuarioRegisCrearU.TabIndex = 29;
            this.txtNombreUsuarioRegisCrearU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuarioRegisCrearU_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(6, 99);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(104, 16);
            this.lblCorreo.TabIndex = 28;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 40);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(109, 16);
            this.lblNombreUsuario.TabIndex = 27;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // frmCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVerEmpleadosCreados);
            this.Name = "frmCrearEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearEmpleado";
            this.Load += new System.EventHandler(this.frmCrearEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEmpleadosCreados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVerEmpleadosCreados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnLimpiarCrearEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.TextBox txtNumTelCrearU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContrasenaAuto;
        private System.Windows.Forms.Button btnAñadirCuenta;
        private System.Windows.Forms.TextBox txtCorreoRegisCrearU;
        private System.Windows.Forms.TextBox txtNombreUsuarioRegisCrearU;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtClaveCrearEmpleado;
        private System.Windows.Forms.Label label3;
    }
}