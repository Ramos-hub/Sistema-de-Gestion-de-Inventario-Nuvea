using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmFacturaEmpleado : Form
    {
        public frmFacturaEmpleado()
        {
            InitializeComponent();
        }

        private void frmFacturaEmpleado_Load(object sender, EventArgs e)
        {
            dtpRangoHistorialEmpleado.Value = DateTime.Today;
            CargarFacturas();
        }
        private void CargarFacturas()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string sql = @"select Cliente, Producto, FechaFacturacion, Estado, Subtotal, idDetalleFactura
                   from vw_facturas_simple
                   order by FechaFacturacion desc";

            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvMostrarHistorialFacturasEmpleado.DataSource = dt;
            dgvMostrarHistorialFacturasEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvMostrarHistorialFacturasEmpleado.Columns.Contains("idDetalleFactura"))
                dgvMostrarHistorialFacturasEmpleado.Columns["idDetalleFactura"].Visible = false;

            conexion.Close();
        }
        private void LimpiarCampos()
        {
            dtpRangoHistorialEmpleado.Value = DateTime.Today; // vuelve a hoy
        }

        private void btnAplicarFiltrosEmpleado_Click(object sender, EventArgs e)
        {
            DateTime dia = dtpRangoHistorialEmpleado.Value.Date;
            DateTime diaSiguiente = dia.AddDays(1);

            string sql = @"SELECT df.idDetalleFactura AS Id, df.fecha AS Fecha,
               c.nombreCliente AS Cliente, p.nombreProduc AS Producto,
               df.cantidadProduct AS Cantidad, df.subtotal AS Subtotal
        FROM detalleFactura df
        inner join Producto p ON p.idProducto = df.idProducto
        inner join Cliente  c ON c.idCliente  = df.idCliente
        where df.estado = 1
          and df.fecha >= @d
          and df.fecha <  @dSig
        ORDER BY df.fecha DESC, df.idDetalleFactura DESC;";

            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.Add("@d", SqlDbType.Date).Value = dia;
                    cmd.Parameters.Add("@dSig", SqlDbType.Date).Value = diaSiguiente;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMostrarHistorialFacturasEmpleado.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
            LimpiarCampos();
            LimpiarCampos();
        }
    }
}
