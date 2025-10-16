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
    public partial class frmPrincipalEmpleado : Form
    {
        public frmPrincipalEmpleado()
        {
            InitializeComponent();
        }
        #region "Metodo para activar Formularios"

        private Form activarForm = null;
        //Metodo que me permitira activar los formularios
        private void abrirFormEmpleado(Form formularioPintar)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;
            pnlCentralEmpleado.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }



        #endregion

        private void btnInicioEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormEmpleado(new frmIndexEmpleado());
        }

        private void btnFacturacionEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormEmpleado(new frmFacturaEmpleado());
        }

        private void btnInventarioEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormEmpleado(new frmInventarioEmpleado());
        }

        private void btnSoporteEm_Click(object sender, EventArgs e)
        {
            abrirFormEmpleado(new frmSoporte());
        }

        private void btnCambiarContraseñaEm_Click(object sender, EventArgs e)
        {
            abrirFormEmpleado(new frmCambiarContraseña(1));
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
                pnlCentralEmpleado.Controls.Clear();

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
