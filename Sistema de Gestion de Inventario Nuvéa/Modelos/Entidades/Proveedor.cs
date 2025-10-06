using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Proveedor
    {
        private int idProveedor;
        private string nombreProveedor;
        private string nombreTrabajador;
        private string telefono;
        private string direccion;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string NombreTrabajador { get => nombreTrabajador; set => nombreTrabajador = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public static DataTable cargarProveedor()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select nombreProveedor, nombreTrabajador, telefono, direccion from Proveedor";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
        public static DataTable MostrarProveedores()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"select idProveedor as ID,
                         nombreProveedor as Proveedor,
                         nombreTrabajador as Trabajador,
                         telefono as Telefono,
                         direccion as Direccion
                  from Proveedor
                  order by nombreProveedor", conexion))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Insertar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (SqlCommand cmd = new SqlCommand(
                @"insert into Proveedor(nombreProveedor, nombreTrabajador, telefono, direccion)
                  values(@p, @t, @tel, @dir)", conexion))
            {
                cmd.Parameters.AddWithValue("@p", NombreProveedor);
                cmd.Parameters.AddWithValue("@t", NombreTrabajador);
                cmd.Parameters.AddWithValue("@tel", Telefono);
                cmd.Parameters.AddWithValue("@dir", Direccion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Actualizar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (SqlCommand cmd = new SqlCommand(
                @"update Proveedor
                  set nombreProveedor=@prove, nombreTrabajador=@trabajador, telefono=@tel, direccion=@dir
                  where idProveedor=@id", conexion))
            {
                cmd.Parameters.AddWithValue("@prove", NombreProveedor);
                cmd.Parameters.AddWithValue("@trabajador", NombreTrabajador);
                cmd.Parameters.AddWithValue("@tel", Telefono);
                cmd.Parameters.AddWithValue("@dir", Direccion);
                cmd.Parameters.AddWithValue("@id", IdProveedor);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarProveedor()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (SqlCommand cmd = new SqlCommand("spProveedor_Eliminar", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }
}
