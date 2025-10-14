using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos
{
    public class ModeloPrimerUsuario
    {
        public static bool VerificacionEmpleados()
        {
            string query = "Select COUNT (*) From Usuario";
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    if (conexion != null)
                    {
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string CrearAdmin(string nombre, string telefono, string correo)
        {
            try
            {
                string autoContrasena = GenerarContrasena(nombre);
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    if (conexion != null)
                    {
                        string query = @"INSERT INTO Usuario (nombre, clave, correo, telefono, idRol)
                 VALUES (@nombre, @clave, @correo, @telefono, 1 )";
                        // Valor por defecto 1= administrador
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@clave", BCrypt.Net.BCrypt.HashPassword(autoContrasena));
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            //retorna la contraseña que se genero
                            return autoContrasena; 
                            
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Crear: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static string CrearEmpleado(string nombre, string telefono, string correo)
        {
            try
            {
                string autoContrasena = GenerarContrasena(nombre);
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    if (conexion != null)
                    {
                        string query = @"INSERT INTO Usuario (nombre, clave, correo, telefono, idRol)
                 VALUES (@nombre, @clave, @correo, @telefono, )";
                        // Valor por defecto 1= administrador
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@clave", BCrypt.Net.BCrypt.HashPassword(autoContrasena));
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            //retorna la contraseña que se genero
                            return autoContrasena;

                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Crear: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private static string GenerarContrasena(string nombreUsuario)
        {
            string nombreCorto = new string(nombreUsuario.Where(char.IsLetter).Take(4).ToArray());
            if (string.IsNullOrEmpty(nombreCorto))
            {
                // Si solo son letras usar "default"
                nombreCorto = "default"; 
            }
            return nombreCorto.ToLower() + "503";
        }
    }
}
