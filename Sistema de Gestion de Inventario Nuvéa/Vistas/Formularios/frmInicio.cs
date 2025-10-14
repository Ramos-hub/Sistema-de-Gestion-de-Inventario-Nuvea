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
            this.Resize += frmIndex_Resize;
            this.Load += new EventHandler(frmInicio_Load);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
                gbInicio.AutoSize = false;
                gbInicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                lblBienvenidos.AutoSize = true;
                lblBienvenidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                pictureBox1.Anchor = AnchorStyles.Top;
            
            CargarlblProductosBajoStock();
            CargarlblTotalProductos();
            CargarlblTotalVentas();
            CargarlblCategoriasIni();
            CargarlblProveedoresIni();
            CargarBienvenidaAdmin();
            CargarChartVentasPorUsuario();

            AjustarHeaderInicio();
            AjustarLayout();
        }

        private void frmIndex_Resize(object sender, EventArgs e)
        {
            AjustarHeaderInicio();
            AjustarLayout();
        }

        private void AjustarHeaderInicio()
        {

                int margen = 16;

                int W = this.ClientSize.Width;
                gbInicio.Left = margen;
                gbInicio.Top = 16;
                gbInicio.Width = W - (margen * 2);

                int topImg = 12;
                pictureBox1.Top = topImg;
                pictureBox1.Left = (gbInicio.ClientSize.Width - pictureBox1.Width) / 2;

                int topLbl = pictureBox1.Bottom + 8;
                lblBienvenidos.Top = topLbl;
                lblBienvenidos.Left = (gbInicio.ClientSize.Width - lblBienvenidos.Width) / 2;

                int contenidoBottom = Math.Max(pictureBox1.Bottom, lblBienvenidos.Bottom);
                gbInicio.Height = (contenidoBottom + 16);

        }

        private void AjustarLayout()
        {
            int m = 16; 
            int H = this.ClientSize.Height;
            int W = this.ClientSize.Width;

            int topTarjetas = (gbInicio != null ? gbInicio.Bottom : 140) + m;

            int anchoPanel = (W - (m * 5)) / 4;
            int altoPanel = 80;

            pnlTotalProductos.Left = m;
            pnlTotalProductos.Top = topTarjetas;
            pnlTotalProductos.Width = anchoPanel;
            pnlTotalProductos.Height = altoPanel;

            pnlVentasDiarias.Left = pnlTotalProductos.Right + m;
            pnlVentasDiarias.Top = topTarjetas;
            pnlVentasDiarias.Width = anchoPanel;
            pnlVentasDiarias.Height = altoPanel;

            pnlCategorias.Left = pnlVentasDiarias.Right + m;
            pnlCategorias.Top = topTarjetas;
            pnlCategorias.Width = anchoPanel;
            pnlCategorias.Height = altoPanel;

            pnlProveedores.Left = pnlCategorias.Right + m;
            pnlProveedores.Top = topTarjetas;
            pnlProveedores.Width = anchoPanel;
            pnlProveedores.Height = altoPanel;

            int topBloque = pnlTotalProductos.Bottom + (m * 2);
            int anchoCol = (W - (m * 3)) / 2;
            int altoBloque = Math.Max(260, H - topBloque - m);

            chartVentasUsuarios.Left = m;
            chartVentasUsuarios.Top = topBloque;
            chartVentasUsuarios.Width = anchoCol;
            chartVentasUsuarios.Height = altoBloque;

            gbProductosBajoStock.Left = chartVentasUsuarios.Right + m;
            gbProductosBajoStock.Top = topBloque;
            gbProductosBajoStock.Width = anchoCol;
            gbProductosBajoStock.Height = altoBloque;

            dgvProductosBajoStock.Left = 10;
            dgvProductosBajoStock.Top = 25;
            dgvProductosBajoStock.Width = gbProductosBajoStock.ClientSize.Width - 20;
            dgvProductosBajoStock.Height = gbProductosBajoStock.ClientSize.Height - 35;
        }

        private void CargarBienvenidaAdmin()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();

                string consulta = "SELECT TOP 1 nombre FROM Usuario WHERE idRol = 1 ORDER BY idUsuario";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                object resultado = cmd.ExecuteScalar();

                string nombreAdmin = "Administrador";
                if (resultado != null && resultado != DBNull.Value)
                {
                    nombreAdmin = resultado.ToString();
                }

                lblBienvenidos.Text = "Bienvenido " + nombreAdmin + " a Nuvéa";

                conexion.Close();

                AjustarHeaderInicio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el nombre del administrador: " + ex.Message);
            }
        }

        private void CargarlblProductosBajoStock()
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
                    string consulta = "select count(*) from Producto";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    {
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        lbltotalResultadosIni.Text = total.ToString();
                    }
                    conexion.Close();
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
                string consulta = "select isnull(sum(subtotal), 0) from detalleFactura";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                {
                    decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblResultadoVentasIni.Text = total.ToString("0.00");
                }
                conexion.Close();
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
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener total categorias: " + ex.Message);
            }

        }
        private void CargarlblProveedoresIni()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                {
                    string consulta = "select count(*) from Proveedor";
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    {
                        int totalprove = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalProveedores.Text = totalprove.ToString();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el total de proveedores: " + ex.Message);
            }

        }

        private void CargarChartVentasPorUsuario()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();

                string consulta = @"SELECT u.nombre AS Empleado, SUM(c.total) AS TotalVentas
                                    FROM Compra c
                                    INNER JOIN Usuario u ON u.idUsuario = c.idUsuario
                                    INNER JOIN Rol r ON r.idRol = u.idRol
                                    WHERE r.nombreRol <> 'Administrador'
                                    GROUP BY u.nombre
                                    ORDER BY SUM(c.total) DESC";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                chartVentasUsuarios.Series.Clear();
                chartVentasUsuarios.ChartAreas.Clear();
                chartVentasUsuarios.Titles.Clear();

                var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea("Area1");
                area.Area3DStyle.Enable3D = false; // plano para que no se vea raro
                area.BackColor = Color.White;

                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.LabelStyle.Format = "C2";
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -30;

                chartVentasUsuarios.ChartAreas.Add(area);

                var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Ventas");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;
                serie.LabelFormat = "C2";
                serie.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                serie.Color = Color.FromArgb(77, 177, 253);
                serie.BorderWidth = 2;

                chartVentasUsuarios.Series.Add(serie);

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    string empleado = tabla.Rows[i]["Empleado"].ToString();
                    double total = 0;
                    double.TryParse(tabla.Rows[i]["TotalVentas"].ToString(), out total);
                    chartVentasUsuarios.Series["Ventas"].Points.AddXY(empleado, total);
                }

                chartVentasUsuarios.Titles.Add("Total de Ventas por Empleado ($)");
                chartVentasUsuarios.Titles[0].Font = new Font("Segoe UI", 11, FontStyle.Bold);
                chartVentasUsuarios.BackColor = Color.WhiteSmoke;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }
    }
}
