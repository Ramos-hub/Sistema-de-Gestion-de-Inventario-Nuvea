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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            cmbEstadoFacturaCrearFactura.Items.Clear();
            cmbEstadoFacturaCrearFactura.Items.Add("Pagada");
            cmbEstadoFacturaCrearFactura.Items.Add("Pendiente");
            cmbEstadoFacturaCrearFactura.SelectedIndex = 0;

            txtTotalCrearFactura.KeyPress += (s, ev) =>
            {
                if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar) && ev.KeyChar != '.' && ev.KeyChar != ',')
                    ev.Handled = true;
                if ((ev.KeyChar == '.' || ev.KeyChar == ',') &&
                    (s as TextBox).Text.IndexOfAny(new[] { '.', ',' }) > -1)
                    ev.Handled = true;
            };

            CargarProductos();
            CargarFacturas();

            dgvMostrarListaFacturas.CellDoubleClick += dgvMostrarListaFacturas_CellDoubleClick;
        }
        private void CargarProductos()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var da = new SqlDataAdapter("select idProducto, nombreProduc from Producto order by nombreProduc", conexion))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cmbProductosFactu.DataSource = dt;
                cmbProductosFactu.DisplayMember = "nombreProduc";
                cmbProductosFactu.ValueMember = "idProducto";
            }
        }

        private void CargarFacturas()
        {
            dgvMostrarListaFacturas.DataSource = detalleFactura.ListarDesdeVista();
            dgvMostrarListaFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Oculta IDs de trabajo si vienen en la vista (los dejamos por si están)
            foreach (var col in new[] { "idDetalleFactura", "idCliente", "idProducto", "idCompra" })
                if (dgvMostrarListaFacturas.Columns.Contains(col))
                    dgvMostrarListaFacturas.Columns[col].Visible = false;
        }
        private int CrearIdCliente(string nombre)
        {
            SqlConnection conexion = ConexionDB.Conectar();
                using (var cmd = new SqlCommand("select top 1 idCliente from Cliente where nombreCliente=@n", conexion))
                {
                    cmd.Parameters.AddWithValue("@n", nombre.Trim());
                    var x = cmd.ExecuteScalar();
                    if (x != null && x != DBNull.Value) return Convert.ToInt32(x);
                }
                using (var cmd = new SqlCommand(@"
            declare @dui char(10) = right('00000000' + cast(abs(checksum(newid())) % 100000000 as varchar(8)), 8) + '-' + cast(abs(checksum(newid())) % 10 as varchar(1));
            insert into Cliente(nombreCliente, dui, telefono, correo, fechaRegistro)
            values(@n, @dui, '70000000', 'sin.correo@nuvea.local', getdate());
            select cast(scope_identity() as int);", conexion))
                {
                    cmd.Parameters.AddWithValue("@n", nombre.Trim());
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
        }

        private int CrearIdCompra(int idProducto, int idCliente, decimal total)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand(@"
        insert into Compra(idUsuario, idProducto, idCliente, total)
        values(1, @p, @c, @t);
        select cast(scope_identity() as int);", conexion))
            {
                cmd.Parameters.AddWithValue("@p", idProducto);
                cmd.Parameters.AddWithValue("@c", idCliente);
                cmd.Parameters.AddWithValue("@t", total);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int CompraDeDetalle (int idDetalle)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("select idCompra from detalleFactura where idDetalleFactura=@id", conexion))
            {
                cmd.Parameters.AddWithValue("@id", idDetalle);
                var x = cmd.ExecuteScalar();
                return (x == null || x == DBNull.Value) ? 0 : Convert.ToInt32(x);
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreClienteCrearFactura.Text) ||
                    string.IsNullOrWhiteSpace(txtTotalCrearFactura.Text))
                {
                    MessageBox.Show("Cliente y Total son obligatorios.");
                    return;
                }

                int idProducto = Convert.ToInt32(cmbProductosFactu.SelectedValue);
                int idCliente = CrearIdCliente(txtNombreClienteCrearFactura.Text.Trim());
                decimal subtotal = Convert.ToDecimal(txtTotalCrearFactura.Text.Trim());
                int idCompra = CrearIdCompra(idProducto, idCliente, subtotal);

                var d = new detalleFactura
                {
                    SubTotal = subtotal,
                    CantidadProduc = 1,
                    IdCompra = idCompra,
                    IdProducto = idProducto,
                    IdCliente = idCliente,
                    Estado = (cmbEstadoFacturaCrearFactura.Text == "Pagada"),
                    FechaFactura = dtpFechaCrearFactura.Value
                };

                bool ok = d.Insertar();
                MessageBox.Show("Factura agregada.");
                CargarFacturas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void dgvMostrarListaFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMostrarListaFacturas.CurrentRow == null) return;
            var r = dgvMostrarListaFacturas.CurrentRow;

            txtTotalCrearFactura.ReadOnly = true;

            txtNombreClienteCrearFactura.Text = r.Cells["Cliente"].Value?.ToString();
            cmbProductosFactu.Text = r.Cells["Producto"].Value?.ToString(); // set por texto
            dtpFechaCrearFactura.Value = Convert.ToDateTime(r.Cells["FechaFacturacion"].Value);
            txtTotalCrearFactura.Text = r.Cells["Subtotal"].Value?.ToString();
            cmbEstadoFacturaCrearFactura.SelectedItem = (r.Cells["Estado"].Value?.ToString() == "Pagada") ? "Pagada" : "Pendiente";

            if (dgvMostrarListaFacturas.Columns.Contains("idDetalleFactura"))
                dgvMostrarListaFacturas.Tag = r.Cells["idDetalleFactura"].Value;
        }

        private void btnEditarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrarListaFacturas.Tag == null)
                {
                    MessageBox.Show("Selecciona una fila con doble clic.");
                    return;
                }

                int idDetalle = Convert.ToInt32(dgvMostrarListaFacturas.Tag);
                int idProducto = Convert.ToInt32(cmbProductosFactu.SelectedValue);
                int idCliente = CrearIdCliente(txtNombreClienteCrearFactura.Text.Trim());
                decimal subtotal = Convert.ToDecimal(txtTotalCrearFactura.Text.Trim());

                int idCompra = CompraDeDetalle (idDetalle);
                if (idCompra == 0) idCompra = CrearIdCompra(idProducto, idCliente, subtotal);

                var d = new detalleFactura
                {
                    IdDetalleFactura = idDetalle,
                    SubTotal = subtotal,
                    CantidadProduc = 1,
                    IdCompra = idCompra,
                    IdProducto = idProducto,
                    IdCliente = idCliente,
                    Estado = (cmbEstadoFacturaCrearFactura.Text == "Pagada"),
                    FechaFactura = dtpFechaCrearFactura.Value
                };

                bool ok = d.Actualizar();
                MessageBox.Show("Factura actualizada.");
                CargarFacturas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminarFacturacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrarListaFacturas.Tag == null)
                {
                    MessageBox.Show("Selecciona una fila con doble clic.");
                    return;
                }

                var d = new detalleFactura { IdDetalleFactura = Convert.ToInt32(dgvMostrarListaFacturas.Tag) };
                bool ok = d.Eliminar();
                MessageBox.Show( "Factura eliminada.");
                CargarFacturas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        private void Limpiar()
        {
            txtNombreClienteCrearFactura.Clear();
            txtTotalCrearFactura.Clear();
            cmbProductosFactu.SelectedIndex = 0;
            dtpFechaCrearFactura.Value = DateTime.Today;

            if (cmbProductosFactu.Items.Count > 0) cmbProductosFactu.SelectedIndex = 0;

            dgvMostrarListaFacturas.Tag = null;
            dgvMostrarListaFacturas.ClearSelection();
        }

        private void txtNombreClienteCrearFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void LimpiarFormulario()
        {
            txtNombreClienteCrearFactura.Clear();
            dtpFechaCrearFactura.Value = DateTime.Today;
            cmbEstadoFacturaCrearFactura.SelectedIndex = -1;
            txtTotalCrearFactura.Clear();
            cmbProductosFactu.SelectedIndex = -1;
        }

        private void btnLimpiarFactu_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
                MessageBox.Show("Limpio 😁", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
            }
        }
    }
}