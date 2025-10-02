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
        //Comenzamos con la conexion, conectamos nuestra base de datos con el formulario de c#
        private static string servidor = "DESKTOP-NRIRATE\\SQLEXPRESS";
        private static string basededatos = "Nuvea";

        public static SqlConnection Conectar()
            //Este metodo es el que permite la conexion con la base de datos
        {   
            string cadena = $"Data source={servidor};Initial Catalog={basededatos};Integrated Security=true";
            // Esta es la cadena de conexion que permite la conexion entre la solucion y la base de datos
            SqlConnection conexion = new SqlConnection(cadena);
            //Creamos una nueva conexion a una base de datos usando la variable cadena
            conexion.Open();
            //Abre la base de datos 
            return conexion;
            //Y esta retorna la conexion
        }
    }
}