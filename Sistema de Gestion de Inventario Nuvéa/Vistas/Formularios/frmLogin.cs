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
using Vistas.Formularios;


namespace Vistas.Formularios
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Creamos variables para los textBox
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
                SqlConnection conexion = ConexionDB.Conectar();
            //Aqui llamamos el metodo conectar 
            {
                string consultaQuery = "select * from Usuario where nombre = @usuario and clave = @clave";
                    SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("¡Bienvenido al sistema Nuvéa!");
                        new frmPrincipal().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos.");
                    }
                    reader.Close();
                    conexion.Close();
                }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse registro = new frmRegistrarse();
            registro.Show();
            this.Hide();
        }

        private void btnOlvidasteContraseña_Click(object sender, EventArgs e)
        {
            frmOlivdasteContraseña olviContra = new frmOlivdasteContraseña();
            olviContra.Show();
            this.Hide();
        }
    }
}
//frmInventario fi = new frmInventario();
//fi.StartPosition = FormStartPosition.CenterScreen;
//fi.Show();