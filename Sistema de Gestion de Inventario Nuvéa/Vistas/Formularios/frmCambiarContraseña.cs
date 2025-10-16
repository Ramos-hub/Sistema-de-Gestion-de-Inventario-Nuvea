using Modelo.Conexion;
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
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmCambiarContraseña : Form
    {
        private readonly int idUsuario;

        public frmCambiarContraseña(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

        }

        private void btnConfirmarContrasena_Click(object sender, EventArgs e)
        {
            string nueva = txtNuevaContrasena.Text;
            string confirmar = txtConfirmarContrasena.Text;

            // Validaciones
            if (idUsuario <= 0)
            {
                MessageBox.Show("No hay un usuario válido para actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nueva) || string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Rellena los campos solicitados.");
                return;
            }
            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtConfirmarContrasena.Focus();
                return;
            }
            if (nueva.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                txtNuevaContrasena.Focus();
                return;
            }
            if (nueva.Contains(" "))
            {
                MessageBox.Show("La contraseña no debe contener espacios.");
                txtNuevaContrasena.Focus();
                return;
            }

            try
            {
                using (SqlConnection cn = ConexionDB.Conectar())
                {
                    if (cn == null)
                    {
                        MessageBox.Show("No se pudo abrir la conexión.");
                        return;
                    }

                    // Traer clave actual para evitar actualizar con la misma
                    string claveActual = null;
                    using (var cmdGet = new SqlCommand("SELECT clave FROM Usuario WHERE idUsuario=@id", cn))
                    {
                        cmdGet.Parameters.AddWithValue("@id", idUsuario);
                        var obj = cmdGet.ExecuteScalar();
                        if (obj == null || obj == DBNull.Value)
                        {
                            MessageBox.Show("El usuario no existe.");
                            return;
                        }
                        claveActual = obj.ToString();
                    }

                    bool esHash = !string.IsNullOrEmpty(claveActual) &&
                                  (claveActual.StartsWith("$2a$") || claveActual.StartsWith("$2b$") || claveActual.StartsWith("$2y$")) &&
                                  claveActual.Length >= 60;

                    bool coincide = esHash ? BCrypt.Net.BCrypt.Verify(nueva, claveActual)
                                           : string.Equals(nueva, claveActual);

                    if (coincide)
                    {
                        MessageBox.Show("La nueva contraseña es igual a la actual.");
                        return;
                    }

                    string hash = BCrypt.Net.BCrypt.HashPassword(nueva);

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Usuario SET clave=@clave WHERE idUsuario=@id", cn))
                    {
                        cmd.Parameters.AddWithValue("@clave", hash);
                        cmd.Parameters.AddWithValue("@id", idUsuario);

                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada con éxito.");
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
