using Modelo.Conexion;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmInventarioEmpleado : Form
    {
        public frmInventarioEmpleado()
        {
            InitializeComponent();
            this.Load += frmInventarioEmpleado_Load;
        }

        private void frmInventarioEmpleado_Load(object sender, EventArgs e)
        {
            CargarProductosEmpleado();
        }

        private void CargarProductosEmpleado()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consulta = @"select *from vw_Inventario";

            SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvInventarioEmpleado.DataSource = tabla;
            dgvInventarioEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var col in new[] { "idProducto", "idCategoria", "idProveedor" })
                if (dgvInventarioEmpleado.Columns.Contains(col)) dgvInventarioEmpleado.Columns[col].Visible = false;

            conexion.Close();
        }
        private void CargarDatos()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            try
            {
                SqlCommand cmdProductos = new SqlCommand("SELECT COUNT(*) FROM Producto", conexion);
                int totalProductos = (int)cmdProductos.ExecuteScalar();
                lblResultado_Productos.Text = totalProductos.ToString();

                SqlCommand cmdVentas = new SqlCommand("SELECT SUM(total) FROM Compra", conexion);
                object ventas = cmdVentas.ExecuteScalar();
                lblResultado_Ventas.Text = ventas != DBNull.Value ? ventas.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message);
            }
        }
    }
}
