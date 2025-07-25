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
        //Aqui se establecen los nombres de las tablas de nuestra base de datos
        //Junto con sus atributos
        private int idCategoria;
        private string nombreCat;

        //Este es el seteo
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCat { get => nombreCat; set => nombreCat = value; }

        public static DataTable chargeCategoria()
        {
            //Este metodo me perfmite mostrar los datos ingresado en las tablas de mi base de datos mediante sus atributos
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idCategoria, nombreCat From Categoria";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
