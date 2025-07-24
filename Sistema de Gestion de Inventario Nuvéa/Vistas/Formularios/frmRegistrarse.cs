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
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class frmRegistrarse: Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuarioRegis.Text;
            string correo = txtCorreoRegis.Text;
            string clave = txtRegistrarseContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave)) 
            {
                MessageBox.Show("Por favor ingrese todos los datos");
                return;
            }
            SqlConnection conexion = ConexionDB.Conectar();
            {
              string consultaQuery = "insert into Usuario (nombre, clave, correo) values (@nombre, @clave, @correo)";
              SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
              cmd.Parameters.AddWithValue("@nombre", usuario);
              cmd.Parameters.AddWithValue("@clave", clave);
              cmd.Parameters.AddWithValue("@correo", correo);
                    
              int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
               {
                 MessageBox.Show("¡Se ha registrado Exitosamente!");
                 new frmLogin().Show();
                 this.Hide();
               }
            else {
                MessageBox.Show("No se pudo crear su cuenta");
            }
              conexion.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
