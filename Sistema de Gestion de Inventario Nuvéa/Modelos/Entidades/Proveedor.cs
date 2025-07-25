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

        public static DataTable chargeProveedor()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select nombreProveedor, nombreTrabajador, telefono, direccion from Proveedor";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
