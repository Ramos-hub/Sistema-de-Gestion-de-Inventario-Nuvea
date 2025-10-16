using System;
using System.Data.SqlClient;
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
            this.Resize += (_, __) => AjustarResponsive();
        }

        private void frmGanancias_Load(object sender, EventArgs e)
        {
            CargarGraficoProductos();
            CargarVentasPorCategoria();
            CargarLabelsGanancias();
            AjustarResponsive();
        }

        // ============================================================
        // ==================== RESPONSIVE LAYOUT =====================
        // ============================================================
        private void AjustarResponsive()
        {
            try
            {
                int m = 16;                         // margen general
                int W = this.ClientSize.Width;
                int H = this.ClientSize.Height;
                if (H < 600) H = 600;

                // ======= TARJETAS DE ARRIBA (3 paneles) =======
                // Asumo que existen: panelTotalGanancias, panelGananciaMes, panelGananciaAnio
                int panelWidth = (W - (m * 4)) / 3;
                int panelHeight = 90;
                int topPanelY = m + 20;

                if (panelTotalGanancias != null)
                {
                    panelTotalGanancias.SetBounds(m, topPanelY, panelWidth, panelHeight);
                }
                if (panelGananciaMes != null)
                {
                    panelGananciaMes.SetBounds(panelTotalGanancias.Right + m, topPanelY, panelWidth, panelHeight);
                }
                if (panelGananciaAnio != null)
                {
                    panelGananciaAnio.SetBounds(panelGananciaMes.Right + m, topPanelY, panelWidth, panelHeight);
                }

                // ======= CONTENEDOR ÚNICO DE GRÁFICOS =======
                // Ambos charts viven dentro del mismo panel contenedor (cualquiera de los dos charts nos dice cuál es).
                Control cont = (chtProductosMasVendidos != null ? chtProductosMasVendidos.Parent : null)
                               ?? (chtVentasPorCategoria != null ? chtVentasPorCategoria.Parent : null);

                int chartsTop = (panelTotalGanancias?.Bottom ?? (topPanelY + panelHeight)) + (m * 2);
                int chartsHeight = H - chartsTop - m;

                if (cont != null)
                {
                    // El contenedor ocupa todo el ancho debajo de las tarjetas
                    cont.Left = m;
                    cont.Top = chartsTop;
                    cont.Width = W - (m * 2);
                    cont.Height = chartsHeight;
                }

                // ======= ACOMODO DE LOS DOS CHARTS DENTRO DEL MISMO CONTENEDOR =======
                if (cont != null && chtProductosMasVendidos != null && chtVentasPorCategoria != null)
                {
                    // Quitamos Dock para poder posicionarlos manualmente
                    chtProductosMasVendidos.Dock = DockStyle.None;
                    chtVentasPorCategoria.Dock = DockStyle.None;

                    // Modo: lado a lado si hay ancho suficiente, si no, apilados
                    bool ladoALado = cont.ClientSize.Width >= 900; // umbral simple

                    if (ladoALado)
                    {
                        int anchoCol = (cont.ClientSize.Width - m) / 2;
                        int alto = cont.ClientSize.Height;

                        chtProductosMasVendidos.SetBounds(0, 0, anchoCol, alto);
                        chtVentasPorCategoria.SetBounds(chtProductosMasVendidos.Right + m, 0, anchoCol, alto);
                    }
                    else
                    {
                        int altoFila = (cont.ClientSize.Height - m) / 2;
                        int ancho = cont.ClientSize.Width;

                        chtProductosMasVendidos.SetBounds(0, 0, ancho, altoFila);
                        chtVentasPorCategoria.SetBounds(0, chtProductosMasVendidos.Bottom + m, ancho, altoFila);
                    }

                    // Aseguro áreas de gráfico
                    if (chtProductosMasVendidos.ChartAreas.Count == 0)
                        chtProductosMasVendidos.ChartAreas.Add(new ChartArea("Area1"));
                    if (chtVentasPorCategoria.ChartAreas.Count == 0)
                        chtVentasPorCategoria.ChartAreas.Add(new ChartArea("Area1"));

                    chtProductosMasVendidos.ChartAreas[0].Area3DStyle.Enable3D = false;
                    chtVentasPorCategoria.ChartAreas[0].Area3DStyle.Enable3D = false;
                }

                // ======= LABELS CENTRADOS EN TARJETAS =======
                CenterLabelInPanel(lblTotalGanancias, panelTotalGanancias);
                CenterLabelInPanel(lblGananciaMes, panelGananciaMes);
                CenterLabelInPanel(lblGananciasAnio, panelGananciaAnio);
            }
            catch
            {
                // No romper la UI si falta algún control.
            }
        }

        private void CenterLabelInPanel(Label lbl, Control pnl)
        {
            if (lbl == null || pnl == null) return;
            lbl.Left = (pnl.ClientSize.Width - lbl.Width) / 2;
            lbl.Top = (pnl.ClientSize.Height - lbl.Height) / 2;
        }

        // ============================================================
        // =================== CONSULTAS Y GRÁFICOS ===================
        // ============================================================
        private void CargarGraficoProductos()
        {
            string consulta = @"
                SELECT TOP 5 p.nombreProduc AS Producto,
                       SUM(df.cantidadProduct) AS Cantidad 
                FROM detalleFactura df
                INNER JOIN Producto p ON p.idProducto = df.idProducto
                WHERE df.estado = 1
                GROUP BY p.nombreProduc
                ORDER BY Cantidad DESC;";

            chtProductosMasVendidos.Series.Clear();
            var serie = new Series("Más vendidos")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };

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
            catch
            {
                // Datos de prueba si hay problema de conexión
                serie.Points.AddXY("Cremas", 30);
                serie.Points.AddXY("Shampoo", 20);
                serie.Points.AddXY("Jabones", 15);
            }

            chtProductosMasVendidos.Series.Add(serie);
            chtProductosMasVendidos.Titles.Clear();
            chtProductosMasVendidos.Titles.Add("Productos más vendidos");
        }

        private void CargarVentasPorCategoria()
        {
            string sql = @"
                SELECT  c.nombreCat AS Categoria,
                        ISNULL(SUM(df.cantidadProduct), 0) AS CantidadVendida
                FROM Categoria c
                LEFT JOIN Producto p ON p.idCategoria = c.idCategoria
                LEFT JOIN detalleFactura df ON df.idProducto = p.idProducto AND df.estado = 1
                GROUP BY c.nombreCat
                ORDER BY CantidadVendida DESC;";

            chtVentasPorCategoria.Series.Clear();
            var serie = new Series("Ventas por Categoría")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "#,0"
            };
            serie["PieLabelStyle"] = "Outside";
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
                // Datos de prueba
                serie.Points.AddXY("Cremas", 30);
                serie.Points.AddXY("Perfumes", 20);
                serie.Points.AddXY("Jabones", 15);
                serie.Points.AddXY("Shampoo", 12);
                serie.Points.AddXY("Mascarillas", 8);
            }

            chtVentasPorCategoria.Series.Add(serie);
            chtVentasPorCategoria.Titles.Clear();
            chtVentasPorCategoria.Titles.Add("Ventas por Categoría");
        }

        private void CargarLabelsGanancias()
        {
            string sqlTotal = @"SELECT ISNULL(SUM(subtotal),0) AS Total FROM detalleFactura WHERE estado = 1";
            string sqlMes = @"SELECT ISNULL(SUM(subtotal),0) AS TotalMes
                              FROM detalleFactura
                              WHERE estado = 1 AND MONTH(fecha) = MONTH(GETDATE()) AND YEAR(fecha) = YEAR(GETDATE())";
            string sqlAnio = @"SELECT ISNULL(SUM(subtotal),0) AS TotalAnio
                               FROM detalleFactura
                               WHERE estado = 1 AND YEAR(fecha) = YEAR(GETDATE())";

            try
            {
                using (var con = ConexionDB.Conectar())
                {
                    using (var cmd = new SqlCommand(sqlTotal, con))
                        lblTotalGanancias.Text = "$ " + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");

                    using (var cmd = new SqlCommand(sqlMes, con))
                        lblGananciaMes.Text = "$ " + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");

                    using (var cmd = new SqlCommand(sqlAnio, con))
                        lblGananciasAnio.Text = "$ " + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");
                }
            }
            catch
            {
                // Valores de respaldo
                lblTotalGanancias.Text = "$ 1,000.00";
                lblGananciaMes.Text = "$ 250.00";
                lblGananciasAnio.Text = "$ 800.00";
            }
        }
    }
}
