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
using Modelos.Entidades;
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
           
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text; 

            string sql = @"
        SELECT u.clave, r.nombreRol
        FROM Usuario u
        INNER JOIN Rol r ON u.idRol = r.idRol
        WHERE u.nombre = @usuario;";

            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (!VerificarValidacion(out var u, out var error))
                        {
                            MessageBox.Show(error, "Validación");
                            return;
                        }

                        if (!rd.Read())
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            return;
                        }

                        string claveBD = rd.GetString(0).Trim();
                        string rol = rd.GetString(1);

                        bool ok;
                        if (Seguridad.EsBcrypt(claveBD))
                        {
                            ok = BCrypt.Net.BCrypt.Verify(clave, claveBD);
                        }
                        else
                        {
                           
                            ok = (clave == claveBD);
                            if (ok)
                            {
                                rd.Close();
                                string nuevoHash = Seguridad.CrearHash(clave);
                                using (var upd = new SqlCommand(
                                    "UPDATE Usuario SET clave=@c WHERE nombre=@u", conexion))
                                {
                                    upd.Parameters.AddWithValue("@c", nuevoHash);
                                    upd.Parameters.AddWithValue("@u", usuario);
                                    upd.ExecuteNonQuery();
                                }
                            }
                        }

                        if (!ok)
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            return;
                        }

                        MessageBox.Show("Bienvenido al Sistema", "Bienvenido",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        if (rol == "Administrador") new frmPrincipal().Show();
                        else new frmPrincipalEmpleado().Show();

                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en login: " + ex.Message);
            }
        }
        public static string NombreEmpleadoActivo;

        private void btnOlvidasteContraseña_Click(object sender, EventArgs e)
        {
            frmOlivdasteContraseña olviContra = new frmOlivdasteContraseña();
            olviContra.Show();
            this.Hide();
        }
        private bool VerificarValidacion(out Usuario u, out string error)
        {
            u = null;
            error = "";

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            { error = "Ingrese su Usuario"; return false; }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            { error = "Ingrese su Contraseña"; return false; }

            return true;
        }

    }
}
//frmInventario fi = new frmInventario();
//fi.StartPosition = FormStartPosition.CenterScreen;
//fi.Show();