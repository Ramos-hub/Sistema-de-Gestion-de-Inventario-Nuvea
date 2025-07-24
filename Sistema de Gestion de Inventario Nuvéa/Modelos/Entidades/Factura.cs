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
    public class Factura
    {
        private int idFactura;
        private int idDetalleFactura;
        private int idUsuario;

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdDetalleFactura { get => idDetalleFactura; set => idDetalleFactura = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public static DataTable chargeFactura()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idFactura, idDetalleFactura, idUsuario";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
