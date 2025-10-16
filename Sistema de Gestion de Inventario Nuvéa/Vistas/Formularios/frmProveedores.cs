using System;
using System.Data;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmProveedores : Form
    {
        private int? idSeleccionado = null;

        public frmProveedores()
        {
            InitializeComponent();

            // Responsive para el layout actual (panel2 izquierda, panel1 derecha, 4 botones dentro de panel2)
            this.Load += Frm_Load_Responsive;
            this.Resize += (_, __) => ApplyResponsiveLayout();
        }

        // =========================
        //  BLOQUE RESPONSIVE NUEVO
        // =========================
        private void Frm_Load_Responsive(object sender, EventArgs e)
        {
            // panel izquierdo (formulario)
            if (panel2 != null)
                panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;

            // panel derecho (contenedor del DGV)
            if (panel1 != null)
                panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // DataGridView
            if (dgvMostrarProveedores != null)
            {
                if (dgvMostrarProveedores.Parent == panel1)
                    dgvMostrarProveedores.Dock = DockStyle.Fill;
                else
                    dgvMostrarProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            }

            // Los 4 botones van dentro de panel2 (dos filas)
            if (btnAgregarProveedor != null) btnAgregarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            if (btnEditarProveedor != null) btnEditarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            if (btnLimpiarProveedor != null) btnLimpiarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            if (btnEliminarProveedor != null) btnEliminarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            ApplyResponsiveLayout();
        }

        private void ApplyResponsiveLayout()
        {
            try
            {
                int m = 16; // margen exterior
                int W = this.ClientSize.Width;
                int H = this.ClientSize.Height;
                if (H < 560) H = 560;

                // Espacio superior para el título “Proveedores”
                int topBody = 90;

                // Altura mínima que dejamos libre en panel2 para colocar los 4 botones
                int altoZonaBotonesPanel2 = 110;

                // ====== panel2 (izquierda) ======
                int leftW = Math.Max(340, Math.Min(460, (int)(W * 0.30))); // 30% con límites
                if (panel2 != null)
                {
                    panel2.Left = m;
                    panel2.Top = topBody;
                    panel2.Width = leftW;
                    panel2.Height = H - topBody - m; // ocupa casi todo
                }

                // ====== panel1 (derecha) ======
                int xRight = (panel2 != null ? panel2.Right + m : m);
                int rightW = W - xRight - m;
                if (rightW < 380) rightW = 380;

                if (panel1 != null)
                {
                    panel1.Left = xRight;
                    panel1.Top = topBody;
                    panel1.Width = rightW;
                    panel1.Height = H - topBody - m;
                }
                else if (dgvMostrarProveedores != null)
                {
                    // Si no usas panel1 y el DGV está directo en el form
                    dgvMostrarProveedores.Left = xRight;
                    dgvMostrarProveedores.Top = topBody;
                    dgvMostrarProveedores.Width = rightW;
                    dgvMostrarProveedores.Height = H - topBody - m;
                }

                // ====== Botones dentro de panel2 (dos filas) ======
                // layout: [Agregar] [Editar]   en primera fila
                //         [Limpiar] [Eliminar] en segunda fila
                if (panel2 != null &&
                    btnAgregarProveedor != null &&
                    btnEditarProveedor != null &&
                    btnLimpiarProveedor != null &&
                    btnEliminarProveedor != null)
                {
                    int gapX = 12;                 // separación horizontal entre botones
                    int gapY = 10;                 // separación vertical entre filas
                    int btnW = (panel2.Width - (m * 2) - gapX) / 2;  // dos columnas
                    int btnH = 40;

                    // Y base (desde abajo)
                    int y2 = panel2.Height - m - btnH;              // fila 2 (abajo)
                    int y1 = y2 - btnH - gapY;                      // fila 1 (arriba)

                    int x1 = m;                                     // columna 1
                    int x2 = x1 + btnW + gapX;                      // columna 2

                    // fila 1
                    btnAgregarProveedor.SetBounds(x1, y1, btnW, btnH);
                    btnEditarProveedor.SetBounds(x2, y1, btnW, btnH);

                    // fila 2
                    btnLimpiarProveedor.SetBounds(x1, y2, btnW, btnH);
                    btnEliminarProveedor.SetBounds(x2, y2, btnW, btnH);
                }
            }
            catch
            {
                // si falta algún control, no rompemos el form
            }
        }

        // =========================
        //   CRUD (tu lógica)
        // =========================

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // Validación de teléfono
            txtTelefonoProveedor.MaxLength = 8;
            txtTelefonoProveedor.KeyPress += (s, ev) =>
            {
                if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar))
                    ev.Handled = true;
            };

            dgvMostrarProveedores.CellDoubleClick += dgvMostrarProveedores_CellDoubleClick;

            CargarTabla();
            Limpiar();
        }

        private void CargarTabla()
        {
            dgvMostrarProveedores.DataSource = Proveedor.MostrarProveedores();
            dgvMostrarProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvMostrarProveedores.Columns.Contains("ID"))
                dgvMostrarProveedores.Columns["ID"].Visible = false;
        }

        private void Limpiar()
        {
            txtNombreProveedor.Text = "";
            txtNombreTrabajador.Text = "";
            txtTelefonoProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            idSeleccionado = null;
            dgvMostrarProveedores.ClearSelection();
            txtNombreProveedor.Focus();
        }

        private bool LeerProveedor(out Proveedor p, out string error, bool exigirId = false)
        {
            p = null;
            error = "";

            if (exigirId && idSeleccionado == null)
            {
                error = "Selecciona un proveedor (doble clic en la tabla).";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
            {
                error = "El nombre del proveedor es obligatorio.";
                return false;
            }

            if (txtTelefonoProveedor.Text.Length != 8)
            {
                error = "El teléfono debe tener 8 dígitos.";
                return false;
            }

            p = new Proveedor
            {
                IdProveedor = idSeleccionado ?? 0,
                NombreProveedor = txtNombreProveedor.Text.Trim(),
                NombreTrabajador = txtNombreTrabajador.Text.Trim(),
                Telefono = txtTelefonoProveedor.Text.Trim(),
                Direccion = txtDireccionProveedor.Text.Trim()
            };
            return true;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (!LeerProveedor(out var p, out string error))
            {
                MessageBox.Show(error);
                return;
            }
            try
            {
                if (p.Insertar())
                {
                    MessageBox.Show("Proveedor agregado correctamente.");
                    CargarTabla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se agregó el proveedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void dgvMostrarProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMostrarProveedores.CurrentRow == null) return;

            var r = dgvMostrarProveedores.CurrentRow;
            idSeleccionado = Convert.ToInt32(r.Cells["ID"].Value);
            txtNombreProveedor.Text = r.Cells["Proveedor"].Value?.ToString();
            txtNombreTrabajador.Text = r.Cells["Trabajador"].Value?.ToString();
            txtTelefonoProveedor.Text = r.Cells["Telefono"].Value?.ToString();
            txtDireccionProveedor.Text = r.Cells["Direccion"].Value?.ToString();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (!LeerProveedor(out var p, out string error, exigirId: true))
            {
                MessageBox.Show(error);
                return;
            }

            try
            {
                if (p.Actualizar())
                {
                    MessageBox.Show("Proveedor actualizado correctamente.");
                    CargarTabla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se actualizó el proveedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvMostrarProveedores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un proveedor.");
                return;
            }

            int idProveedor = Convert.ToInt32(dgvMostrarProveedores.CurrentRow.Cells["ID"].Value);
            var r = MessageBox.Show("¿Seguro que deseas eliminar a este proveedor?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            try
            {
                var pr = new Proveedor { IdProveedor = idProveedor };
                pr.EliminarProveedor();

                MessageBox.Show("Proveedor eliminado correctamente.");
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64)
                || (e.KeyChar >= 91 && e.KeyChar <= 96)
                || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras permitidas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNombreTrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64)
                || (e.KeyChar >= 91 && e.KeyChar <= 96)
                || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras permitidas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
