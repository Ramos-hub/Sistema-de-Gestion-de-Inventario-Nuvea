using Modelo.Conexion;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas.Formularios
{
    public partial class frmPrimerUso : Form
    {
        public frmPrimerUso()
        {
            InitializeComponent();
        }

        private void btnGuardarPrimerUso_Click(object sender, EventArgs e)
        {
            string nombre = txtPrimerNombre.Text;
            string telefono = txtPrimerTelefono.Text;
            string correo = txtPrimerCorreo.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Rellena los campos solicitados.");
                return;
            }

            string contrasenaGenerada = ModeloPrimerUsuario.CrearAdmin(nombre, telefono, correo);

            if (contrasenaGenerada != null)
            {
                lblGenerarContrasena.Text = $"Contraseña generada: {contrasenaGenerada}";
                // No mostramos mensaje aquí, solo el label
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta. Intenta de nuevo.");
            }

        }

        private void btnContinuarPrimerUso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblGenerarContrasena.Text))
            {
                MessageBox.Show("Cuenta Administrador creada con éxito.");
                frmLogin log = new frmLogin();
                log.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Primero guarda la cuenta para generar la contraseña.");
            }
        }
    }
}
