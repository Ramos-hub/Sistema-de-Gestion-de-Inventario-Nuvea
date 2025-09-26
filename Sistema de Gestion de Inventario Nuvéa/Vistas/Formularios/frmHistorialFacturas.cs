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
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class frmHistorialFacturas: Form
    {
        public frmHistorialFacturas()
        {
            InitializeComponent();
        }
        private void frmHistorialFacturas_Load(object sender, EventArgs e)
        {
            cmbEstadoHistorial.Items.Add("Pagada");
            cmbEstadoHistorial.Items.Add("Pendiente");
            cmbEstadoHistorial.Items.Add("");

            dtpRangoHistorial.Value = DateTime.Today;

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

            dgvMostrarHistorialFacturas.DataSource = dt;
            dgvMostrarHistorialFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvMostrarHistorialFacturas.Columns.Contains("idDetalleFactura"))
                dgvMostrarHistorialFacturas.Columns["idDetalleFactura"].Visible = false;

            conexion.Close();
        }
        private void BuscarFacturas()
        {
            SqlConnection conexion = ConexionDB.Conectar();

            string sql = @"select Cliente, Producto, FechaFacturacion, Estado, Subtotal, idDetalleFactura
                   from vw_facturas_simple
                   where 1=1";

            // cliente
            if (!string.IsNullOrWhiteSpace(txtClienteHistorial.Text))
                sql += " and Cliente like '%" + txtClienteHistorial.Text + "%'";

            // estado (Pagada / Pendiente)
            if (!string.IsNullOrWhiteSpace(cmbEstadoHistorial.Text))
                sql += " and Estado = '" + cmbEstadoHistorial.Text + "'";

            // fecha exacta del date time
            DateTime f = dtpRangoHistorial.Value.Date;
            sql += " and FechaFacturacion = '" + f.ToString("yyyy-MM-dd") + "'";

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
            BuscarFacturas();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtClienteHistorial.Text = "";
            cmbEstadoHistorial.SelectedIndex = -1; // quita selección
            cmbEstadoHistorial.Text = ""; // por si acaso
            dtpRangoHistorial.Value = DateTime.Today; // vuelve a hoy
        }

    }
}
