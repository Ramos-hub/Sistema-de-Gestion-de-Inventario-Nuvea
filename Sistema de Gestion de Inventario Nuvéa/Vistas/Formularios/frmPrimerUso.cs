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

        private void btnGuardarContinuar_Click(object sender, EventArgs e)
        {
            if (txtPrimerClave.SelectedText == null || txtPrimerCorreo.SelectedText == null ||
                txtPrimerNombre.SelectedText == null || txtPrimerTelefono.SelectedText == null)
            {
                MessageBox.Show("Rellena los campos solicitados.");
                return;
            }
            using (SqlConnection conexion = ConexionDB.Conectar())
            {
                string nombre = txtPrimerNombre.Text;
                string telefono = txtPrimerTelefono.Text;
                string correo = txtPrimerCorreo.Text;

                ModeloPrimerUsuario.CrearAdmin(nombre, telefono, correo);

                MessageBox.Show("Cuenta Administrador creada con exito");

            }
        }
    }
}
