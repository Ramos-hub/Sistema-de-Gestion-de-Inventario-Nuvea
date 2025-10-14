using Modelo.Conexion;
using Modelos;
using Modelos.Entidades;
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

namespace Vistas.Formularios
{
    public partial class frmCrearEmpleado: Form
    {
        public frmCrearEmpleado()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLimpiarCrearEmpleado_Click(object sender, EventArgs e)
        {
            txtCorreoRegisCrearU.Clear();
            txtNumTelCrearU.Clear();
            txtNombreUsuarioRegisCrearU.Clear();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
