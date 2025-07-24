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
        private static string servidor = "LAB02-DS-EQ07\\SQLEXPRESS";
        private static string basededatos = "Nuvea";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data source={servidor};Initial Catalog={basededatos};Integrated Security=true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}