using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmProveedores: Form
    {
        //Esto guarda el ID selecionado para despues eliminar y editar
        private int? idSeleccionado = null;
        public frmProveedores()
        {
            InitializeComponent();
            this.Load += frmProveedores_Load;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // Teléfono: solo números y 8 dígitos
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
                    MessageBox.Show("Proveedor agregado.");
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
                    MessageBox.Show("Proveedor actualizado.");
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

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona un proveedor (doble clic en la tabla).");
                return;
            }

            if (MessageBox.Show("¿Eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                var p = new Proveedor { IdProveedor = idSeleccionado.Value };
                if (p.Eliminar())
                {
                    MessageBox.Show("Proveedor eliminado.");
                    CargarTabla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
