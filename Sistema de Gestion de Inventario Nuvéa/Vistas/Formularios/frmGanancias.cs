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
using System.Windows.Forms.DataVisualization.Charting;
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class frmGanancias : Form
    {
        public frmGanancias()
        {
            InitializeComponent();
            this.Load += frmGanancias_Load;
        }
        private void frmGanancias_Load(object sender, EventArgs e)
        {
            // Llamo al método que llena el gráfico
            CargarGraficoProductos();
            CargarVentasPorCategoria();
            CargarLabelsGanancias();
        }
        private void CargarGraficoProductos()
        {
            // Consulta para traer los productos más vendidos
            string consulta = @"SELECT TOP 5 p.nombreProduc AS Producto,
                SUM(df.cantidadProduct) AS Cantidad FROM detalleFactura df
            INNER JOIN Producto p ON p.idProducto = df.idProducto
            WHERE df.estado = 1
            GROUP BY p.nombreProduc
            ORDER BY Cantidad DESC;";

            // Limpio lo que tenga el chart y creo la serie
            chtProductosMasVendidos.Series.Clear();
            Series serie = new Series("Más vendidos");
            serie.ChartType = SeriesChartType.Doughnut; // Gráfico tipo dona
            serie.IsValueShownAsLabel = true;           // Mostrar valores en el gráfico

            try
            {
                using (SqlConnection con = ConexionDB.Conectar())
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string producto = dr["Producto"].ToString();
                        int cantidad = Convert.ToInt32(dr["Cantidad"]);
                        serie.Points.AddXY(producto, cantidad);
                    }
                }
            }
            catch (Exception)
            {
                // Si hay error, meto datos inventados para probar
                serie.Points.AddXY("Cremas", 30);
                serie.Points.AddXY("Shampoo", 20);
                serie.Points.AddXY("Jabones", 15);
            }

            // Agrego la serie al chart
            chtProductosMasVendidos.Series.Add(serie);
            chtProductosMasVendidos.Titles.Clear();
            chtProductosMasVendidos.Titles.Add("Productos más vendidos");
        }
        private void CargarVentasPorCategoria()
        {
            // Consulta: sumar cuántas unidades se han vendido por cada categoría
            string sql = @"SELECT  c.nombreCat AS Categoria,
            ISNULL(SUM(df.cantidadProduct), 0) AS CantidadVendida
            FROM Categoria c
        LEFT JOIN Producto p ON p.idCategoria = c.idCategoria
        LEFT JOIN detalleFactura df ON df.idProducto = p.idProducto AND df.estado = 1
        GROUP BY c.nombreCat
        ORDER BY CantidadVendida DESC;";

            // Limpio el chart antes de llenarlo
            chtVentasPorCategoria.Series.Clear();
            var serie = new Series("Ventas por Categoría");
            serie.ChartType = SeriesChartType.Pie; // Gráfico tipo Pie
            serie.IsValueShownAsLabel = true;   // Mostrar número en el gráfico
            serie.LabelFormat = "#,0";          // Formato de número

            // Opciones de estilo para que se vea mejor
            serie["PieLabelStyle"] = "Outside"; // etiquetas afuera
            serie["PieDrawingStyle"] = "SoftEdge";

            try
            {
                using (var con = ConexionDB.Conectar())
                using (var cmd = new SqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string categoria = dr["Categoria"].ToString();
                        int cantidad = Convert.ToInt32(dr["CantidadVendida"]);
                        serie.Points.AddXY(categoria, cantidad);
                    }
                }
            }
            catch
            {
                // Datos de prueba si falla la conexión
                serie.Points.AddXY("Cremas", 30);
                serie.Points.AddXY("Perfumes", 20);
                serie.Points.AddXY("Jabones", 15);
                serie.Points.AddXY("Shampoo", 12);
                serie.Points.AddXY("Mascarillas", 8);
            }

            // Agregar la serie al chart
            chtVentasPorCategoria.Series.Add(serie);

            // Título del gráfico
            chtVentasPorCategoria.Titles.Clear();
            chtVentasPorCategoria.Titles.Add("Ventas por Categoría");
        }
        private void CargarLabelsGanancias()
        {
            // Consulta: total general
            string sqlTotal = @"SELECT ISNULL(SUM(subtotal),0) AS Total FROM detalleFactura WHERE estado = 1";

            // Consulta: total del mes actual
            string sqlMes = @"
        SELECT ISNULL(SUM(subtotal),0) AS TotalMes
        FROM detalleFactura
        WHERE estado = 1 AND MONTH(fecha) = MONTH(GETDATE()) AND YEAR(fecha) = YEAR(GETDATE())";

            // Consulta: total del año actual
            string sqlAnio = @"
        SELECT ISNULL(SUM(subtotal),0) AS TotalAnio
        FROM detalleFactura
        WHERE estado = 1 AND YEAR(fecha) = YEAR(GETDATE())";

            try
            {
                using (var con = ConexionDB.Conectar())
                {
                    // Total
                    using (var cmd = new SqlCommand(sqlTotal, con))
                    {
                        decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalGanancias.Text = "$ " + total.ToString("N2");
                    }

                    // Mes
                    using (var cmd = new SqlCommand(sqlMes, con))
                    {
                        decimal totalMes = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblGananciaMes.Text = "$ " + totalMes.ToString("N2");
                    }

                    // Año
                    using (var cmd = new SqlCommand(sqlAnio, con))
                    {
                        decimal totalAnio = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblGananciasAnio.Text = "$ " + totalAnio.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ganancias: " + ex.Message);

                // Datos de prueba
                lblTotalGanancias.Text = "$ 1,000.00";
                lblGananciaMes.Text = "$ 250.00";
                lblGananciasAnio.Text = "$ 800.00";
            }
        }

    }
}
