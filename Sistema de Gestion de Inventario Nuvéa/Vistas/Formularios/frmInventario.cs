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
            this.dgvInventario.CellDoubleClick += dgvInventario_CellDoubleClick;

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
            foreach (var col in new[] { "idProducto", "idCategoria", "idProveedor" })
                if (dgvInventario.Columns.Contains(col)) dgvInventario.Columns[col].Visible = false;

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

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvInventario.CurrentRow == null) return;
            var r = dgvInventario.CurrentRow;

            txtNombreProduc.Text = r.Cells["Producto"].Value?.ToString();
            dtpFechaIngreso.Value = Convert.ToDateTime(r.Cells["FechaIngreso"].Value);
            nudCantidadStock.Value = Convert.ToDecimal(r.Cells["Stock"].Value);
            txtCodigoBarras.Text = r.Cells["codigoBarras"].Value?.ToString();
            txtPrecioProduc.Text = r.Cells["Precio"].Value?.ToString();

            if (r.Cells["idCategoria"]?.Value != DBNull.Value)
                cmbCategoriaProduc.SelectedValue = Convert.ToInt32(r.Cells["idCategoria"].Value);
            if (r.Cells["idProveedor"]?.Value != DBNull.Value)
                cmbProveedor.SelectedValue = Convert.ToInt32(r.Cells["idProveedor"].Value);
        }
        private bool TryLeerProductoDesdeUI(out Producto p, out string error)
        {
            p = null;
            error = "";

            if (dgvInventario.CurrentRow == null)
            { error = "Selecciona un producto de la lista."; return false; }

            if (string.IsNullOrWhiteSpace(txtNombreProduc.Text))
            { error = "El nombre del producto es obligatorio."; return false; }

            if (!long.TryParse(txtCodigoBarras.Text.Trim(), out long cod))
            { error = "Código de barras inválido (solo números)."; return false; }

            if (!decimal.TryParse(txtPrecioProduc.Text.Trim(), out decimal precio))
            { error = "Precio inválido. Usa 12,50 o 12.50"; return false; }

            if (cmbCategoriaProduc.SelectedValue == null || cmbProveedor.SelectedValue == null)
            { error = "Selecciona categoría y proveedor."; return false; }

            p = new Producto
            {
                IdProducto = Convert.ToInt32(dgvInventario.CurrentRow.Cells["idProducto"].Value),
                NombreProduc = txtNombreProduc.Text.Trim(),
                FechaIngreso = dtpFechaIngreso.Value,
                Estado = true, // o tu lógica
                CantidadStock = (int)nudCantidadStock.Value,
                CodigoBarras = cod,
                PrecioProduc = precio,
                IdCategoria = Convert.ToInt32(cmbCategoriaProduc.SelectedValue),
                IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue)
            };

            return true;
        }

        private void btnEditar_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerProductoDesdeUI(out var p, out var error))
                {
                    MessageBox.Show(error, "Validación");
                    return;
                }

                if (p.ActualizarDatosInventario())
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                }
                else 
                {
                MessageBox.Show("No se pudo actualizar.");
                }
                CargarProductos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un producto de la lista.");
                    return;
                }

                int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["idProducto"].Value);
                Producto p = new Producto { IdProducto = id };

                if (p.Eliminar())
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnAgregar_Inventario_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerProductoDesdeUI(out var p, out var error))
                {
                    MessageBox.Show(error, "Validación");
                    return;
                }

                if (p.Insertar())
                {
                    MessageBox.Show("Producto agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar.");
                }

                CargarProductos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombreProduc.Clear();
            dtpFechaIngreso.Value = DateTime.Today;
            nudCantidadStock.Value = 0;
            txtCodigoBarras.Clear();
            txtPrecioProduc.Clear();

            if (cmbCategoriaProduc.Items.Count > 0) cmbCategoriaProduc.SelectedIndex = 0;
            if (cmbProveedor.Items.Count > 0) cmbProveedor.SelectedIndex = 0;

            txtNombreProduc.Focus();
        }

        private void btnLimpiarInven_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
                MessageBox.Show("Formulario limpio, listo para ingresar un nuevo producto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
            }
        }
    }
}

    