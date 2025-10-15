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
            this.Resize += frmFacturacion_Resize;
            this.Load += frmFacturacion_Load;
        }

        // =============================
        // EVENTOS DE CARGA Y RESPONSIVE
        // =============================

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                // Combo de estados
                cmbEstadoFacturaCrearFactura.Items.Clear();
                cmbEstadoFacturaCrearFactura.Items.Add("Pagada");
                cmbEstadoFacturaCrearFactura.Items.Add("Pendiente");
                cmbEstadoFacturaCrearFactura.SelectedIndex = 0;

                // Validación del total: números y un solo separador
                txtTotalCrearFactura.KeyPress += (s, ev) =>
                {
                    if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar) && ev.KeyChar != '.' && ev.KeyChar != ',')
                        ev.Handled = true;
                    if ((ev.KeyChar == '.' || ev.KeyChar == ',') &&
                        (s as TextBox).Text.IndexOfAny(new[] { '.', ',' }) > -1)
                        ev.Handled = true;
                };

                // ANCLAS para funcionamiento responsive
                gbListaFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

                // 🔥 importante: también anclar a Left para que “respire” con el form
                gbCrearFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

                dgvMostrarListaFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

                btnLimpiarFactu.Anchor = AnchorStyles.Bottom;
                btnEliminarFacturacion.Anchor = AnchorStyles.Bottom;
                btnEditarFactura.Anchor = AnchorStyles.Bottom;
                btnGuardarFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                txtNombreClienteCrearFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                dtpFechaCrearFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                cmbProductosFactu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                cmbEstadoFacturaCrearFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                txtTotalCrearFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                CargarProductos();
                CargarFacturas();

                dgvMostrarListaFacturas.CellDoubleClick += dgvMostrarListaFacturas_CellDoubleClick;

                AjustarLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar Facturación: " + ex.Message);
            }
        }

        private void frmFacturacion_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        // =============================
        // MÉTODO DE DISEÑO RESPONSIVE
        // =============================

        private void AjustarLayout()
        {
            try
            {
                int m = 16;                      // margen general
                int W = this.ClientSize.Width;
                int H = this.ClientSize.Height;

                if (H < 520) H = 520;            // alto mínimo cómodo

                // 🔥 Ancho del panel derecho proporcional (35%) con límites
                int rightPanelWidth = Math.Max(280, Math.Min(520, (int)(W * 0.35)));

                // ===== COLUMNA IZQUIERDA: Lista de facturas =====
                gbListaFactura.Left = m;
                gbListaFactura.Top = 60;       // deja espacio al título "Facturación"
                gbListaFactura.Width = W - rightPanelWidth - (m * 3);
                if (gbListaFactura.Width < 380) gbListaFactura.Width = 380;

                int altoZonaBotones = 60 + 60;   // alto botones + aire
                gbListaFactura.Height = H - gbListaFactura.Top - altoZonaBotones;

                // DGV llena el groupbox izquierdo
                dgvMostrarListaFacturas.Left = 10;
                dgvMostrarListaFacturas.Top = 25;
                dgvMostrarListaFacturas.Width = gbListaFactura.ClientSize.Width - 20;
                dgvMostrarListaFacturas.Height = gbListaFactura.ClientSize.Height - 35;

                // ===== COLUMNA DERECHA: Crear Factura (responsive) =====
                gbCrearFactura.Width = rightPanelWidth;
                gbCrearFactura.Left = W - m - gbCrearFactura.Width; // pegado al borde derecho
                gbCrearFactura.Top = gbListaFactura.Top;
                gbCrearFactura.Height = gbListaFactura.Height;

                // Inputs internos: ocupar ancho útil del groupbox derecho
                int inLeft = 12;
                int inWidth = gbCrearFactura.ClientSize.Width - (inLeft * 2);
                txtNombreClienteCrearFactura.Width = inWidth;
                dtpFechaCrearFactura.Width = inWidth;
                cmbProductosFactu.Width = inWidth;
                cmbEstadoFacturaCrearFactura.Width = inWidth;
                txtTotalCrearFactura.Width = inWidth;

                // ===== Botones inferiores =====
                int btnW = 140;
                int btnH = 40;
                int espacio = 20;

                // Tres botones centrados bajo la lista (izquierda)
                int totalRowWidth = (btnW * 3) + (espacio * 2);
                int startX = gbListaFactura.Left + (gbListaFactura.Width - totalRowWidth) / 2;
                if (startX < m) startX = m;

                int yBotones = gbListaFactura.Bottom + 15;

                btnLimpiarFactu.SetBounds(startX, yBotones, btnW, btnH);
                btnEliminarFacturacion.SetBounds(btnLimpiarFactu.Right + espacio, yBotones, btnW, btnH);
                btnEditarFactura.SetBounds(btnEliminarFacturacion.Right + espacio, yBotones, btnW, btnH);

                // Guardar alineado al borde derecho del panel derecho
                btnGuardarFactura.Width = 140;
                btnGuardarFactura.Height = btnH;
                btnGuardarFactura.Top = yBotones;
                btnGuardarFactura.Left = gbCrearFactura.Right - btnGuardarFactura.Width;
            }
            catch
            {
                // estilo simple
            }
        }

        // =============================
        // MÉTODOS DE CARGA DE DATOS
        // =============================

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
            txtTotalCrearFactura.ReadOnly = false;
        }

        private void CargarFacturas()
        {
            dgvMostrarListaFacturas.DataSource = detalleFactura.ListarDesdeVista();
            dgvMostrarListaFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Oculta posibles IDs si vienen en la vista
            foreach (var col in new[] { "idDetalleFactura", "idCliente", "idProducto", "idCompra" })
                if (dgvMostrarListaFacturas.Columns.Contains(col))
                    dgvMostrarListaFacturas.Columns[col].Visible = false;

            txtTotalCrearFactura.ReadOnly = false;
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

        private int CompraDeDetalle(int idDetalle)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("select idCompra from detalleFactura where idDetalleFactura=@id", conexion))
            {
                cmd.Parameters.AddWithValue("@id", idDetalle);
                var x = cmd.ExecuteScalar();
                return (x == null || x == DBNull.Value) ? 0 : Convert.ToInt32(x);
            }
        }

        // =============================
        // BOTONES CRUD
        // =============================

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
                txtTotalCrearFactura.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
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

                int idCompra = CompraDeDetalle(idDetalle);
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
                txtTotalCrearFactura.ReadOnly = false;
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
                MessageBox.Show("Factura eliminada.");
                CargarFacturas();
                Limpiar();
                txtTotalCrearFactura.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // =============================
        // LIMPIAR Y VALIDACIONES
        // =============================

        private void Limpiar()
        {
            txtTotalCrearFactura.ReadOnly = true;
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
            txtTotalCrearFactura.ReadOnly = false;
        }

        private void btnLimpiarFactu_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
                MessageBox.Show("Limpio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
            }
        }

        private void dgvMostrarListaFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMostrarListaFacturas.CurrentRow == null) return;
            var r = dgvMostrarListaFacturas.CurrentRow;

            txtTotalCrearFactura.ReadOnly = true;

            txtNombreClienteCrearFactura.Text = r.Cells["Cliente"].Value?.ToString();
            cmbProductosFactu.Text = r.Cells["Producto"].Value?.ToString();
            dtpFechaCrearFactura.Value = Convert.ToDateTime(r.Cells["FechaFacturacion"].Value);
            txtTotalCrearFactura.Text = r.Cells["Subtotal"].Value?.ToString();
            cmbEstadoFacturaCrearFactura.SelectedItem =
                (r.Cells["Estado"].Value?.ToString() == "Pagada") ? "Pagada" : "Pendiente";

            if (dgvMostrarListaFacturas.Columns.Contains("idDetalleFactura"))
                dgvMostrarListaFacturas.Tag = r.Cells["idDetalleFactura"].Value;
        }
    }
}
