using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "LAPTOP-QV3OA50B";
        private static string basededatos = "Nuvéa";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data source={servidor};Initial Catalog={basededatos};Integrated Security=true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}