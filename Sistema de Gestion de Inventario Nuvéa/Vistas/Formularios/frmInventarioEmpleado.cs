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
            this.dgvInventarioEmpleado.CellDoubleClick += dgvInventarioEmpleado_CellDoubleClick;
        }

        private void frmInventarioEmpleado_Load(object sender, EventArgs e)
        {
            CargarProductosEmpleado();
            CargarCategoriasEmpleado();
            CargarProveedoresEmpleado();
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

        private void CargarProveedoresEmpleado()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("select idProveedor, nombreProveedor from Proveedor", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbProveedorEmpleado.DataSource = dt;
            cmbProveedorEmpleado.DisplayMember = "nombreProveedor";
            cmbProveedorEmpleado.ValueMember = "idProveedor";
        }

        private void CargarCategoriasEmpleado()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("select idCategoria, nombreCat from Categoria", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCategoriaProducEmpleado.DataSource = dt;
            cmbCategoriaProducEmpleado.DisplayMember = "nombreCat";
            cmbCategoriaProducEmpleado.ValueMember = "idCategoria";
            conexion.Close();

        }

        private void btnAgregarInventarioEmpleado_Click(object sender, EventArgs e)
        {
            if (cmbProveedorEmpleado.SelectedValue == null || cmbCategoriaProducEmpleado.SelectedValue == null)
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
            cmd.Parameters.AddWithValue("@nombre", txtNombreProducEmpleado.Text);
            cmd.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngresoEmpleado.Value);
            cmd.Parameters.AddWithValue("@estado", 1);
            cmd.Parameters.AddWithValue("@cantidadStock", Convert.ToInt32(nudCantidadStockEmpleado.Value));
            cmd.Parameters.AddWithValue("@codigoBarras", Convert.ToInt64(txtCodigoBarrasEmpleado.Text));
            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecioProducEmpleado.Text));
            cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(cmbCategoriaProducEmpleado.SelectedValue));
            cmd.Parameters.AddWithValue("@idProveedor", Convert.ToInt32(cmbProveedorEmpleado.SelectedValue));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Producto agregado correctamente.");
            CargarProductosEmpleado();

            txtNombreProducEmpleado.Clear();
            txtCodigoBarrasEmpleado.Clear();
            txtPrecioProducEmpleado.Clear();
            nudCantidadStockEmpleado.Value = 0;
            cmbCategoriaProducEmpleado.SelectedIndex = -1;
            cmbProveedorEmpleado.SelectedIndex = -1;

            conexion.Close();
        }

        private void dgvInventarioEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvInventarioEmpleado.CurrentRow == null) return;
            var r = dgvInventarioEmpleado.CurrentRow;

            txtNombreProducEmpleado.Text = r.Cells["Producto"].Value?.ToString();
            dtpFechaIngresoEmpleado.Value = Convert.ToDateTime(r.Cells["FechaIngreso"].Value);
            nudCantidadStockEmpleado.Value = Convert.ToDecimal(r.Cells["Stock"].Value);
            txtCodigoBarrasEmpleado.Text = r.Cells["codigoBarras"].Value?.ToString();
            txtPrecioProducEmpleado.Text = r.Cells["Precio"].Value?.ToString();

            if (r.Cells["idCategoria"]?.Value != DBNull.Value)
                cmbCategoriaProducEmpleado.SelectedValue = Convert.ToInt32(r.Cells["idCategoria"].Value);
            if (r.Cells["idProveedor"]?.Value != DBNull.Value)
                cmbProveedorEmpleado.SelectedValue = Convert.ToInt32(r.Cells["idProveedor"].Value);
        }
        private bool TryLeerProductoDesdeUIEmpleado(out Producto p, out string error)
        {
            p = null;
            error = "";

            if (dgvInventarioEmpleado.CurrentRow == null)
            { error = "Selecciona un producto de la lista."; return false; }

            if (string.IsNullOrWhiteSpace(txtNombreProducEmpleado.Text))
            { error = "El nombre del producto es obligatorio."; return false; }

            if (!long.TryParse(txtCodigoBarrasEmpleado.Text.Trim(), out long cod))
            { error = "Código de barras inválido (solo números)."; return false; }

            if (!decimal.TryParse(txtPrecioProducEmpleado.Text.Trim(), out decimal precio))
            { error = "Precio inválido. Usa 12,50 o 12.50"; return false; }

            if (cmbCategoriaProducEmpleado.SelectedValue == null || cmbProveedorEmpleado.SelectedValue == null)
            { error = "Selecciona categoría y proveedor."; return false; }

            p = new Producto
            {
                IdProducto = Convert.ToInt32(dgvInventarioEmpleado.CurrentRow.Cells["idProducto"].Value),
                NombreProduc = txtNombreProducEmpleado.Text.Trim(),
                FechaIngreso = dtpFechaIngresoEmpleado.Value,
                Estado = true,
                CantidadStock = (int)nudCantidadStockEmpleado.Value,
                CodigoBarras = cod,
                PrecioProduc = precio,
                IdCategoria = Convert.ToInt32(cmbCategoriaProducEmpleado.SelectedValue),
                IdProveedor = Convert.ToInt32(cmbProveedorEmpleado.SelectedValue)
            };

            return true;
        }

        private void btnEliminarInventarioEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvInventarioEmpleado.CurrentRow == null)
            { MessageBox.Show("Selecciona un producto."); return; }

            object val = dgvInventarioEmpleado.CurrentRow.Cells["idProducto"].Value;
            if (val == null || !int.TryParse(val.ToString(), out int id))
            { MessageBox.Show("No se pudo obtener el idProducto."); return; }

            var r = MessageBox.Show("¿Eliminar este producto?", "Confirmar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            try
            {
                using (var cn = ConexionDB.Conectar())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("DELETE FROM Producto WHERE idProducto=@id", cn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            int filas = cmd.ExecuteNonQuery();
                            MessageBox.Show(filas == 1 ? "Producto eliminado." : "No se pudo eliminar.");
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 547) // FK: tiene ventas/compras
                    {
                        // Fallback: baja lógica
                        using (var up = new SqlCommand("UPDATE Producto SET estado=0 WHERE idProducto=@id", cn))
                        {
                            up.Parameters.AddWithValue("@id", id);
                            int filas = up.ExecuteNonQuery();
                            MessageBox.Show(filas == 1 ? "Producto desactivado (estado=0)." : "No se pudo desactivar.");
                        }
                    }
                }
                CargarProductosEmpleado(); // refresca el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombreProducEmpleado.Clear();
            dtpFechaIngresoEmpleado.Value = DateTime.Today;
            nudCantidadStockEmpleado.Value = 0;
            txtCodigoBarrasEmpleado.Clear();
            txtPrecioProducEmpleado.Clear();

            if (cmbCategoriaProducEmpleado.Items.Count > 0) cmbCategoriaProducEmpleado.SelectedIndex = 0;
            if (cmbProveedorEmpleado.Items.Count > 0) cmbProveedorEmpleado.SelectedIndex = 0;

            txtNombreProducEmpleado.Focus();
        }

        private void btnEditarInventarioEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerProductoDesdeUIEmpleado(out var p, out var error))
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
                CargarProductosEmpleado();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}
