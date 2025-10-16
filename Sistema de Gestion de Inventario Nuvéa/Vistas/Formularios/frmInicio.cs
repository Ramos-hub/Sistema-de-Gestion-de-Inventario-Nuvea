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
                using (SqlConnection conexion = ConexionDB.Conectar())
                using (SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT u.nombre AS Empleado, SUM(c.total) AS TotalVentas
            FROM Compra c
            INNER JOIN Usuario u ON u.idUsuario = c.idUsuario
            INNER JOIN Rol r ON r.idRol = u.idRol
            WHERE r.nombreRol <> 'Administrador'
            GROUP BY u.nombre
            ORDER BY SUM(c.total) DESC;", conexion))
                {
                    var dt = new DataTable();
                    da.Fill(dt);

                    // ---------- limpiar ----------
                    chartVentasUsuarios.Series.Clear();
                    chartVentasUsuarios.ChartAreas.Clear();
                    chartVentasUsuarios.Titles.Clear();
                    chartVentasUsuarios.Legends.Clear();

                    chartVentasUsuarios.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All;
                    chartVentasUsuarios.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.High;

                    // ---------- área ----------
                    var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea("Area");
                    area.BackColor = Color.White;
                    area.AxisX.MajorGrid.Enabled = false;
                    area.AxisY.MajorGrid.LineColor = Color.Gainsboro;

                    // Etiquetas del eje X legibles
                    area.AxisX.Interval = 1;
                    area.AxisX.IsLabelAutoFit = true;
                    area.AxisX.LabelAutoFitStyle =
                        System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont |
                        System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels;
                    area.AxisX.LabelAutoFitMaxFontSize = 10;
                    area.AxisX.LabelAutoFitMinFontSize = 7;
                    area.AxisX.LabelStyle.Angle = -60; // inclina
                    area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);

                    area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9f);
                    area.AxisY.LabelStyle.Format = "C2";

                    // Deja más aire abajo para las etiquetas
                    area.Position.Auto = false;
                    area.Position.X = 3;     // %
                    area.Position.Y = 2;
                    area.Position.Width = 94;
                    area.Position.Height = 92;

                    area.InnerPlotPosition.Auto = false;
                    area.InnerPlotPosition.X = 5;   // %
                    area.InnerPlotPosition.Y = 4;
                    area.InnerPlotPosition.Width = 90;
                    area.InnerPlotPosition.Height = 78; // <- más alto deja más base para labels

                    chartVentasUsuarios.ChartAreas.Add(area);

                    // ---------- serie ----------
                    var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Ventas")
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        IsValueShownAsLabel = true,
                        LabelFormat = "C2",
                        LabelForeColor = Color.DimGray,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        BorderWidth = 1
                    };
                    serie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
                    serie["PointWidth"] = "0.65";
                    serie.SmartLabelStyle.Enabled = true;

                    chartVentasUsuarios.Series.Add(serie);

                    // Limita a Top 12 para mantenerlo limpio
                    int max = Math.Min(12, dt.Rows.Count);
                    for (int i = 0; i < max; i++)
                    {
                        var nombreOriginal = Convert.ToString(dt.Rows[i]["Empleado"]);
                        var label = FormatearNombreParaEtiqueta(nombreOriginal);
                        double total = Convert.ToDouble(dt.Rows[i]["TotalVentas"]);
                        serie.Points.AddXY(label, total);
                    }

                    // ---------- título + leyenda ----------
                    chartVentasUsuarios.Titles.Add("Total de ventas por empleado ($)");
                    chartVentasUsuarios.Titles[0].Font = new Font("Segoe UI Semibold", 13f);

                    var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("L")
                    {
                        Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right,
                        Font = new Font("Segoe UI", 9f)
                    };
                    chartVentasUsuarios.Legends.Add(legend);

                    chartVentasUsuarios.BackColor = Color.WhiteSmoke;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }
        private string FormatearNombreParaEtiqueta(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return nombre;

            // Si ya es corto, devuélvelo tal cual
            if (nombre.Length <= 14) return nombre;

            // Intenta "Nombre Apellido1 Apellido2" -> "Nombre\nA. A."
            var partes = nombre.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (partes.Length >= 2)
            {
                var nombreCorto = partes[0];
                var apellidosAbrev = string.Join(" ", partes.Skip(1).Select(p => p.Length > 0 ? (p[0] + ".") : ""));
                return nombreCorto + "\n" + apellidosAbrev;
            }

            // Si no hay espacios, corta y agrega "…"
            return nombre.Substring(0, 12) + "…";
        }
    }
}
