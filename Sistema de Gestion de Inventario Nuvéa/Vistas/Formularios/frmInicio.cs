using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Conexion;
using Vistas.Formularios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Formularios
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmInicio_Load);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            CargarProductosBajoStock();
            CargarlblTotalProductos();
            CargarlblTotalVentas();
            CargarlblCategoriasIni();
        }
        private Form activarForm = null;
        //Metodo que me permitira activar los formularios
        private void abrirForm(Form formularioPintar)
        {

            if (activarForm != null)
            {
                activarForm.Close();
            }
            frmPrincipal fr = new frmPrincipal();
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            fr.pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();



        }

        private void btnIrInventario_Click(object sender, EventArgs e)
        {

            frmInventario verInv = new frmInventario();
            verInv.Show();
            this.Hide();


        }

        private void CargarProductosBajoStock()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consulta = @"select nombreProduc as Producto, fechaIngreso, estado, cantidadStock as Stock
                            from Producto 
                            where cantidadStock < 3";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvProductosBajoStock.DataSource = tabla;
            conexion.Close();

        }
        private void CargarlblTotalProductos()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                {
                    //count cuenta cuántas filas existen en la tabla.
                    //* significa “todas las filas” sin importar el contenido de las columnas.
                    string consulta = "select count(*) from Producto";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    {
                        //El metodo .ExecuteScalar() ejecuta esa consulta y devuelve el valor del a primera fila y columna en modo objeto por eso hacemos la conversion a tipo entero
                        // Ejemplo: si en la tabla hay 20 filas el resultado es una tablita con una sola columna y una sola fila agarra ese 20 directamente.
                        // Así no tienes que recorrer filas ni columnas, ya te da el valor listo para usar.
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        lbltotalResultadosIni.Text = total.ToString();
                    }
                    conexion.Close ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener total de productos: " + ex.Message);
            }
        }
        private void CargarlblTotalVentas() 
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                {
                    //ISNULL sirve para reemplazar un valor nulo(NULL) por otro.
                    //Si SUM(subtotal) no encuentra nada(por ejemplo, si la tabla está vacía), el resultado sería NULL.
                    //ISNULL(SUM(subtotal), 0) asegura que, en lugar de NULL, devuelva 0.
                    string consulta = "select isnull(sum(subtotal), 0) from detalleFactura";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    { 
                    decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblResultadoVentasIni.Text = total.ToString("0.00");
        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ventas de hoy: " + ex.Message);
            } 
        }
        private void CargarlblCategoriasIni() 
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                {
                    string consulta = "select count(*) from Categoria";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    {
                        int totalCate = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCategoriasIni.Text = totalCate.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener total categorias: " + ex.Message);
            }
        
        }
    }
}
