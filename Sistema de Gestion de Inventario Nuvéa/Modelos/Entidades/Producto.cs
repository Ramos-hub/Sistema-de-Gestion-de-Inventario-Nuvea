using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private decimal precioProduc;
        private int idCategoria;
        private int idProveedor;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProduc { get => nombreProduc; set => nombreProduc = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public long CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public decimal PrecioProduc { get => precioProduc; set => precioProduc = value; }
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
        public bool ActualizarDatosInventario()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("sp_producto_actualizar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idProducto", IdProducto);
                    cmd.Parameters.AddWithValue("@nombreProduc", NombreProduc);
                    cmd.Parameters.AddWithValue("@fechaIngreso", FechaIngreso);
                    cmd.Parameters.AddWithValue("@estado", Estado ? 1 : 0);
                    cmd.Parameters.AddWithValue("@cantidadStock", CantidadStock);
                    cmd.Parameters.AddWithValue("@codigoBarras", CodigoBarras);
                    cmd.Parameters.AddWithValue("@precioProduc", PrecioProduc);
                    cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
                    cmd.Parameters.AddWithValue("@idProveedor", IdProveedor);

                var filas = Convert.ToInt32(cmd.ExecuteScalar());
                return filas > 0;
            }
        }
        public bool Eliminar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
                using (var cmd = new SqlCommand("sp_producto_eliminar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idProducto", IdProducto);

                    // leemos @@ROWCOUNT que devuelve el SP
                    var res = cmd.ExecuteScalar();
                    int filas = (res == null || res == DBNull.Value) ? 0 : Convert.ToInt32(res);
                    return filas > 0;
                }
        }
    }
}
