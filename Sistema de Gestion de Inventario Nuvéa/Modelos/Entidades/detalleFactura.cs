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
    public class detalleFactura
    {
        private int idDetalleFactura;
        private int cantidadProduc;
        private string subTotal;

        public int IdDetalleFactura { get => idDetalleFactura; set => idDetalleFactura = value; }
        public int CantidadProduc { get => cantidadProduc; set => cantidadProduc = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }

        public static DataTable chargeDetaleFactura()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idDetalleFactura, cantidadProduc, subTotal";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
