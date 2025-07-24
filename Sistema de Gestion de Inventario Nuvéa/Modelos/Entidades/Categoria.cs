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
    public class Categoria
    {
        private int idCategoria;
        private string nombreCat;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCat { get => nombreCat; set => nombreCat = value; }

        public static DataTable chargeCategoria()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select nombreCat";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
