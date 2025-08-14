using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;

namespace Modelos.Entidades
{
    public class Rol
    {
        private int idRol;
        private string nombreRol;

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }

        public static DataTable validarRol()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idRol, nombreRol from Rol";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
