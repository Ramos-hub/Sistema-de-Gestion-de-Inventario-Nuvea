namespace Vistas.Formularios
{
    partial class frmProveedores
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
            this.lblProveedores = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreTrabajador = new System.Windows.Forms.TextBox();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(23, 27);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(144, 28);
            this.lblProveedores.TabIndex = 11;
            this.lblProveedores.Text = "Proveedores";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(11, 253);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(98, 32);
            this.btnAgregarProveedor.TabIndex = 13;
            this.btnAgregarProveedor.Text = "+ Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMostrarProveedores);
            this.panel1.Location = new System.Drawing.Point(262, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 334);
            this.panel1.TabIndex = 15;
            // 
            // dgvMostrarProveedores
            // 
            this.dgvMostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(3, 9);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.ReadOnly = true;
            this.dgvMostrarProveedores.RowHeadersWidth = 51;
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(520, 322);
            this.dgvMostrarProveedores.TabIndex = 0;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(12, 20);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(156, 19);
            this.lblProveedor.TabIndex = 12;
            this.lblProveedor.Text = "Nombre del Proveedor :";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(11, 42);
            this.txtNombreProveedor.MaxLength = 50;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(154, 20);
            this.txtNombreProveedor.TabIndex = 14;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.btnLimpiarProveedor);
            this.panel2.Controls.Add(this.btnAgregarProveedor);
            this.panel2.Controls.Add(this.txtDireccionProveedor);
            this.panel2.Controls.Add(this.btnEliminarProveedor);
            this.panel2.Controls.Add(this.txtTelefonoProveedor);
            this.panel2.Controls.Add(this.txtNombreTrabajador);
            this.panel2.Controls.Add(this.btnEditarProveedor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNombreProveedor);
            this.panel2.Controls.Add(this.lblProveedor);
            this.panel2.Location = new System.Drawing.Point(12, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 337);
            this.panel2.TabIndex = 16;
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(11, 299);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(98, 32);
            this.btnLimpiarProveedor.TabIndex = 18;
            this.btnLimpiarProveedor.Text = "Limpiar";
            this.btnLimpiarProveedor.UseVisualStyleBackColor = false;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(11, 205);
            this.txtDireccionProveedor.MaxLength = 100;
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(157, 20);
            this.txtDireccionProveedor.TabIndex = 20;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(118, 299);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(98, 32);
            this.btnEliminarProveedor.TabIndex = 19;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(11, 155);
            this.txtTelefonoProveedor.MaxLength = 8;
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(160, 20);
            this.txtTelefonoProveedor.TabIndex = 19;
            this.txtTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoProveedor_KeyPress);
            // 
            // txtNombreTrabajador
            // 
            this.txtNombreTrabajador.Location = new System.Drawing.Point(11, 98);
            this.txtNombreTrabajador.MaxLength = 50;
            this.txtNombreTrabajador.Name = "txtNombreTrabajador";
            this.txtNombreTrabajador.Size = new System.Drawing.Size(157, 20);
            this.txtNombreTrabajador.TabIndex = 18;
            this.txtNombreTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTrabajador_KeyPress);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(192)))), ((int)(((byte)(174)))));
            this.btnEditarProveedor.Location = new System.Drawing.Point(118, 253);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(98, 32);
            this.btnEditarProveedor.TabIndex = 17;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Direccion del Proveedor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefono del Proveedor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del Trabajador :";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProveedores);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtNombreTrabajador;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
    }
}