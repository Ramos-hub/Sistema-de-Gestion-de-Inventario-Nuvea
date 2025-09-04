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
        private int idCompra;
        private int idProducto;
        private int idCliente;
        private bool estado;
        private decimal subTotal;
        private DateTime fechaFactura;

        public int IdDetalleFactura { get => idDetalleFactura; set => idDetalleFactura = value; }
        public int CantidadProduc { get => cantidadProduc; set => cantidadProduc = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public bool Estado { get => estado; set => estado = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }

        public static DataTable CargarDetalleFactura()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idDetalleFactura, cantidadProduc, idCompra, idProducto,idCliente, estado, fecha from detalleFactura";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable ListarDesdeVista()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var da = new SqlDataAdapter("select * from vw_facturas_simple order by FechaFacturacion desc", conexion))
            {   
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool Insertar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("sp_detallefactura_insert", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subtotal", SubTotal);
                cmd.Parameters.AddWithValue("@cantidadProduct", CantidadProduc);
                cmd.Parameters.AddWithValue("@idCompra", IdCompra);
                cmd.Parameters.AddWithValue("@idProducto", IdProducto);
                cmd.Parameters.AddWithValue("@idCliente", IdCliente);
                cmd.Parameters.AddWithValue("@estado", Estado ? 1 : 0);
                cmd.Parameters.AddWithValue("@fecha", FechaFactura.Date);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool Actualizar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("sp_detallefactura_update", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalleFactura", IdDetalleFactura);
                cmd.Parameters.AddWithValue("@subtotal", SubTotal);
                cmd.Parameters.AddWithValue("@cantidadProduct", CantidadProduc);
                cmd.Parameters.AddWithValue("@idCompra", IdCompra);
                cmd.Parameters.AddWithValue("@idProducto", IdProducto);
                cmd.Parameters.AddWithValue("@idCliente", IdCliente);
                cmd.Parameters.AddWithValue("@estado", Estado ? 1 : 0);
                cmd.Parameters.AddWithValue("@fecha", FechaFactura.Date);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool Eliminar()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("sp_detallefactura_delete", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalleFactura", IdDetalleFactura);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
