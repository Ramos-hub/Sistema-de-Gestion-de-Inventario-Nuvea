using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Configuration;
namespace Modelos.Entidades
{
     public class Usuario
    {
        public int idUsuario;
        public int idRol;
        public string nombre;
        public string clave;
        public string correo;
        public string telefono;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public static DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                    string consulta = @"SELECT idUsuario, nombre, correo, telefono, clave
                                        FROM Usuario
                                        WHERE idRol != 1"; // no mostrar al admin
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tabla);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
            return tabla;
        }
        public static void AgregarUsuario(Usuario u)
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                
                    string consulta = "INSERT INTO Usuario (idRol, nombre, clave, correo, telefono) VALUES (@idRol, @nombre, @clave, @correo, @telefono)";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@idRol", u.IdRol);
                    cmd.Parameters.AddWithValue("@nombre", u.Nombre);
                    cmd.Parameters.AddWithValue("@clave", u.Clave);
                    cmd.Parameters.AddWithValue("@correo", u.Correo);
                    cmd.Parameters.AddWithValue("@telefono", u.Telefono);
                    cmd.ExecuteNonQuery();
                
                MessageBox.Show("Usuario agregado correctamente");
                
                conexion.Close() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }

        public static void EditarUsuario(Usuario u)
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();

                    string consulta = "UPDATE Usuario SET nombre=@nombre, clave=@clave, correo=@correo, telefono=@telefono WHERE idUsuario=@id";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@nombre", u.Nombre);
                    cmd.Parameters.AddWithValue("@clave", u.Clave);
                    cmd.Parameters.AddWithValue("@correo", u.Correo);
                    cmd.Parameters.AddWithValue("@telefono", u.Telefono);
                    cmd.Parameters.AddWithValue("@id", u.IdUsuario);
                    cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario actualizado correctamente");

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }
        }

        public static void EliminarUsuario(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();

                SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario y todas sus relaciones eliminadas correctamente");

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
}
