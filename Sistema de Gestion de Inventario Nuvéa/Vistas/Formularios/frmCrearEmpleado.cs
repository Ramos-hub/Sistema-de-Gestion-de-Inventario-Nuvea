using Modelo.Conexion;
using Modelos;
using Modelos.Entidades;
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
    public partial class frmCrearEmpleado: Form
    {
        int idSeleccionado = 0;
        public frmCrearEmpleado()
        {
            InitializeComponent();
        }
        private bool CargarUsuarios()
        {
            try
            {
                DataTable datos = Usuario.MostrarUsuarios();
               dgvVerEmpleadosCreados.DataSource = datos;

                if (dgvVerEmpleadosCreados.Columns.Contains("idUsuario"))
                    dgvVerEmpleadosCreados.Columns["idUsuario"].Visible = false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
                return false;
            }
        }
        private bool Limpiar()
        {
            try
            {
                txtNombreUsuarioRegisCrearU.Clear();
                txtClaveCrearEmpleado.Clear();
                txtCorreoRegisCrearU.Clear();
                txtNumTelCrearU.Clear();
                idSeleccionado = 0;
                txtNombreUsuarioRegisCrearU.Focus();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
                return false;
            }
        }

        private void btnLimpiarCrearEmpleado_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmCrearEmpleado_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private bool AgregarUsuario()
        {
            try
            {
                if (txtNombreUsuarioRegisCrearU.Text == "" || txtClaveCrearEmpleado.Text == "" || txtNumTelCrearU.Text == "" || txtCorreoRegisCrearU.Text == "")
                {
                    MessageBox.Show("Rellena todos los campos.");
                    return false;
                }
                

                Usuario nuevo = new Usuario();
                nuevo.IdRol = 2;
                nuevo.Nombre = txtNombreUsuarioRegisCrearU.Text;
                nuevo.Correo = txtCorreoRegisCrearU.Text;
                nuevo.Telefono = txtNumTelCrearU.Text;
                nuevo.Clave = txtClaveCrearEmpleado.Text;

                Usuario.AgregarUsuario(nuevo);
                CargarUsuarios();
                Limpiar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
                return false;
            }
        }

        private bool EditarUsuario()
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un usuario para editar.");
                    return false;
                }

                Usuario editar = new Usuario();
                editar.IdUsuario = idSeleccionado;
                editar.Nombre = txtNombreUsuarioRegisCrearU.Text;
                editar.Correo = txtCorreoRegisCrearU.Text;
                editar.Telefono = txtNumTelCrearU.Text;
                editar.Clave = txtClaveCrearEmpleado.Text;

                Usuario.EditarUsuario(editar);
                CargarUsuarios();
                Limpiar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
                return false;
            }
        }

        private bool EliminarUsuario()
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un usuario para eliminar.");
                    return false;
                }

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Usuario.EliminarUsuario(idSeleccionado);
                    CargarUsuarios();
                    Limpiar();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                return false;
            }
        }

        private void btnAñadirCuenta_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void dgvVerEmpleadosCreados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    idSeleccionado = Convert.ToInt32(dgvVerEmpleadosCreados.Rows[e.RowIndex].Cells["idUsuario"].Value);
                    txtNombreUsuarioRegisCrearU.Text = dgvVerEmpleadosCreados.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    txtCorreoRegisCrearU.Text = dgvVerEmpleadosCreados.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                    txtNumTelCrearU.Text = dgvVerEmpleadosCreados.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                    txtClaveCrearEmpleado.Text = dgvVerEmpleadosCreados.Rows[e.RowIndex].Cells["clave"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuario: " + ex.Message);
            }
        }
    }
}
