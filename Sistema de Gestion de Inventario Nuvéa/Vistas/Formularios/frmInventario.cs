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
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmInventario: Form
    {
        public frmInventario()
        {
            InitializeComponent();
            this.Load += frmInventario_Load;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarProveedores();
            CargarCategorias();
        }
        private void CargarProductos()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consulta = @"select *from vw_Inventario";

            SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvInventario.DataSource = tabla;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conexion.Close();
        }
        private void CargarProveedores()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("select idProveedor, nombreProveedor from Proveedor", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbProveedor.DataSource = dt;
            cmbProveedor.DisplayMember = "nombreProveedor";
            cmbProveedor.ValueMember = "idProveedor";
        }
        private void CargarCategorias()
        {
                SqlConnection conexion = ConexionDB.Conectar();
                SqlDataAdapter da = new SqlDataAdapter("select idCategoria, nombreCat from Categoria", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategoriaProduc.DataSource = dt;
                cmbCategoriaProduc.DisplayMember = "nombreCat";
                cmbCategoriaProduc.ValueMember = "idCategoria";
            conexion.Close();
     
        }

        private void btnAgregar_Inventario_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedValue == null || cmbCategoriaProduc.SelectedValue == null)
            {
                MessageBox.Show("Debes seleccionar una categoría y un proveedor.");
                return;
            }
            SqlConnection conexion = ConexionDB.Conectar();
            string consulta = @"insert into Producto 
                            (nombreProduc, fechaIngreso, estado, cantidadStock, codigoBarras, precioProduc, idCategoria, idProveedor)
                            values
                            (@nombre, @fechaIngreso, @estado, @cantidadStock, @codigoBarras, @precio, @idCategoria, @idProveedor)";

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombre", txtNombreProduc.Text);
            cmd.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value);
            cmd.Parameters.AddWithValue("@estado", 1);
            cmd.Parameters.AddWithValue("@cantidadStock", Convert.ToInt32(nudCantidadStock.Value));
            cmd.Parameters.AddWithValue("@codigoBarras", Convert.ToInt64(txtCodigoBarras.Text));
            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecioProduc.Text));
            cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(cmbCategoriaProduc.SelectedValue));
            cmd.Parameters.AddWithValue("@idProveedor", Convert.ToInt32(cmbProveedor.SelectedValue));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Producto agregado correctamente.");
            CargarProductos();

            txtNombreProduc.Clear();
            txtCodigoBarras.Clear();
            txtPrecioProduc.Clear();
            nudCantidadStock.Value = 0;
            cmbCategoriaProduc.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;

            conexion.Close();
        }

        private void btnEditar_Inventario_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.NombreProduc = txtNombreProduc.Text;
            p.FechaIngreso = dtpFechaIngreso.Value;
            p.CantidadStock = Convert.ToInt32(nudCantidadStock.Value);
            p.CodigoBarras = Convert.ToInt64(txtCodigoBarras.Text);
            p.PrecioProduc = Convert.ToDecimal(txtPrecioProduc.Text);
            p.IdCategoria = Convert.ToInt32(cmbCategoriaProduc.SelectedValue);
            p.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);

            if (p.ActualizarDatosInventario())
            {
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Hubo un error", "Error");
            }
        }

        private void frmInventario_DoubleClick(object sender, EventArgs e)
        {

            if (dgvInventario.CurrentRow == null) return;

            txtNombreProduc.Text = dgvInventario.CurrentRow.Cells["Producto"].Value?.ToString();
            if (dgvInventario.CurrentRow.Cells["FechaIngreso"].Value != DBNull.Value)
                dtpFechaIngreso.Value = Convert.ToDateTime(dgvInventario.CurrentRow.Cells["FechaIngreso"].Value);
            if (dgvInventario.CurrentRow.Cells["Stock"].Value != DBNull.Value)
                nudCantidadStock.Value = Convert.ToDecimal(dgvInventario.CurrentRow.Cells["Stock"].Value);

            txtCodigoBarras.Text = dgvInventario.CurrentRow.Cells["CodigoBarras"].Value?.ToString();
            txtPrecioProduc.Text = dgvInventario.CurrentRow.Cells["Precio"].Value?.ToString();

            // Ajusta los combos por ID si tu vista/consulta trae las columnas idCategoria e idProveedor
            if (dgvInventario.CurrentRow.Cells["idCategoria"] != null)
                cmbCategoriaProduc.SelectedValue = Convert.ToInt32(dgvInventario.CurrentRow.Cells["idCategoria"].Value);
            if (dgvInventario.CurrentRow.Cells["idProveedor"] != null)
                cmbProveedor.SelectedValue = Convert.ToInt32(dgvInventario.CurrentRow.Cells["idProveedor"].Value);


        }
    }
}
    