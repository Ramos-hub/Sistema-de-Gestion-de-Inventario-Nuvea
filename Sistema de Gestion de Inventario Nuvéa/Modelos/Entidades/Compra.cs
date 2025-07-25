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
    public class Compra
    {
        private int idCompra;
        private int idUuario;
        private int idProducto;
        private int idFactura;
        private int idCliente;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdUuario { get => idUuario; set => idUuario = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public static DataTable chargeCompra()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idCompra, idUsuario, idProducto, idFactura, idCliente FROM Compra";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
