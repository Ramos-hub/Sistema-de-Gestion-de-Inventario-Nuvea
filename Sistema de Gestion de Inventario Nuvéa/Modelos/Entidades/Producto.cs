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
    public class Producto
    {
        private int idProducto;
        private string nombreProduc;
        private DateTime fechaIngreso;
        private bool estado;
        private int cantidadStock;
        private long codigoBarras;
        private float precioProduc;
        private int idCategoria;
        private int idProveedor;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProduc { get => nombreProduc; set => nombreProduc = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public long CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public float PrecioProduc { get => precioProduc; set => precioProduc = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }

        public static DataTable chargeProducto()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idProducto, nombreProduc, fechaIngreso, estado, cantidadStock, codigoBarras, precioProduc, idCategoria, idProveedor From Producto";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
