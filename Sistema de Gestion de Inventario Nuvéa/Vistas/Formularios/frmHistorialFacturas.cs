using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class frmHistorialFacturas : Form
    {
        public frmHistorialFacturas()
        {
            InitializeComponent();
        }

        private void frmHistorialFacturas_Load(object sender, EventArgs e)
        {
            dtpRangoHistorialDesde.Value = DateTime.Today;
            dtpRangoHistorialHasta.Value = DateTime.Today;  // Inicializa el nuevo DateTimePicker para "hasta"

            CargarFacturas();  // Carga inicial de facturas
        }

        private void CargarFacturas()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string sql = @"SELECT Cliente, Producto, FechaFacturacion, Estado, Subtotal, idDetalleFactura
                           FROM vw_facturas_simple
                           ORDER BY FechaFacturacion DESC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvMostrarHistorialFacturas.DataSource = dt;
            dgvMostrarHistorialFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvMostrarHistorialFacturas.Columns.Contains("idDetalleFactura"))
                dgvMostrarHistorialFacturas.Columns["idDetalleFactura"].Visible = false;

            conexion.Close();
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpRangoHistorialDesde.Value.Date;
            DateTime fechaHasta = dtpRangoHistorialHasta.Value.Date;

            // Restricción: Verificar que fechaDesde no sea mayor que fechaHasta
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'desde' no puede ser mayor que la fecha 'hasta'. Por favor, corrige las fechas.");
                return;  // Salir del método si no se cumple la restricción
            }

            string sql = @"SELECT df.idDetalleFactura AS Id, df.fecha AS Fecha,
               c.nombreCliente AS Cliente, p.nombreProduc AS Producto,
               df.cantidadProduct AS Cantidad, df.subtotal AS Subtotal
        FROM detalleFactura df
        INNER JOIN Producto p ON p.idProducto = df.idProducto
        INNER JOIN Cliente c ON c.idCliente = df.idCliente
        WHERE df.estado = 1
          AND df.fecha >= @desde
          AND df.fecha <= @hasta
        ORDER BY df.fecha DESC, df.idDetalleFactura DESC;";

            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.Add("@desde", SqlDbType.Date).Value = fechaDesde;
                    cmd.Parameters.Add("@hasta", SqlDbType.Date).Value = fechaHasta;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMostrarHistorialFacturas.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
            LimpiarCampos();  // Limpia los campos después de aplicar filtros
        }

        private void LimpiarCampos()
        {
            dtpRangoHistorialDesde.Value = DateTime.Today;  // Vuelve a hoy
            dtpRangoHistorialHasta.Value = DateTime.Today;  // Limpia el nuevo DateTimePicker también
        }

        private void btnRecargarFacturas_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }
    }
}
