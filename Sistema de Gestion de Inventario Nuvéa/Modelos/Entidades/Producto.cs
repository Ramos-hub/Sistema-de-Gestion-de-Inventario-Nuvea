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
            using (SqlConnection cn = ConexionDB.Conectar())
            {
                string sql = @"
                UPDATE Producto SET 
                    nombreProduc  = @Producto,
                    fechaIngreso  = @fechaIngreso,
                    cantidadStock = @stock,
                    codigoBarras  = @codigoBarras,
                    precioProduc  = @precio,
                    idCategoria   = @idCat,
                    idProveedor   = @idProv
                WHERE idProducto = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Producto", NombreProduc);
                    cmd.Parameters.AddWithValue("@fechaIngreso", FechaIngreso);
                    cmd.Parameters.AddWithValue("@stock", CantidadStock);
                    cmd.Parameters.AddWithValue("@codigoBarras", CodigoBarras);
                    cmd.Parameters.AddWithValue("@precio", PrecioProduc);
                    cmd.Parameters.AddWithValue("@idCat", IdCategoria);
                    cmd.Parameters.AddWithValue("@idProv", IdProveedor);
                    cmd.Parameters.AddWithValue("@id", IdProducto);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
