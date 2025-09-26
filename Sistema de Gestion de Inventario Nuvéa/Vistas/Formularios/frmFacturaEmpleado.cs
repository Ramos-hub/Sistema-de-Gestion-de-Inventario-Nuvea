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
            cmbEstadoHistorialEmpleado.Items.Add("Pagada");
            cmbEstadoHistorialEmpleado.Items.Add("Pendiente");
            cmbEstadoHistorialEmpleado.Items.Add("");

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

        private void BuscarFacturas()
        {
            SqlConnection conexion = ConexionDB.Conectar();

            string sql = @"select Cliente, Producto, FechaFacturacion, Estado, Subtotal, idDetalleFactura
                   from vw_facturas_simple
                   where 1=1";

            // cliente
            if (!string.IsNullOrWhiteSpace(txtClienteHistorialEmpleado.Text))
                sql += " and Cliente like '%" + txtClienteHistorialEmpleado.Text + "%'";

            // estado (Pagada / Pendiente)
            if (!string.IsNullOrWhiteSpace(cmbEstadoHistorialEmpleado.Text))
                sql += " and Estado = '" + cmbEstadoHistorialEmpleado.Text + "'";

            // fecha exacta del date time
            DateTime f = dtpRangoHistorialEmpleado.Value.Date;
            sql += " and FechaFacturacion = '" + f.ToString("yyyy-MM-dd") + "'";

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
            txtClienteHistorialEmpleado.Text = "";
            cmbEstadoHistorialEmpleado.SelectedIndex = -1; // quita selección
            cmbEstadoHistorialEmpleado.Text = ""; // por si acaso
            dtpRangoHistorialEmpleado.Value = DateTime.Today; // vuelve a hoy
        }

        private void btnAplicarFiltrosEmpleado_Click(object sender, EventArgs e)
        {
            BuscarFacturas();
            LimpiarCampos();
        }
    }
}
