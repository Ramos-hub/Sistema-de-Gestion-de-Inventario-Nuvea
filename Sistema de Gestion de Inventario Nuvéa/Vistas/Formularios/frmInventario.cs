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
            string consulta = @"SELECT 
                                P.nombreProduc as Producto, 
                                P.fechaIngreso, 
                                P.cantidadStock as Stock, 
                                P.codigoBarras, 
                                P.precioProduc as Precio, 
                                C.nombreCat AS categoria
                            FROM Producto P
                            INNER JOIN Categoria C ON P.idCategoria = C.idCategoria";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
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
            string consulta = @"INSERT INTO Producto 
                            (nombreProduc, fechaIngreso, estado, cantidadStock, codigoBarras, precioProduc, idCategoria, idProveedor)
                            VALUES 
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
    }
}
