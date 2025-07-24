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
    public partial class frmOlivdasteContraseña : Form
    {
        public frmOlivdasteContraseña()
        {
            InitializeComponent();
        }

        private void btnBuscarCorreo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoRecu.Text;

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor ingrese su correo.");
                return;
            }
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select clave from Usuario where correo = @correo";
            SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
            cmd.Parameters.AddWithValue("@correo", correo);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string clave = reader["clave"].ToString();
                lblResultado.Text = "Tu contraseña es: " + clave;
            }
            else
            {
                lblResultado.Text = "Correo no registrado.";
            }

            reader.Close();
            conexion.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
