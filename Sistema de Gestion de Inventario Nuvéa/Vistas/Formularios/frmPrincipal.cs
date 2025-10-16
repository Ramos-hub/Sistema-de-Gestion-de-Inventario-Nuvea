using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region "Metodo para activar Formularios"

        private Form activarForm = null;
        //Metodo que me permitira activar los formularios
        private void abrirForm(Form formularioPintar)
        {
            try
            {
                if (activarForm != null && !activarForm.IsDisposed)
                {
                    activarForm.Close();
                }

                pnlCentral.Controls.Clear();
                pnlCentral.Padding = new Padding(0);
                pnlCentral.Margin = new Padding(0);
                pnlCentral.AutoScroll = false;

                activarForm = formularioPintar;
                activarForm.TopLevel = false;
                activarForm.FormBorderStyle = FormBorderStyle.None;
                activarForm.Dock = DockStyle.Fill;

                pnlCentral.Controls.Add(activarForm);
                activarForm.BringToFront();
                activarForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el formulario: " + ex.Message);
            }
        }


        #endregion


        private void btnIniciInventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmIndex());
        }

        private void btnFacturacionInventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmFacturacion());
        }

        public void btn_Inventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInventario());
        }

        private void btnInventarioProveedores_Click(object sender, EventArgs e)
        {
            abrirForm(new frmProveedores());
        }

        private void btnInventarioHistorial_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHistorialFacturas());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            abrirForm(new frmGanancias());
        }

        private void btnCrearEmpleadoPrincipal_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCrearEmpleado());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            abrirForm(new frmIndex());
        }

        private void btnCambiarContraseñaP_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCambiarContraseña(1));
        }

        private void btnSoporteP_Click(object sender, EventArgs e)
        {
            abrirForm(new frmSoporte());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Seguro que deseas cerrar sesión?",
                                    "Cerrar sesión",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            try
            {
                if (activarForm != null)
                {
                    activarForm.Close();
                    activarForm.Dispose();
                    activarForm = null;
                }
                pnlCentral.Controls.Clear();

                var login = new frmLogin();
                login.StartPosition = FormStartPosition.CenterScreen;

                login.FormClosed += (_, __) => this.Close();

                this.Hide();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cerrar sesión: " + ex.Message);
            }
        }
    }
}
