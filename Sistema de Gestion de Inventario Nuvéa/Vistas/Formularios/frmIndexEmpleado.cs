using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class frmIndexEmpleado : Form
    {
        // Nombre recibido (por constructor) o tomado desde frmLogin.NombreEmpleadoActivo
        private readonly string _nombreEmpleado;

        // --- OPCIÓN A: usar lo guardado en frmLogin.NombreEmpleadoActivo ---
        public frmIndexEmpleado()
        {
            InitializeComponent();

            // si frmLogin expone el nombre, úsalo como predeterminado
            _nombreEmpleado = TryGetNombreDesdeLogin();

            ConfigurarHeaderComoAdmin();
            this.Load += frmIndexEmpleado_Load;
            this.Resize += (_, __) => { AjustarHeaderInicioEmp(); AjustarLayout(); };
        }

        // --- OPCIÓN B: recibir el nombre por constructor ---
        public frmIndexEmpleado(string nombreEmpleado) : this()
        {
            if (!string.IsNullOrWhiteSpace(nombreEmpleado))
                _nombreEmpleado = nombreEmpleado;
        }

        private static string TryGetNombreDesdeLogin()
        {
            try
            {
                // Si no declaraste esta variable estática, puedes quitar esta línea.
                // En frmLogin agrega: public static string NombreEmpleadoActivo;
                return frmLogin.NombreEmpleadoActivo;
            }
            catch { return null; }
        }

        // ===================== CARGA =====================
        private void frmIndexEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarBienvenidaEmpleado();
                CargarProductosBajoStock();
                CargarTotalesTarjetas();
                CargarChartTopProductos();

                AjustarHeaderInicioEmp();
                AjustarLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar: " + ex.Message);
            }
        }

        // ===================== HEADER (como Admin) =====================
        private void ConfigurarHeaderComoAdmin()
        {
            if (pbEmpleado.Parent != gbInicioEmp)
                gbInicioEmp.Controls.Add(pbEmpleado);

            gbInicioEmp.AutoSize = false;
            gbInicioEmp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            lblBienvenidosEmp.AutoSize = true;
            lblBienvenidosEmp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            pbEmpleado.Dock = DockStyle.None;
            pbEmpleado.Anchor = AnchorStyles.Top;   // centrado como en admin
            pbEmpleado.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmpleado.Visible = true;
        }

        private void AjustarHeaderInicioEmp()
        {
            try
            {
                int margen = 16;
                int W = this.ClientSize.Width;

                gbInicioEmp.Left = margen;
                gbInicioEmp.Top = 16;
                gbInicioEmp.Width = Math.Max(300, W - (margen * 2));

                int topImg = 12;
                pbEmpleado.Top = topImg;
                pbEmpleado.Left = (gbInicioEmp.ClientSize.Width - pbEmpleado.Width) / 2;

                int topLbl = pbEmpleado.Bottom + 8;
                lblBienvenidosEmp.Top = topLbl;
                lblBienvenidosEmp.Left = (gbInicioEmp.ClientSize.Width - lblBienvenidosEmp.Width) / 2;

                int contenidoBottom = Math.Max(pbEmpleado.Bottom, lblBienvenidosEmp.Bottom);
                gbInicioEmp.Height = contenidoBottom + 16;

                pbEmpleado.BringToFront();
                lblBienvenidosEmp.BringToFront();
            }
            catch { /* noop */ }
        }

        // ===================== LAYOUT GENERAL =====================
        private void AjustarLayout()
        {
            int m = 16;
            int H = this.ClientSize.Height;
            int W = this.ClientSize.Width;

            // fila de tarjetas (3)
            int topTarjetas = (gbInicioEmp != null ? gbInicioEmp.Bottom : 140) + m;
            int anchoPanel = (W - (m * 4)) / 3;
            if (anchoPanel < 180) anchoPanel = 180;
            int altoPanel = 80;

            pnlTotalProductosEmp.SetBounds(m, topTarjetas, anchoPanel, altoPanel);
            pnlVentasEmp.SetBounds(pnlTotalProductosEmp.Right + m, topTarjetas, anchoPanel, altoPanel);
            pnlCategoriasEmp.SetBounds(pnlVentasEmp.Right + m, topTarjetas, anchoPanel, altoPanel);

            // parte de abajo (chart + bajo stock)
            int topBloque = pnlTotalProductosEmp.Bottom + (m * 2);
            int anchoCol = (W - (m * 3)) / 2;
            int altoBloque = Math.Max(260, H - topBloque - m);

            chartTopProductos.SetBounds(m, topBloque, anchoCol, altoBloque);
            gbBajoStockEmp.SetBounds(chartTopProductos.Right + m, topBloque, anchoCol, altoBloque);

            dgvProductosBajoStockEmpleado.Left = 10;
            dgvProductosBajoStockEmpleado.Top = 25;
            dgvProductosBajoStockEmpleado.Width = gbBajoStockEmp.ClientSize.Width - 20;
            dgvProductosBajoStockEmpleado.Height = gbBajoStockEmp.ClientSize.Height - 35;
        }

        // ===================== DATOS =====================
        private void CargarBienvenidaEmpleado()
        {
            // NO consultamos base de datos aquí; usamos el nombre real del login
            string nombre = !string.IsNullOrWhiteSpace(_nombreEmpleado)
                                ? _nombreEmpleado
                                : "Empleado";

            lblBienvenidosEmp.Text = $"Bienvenido {nombre} a Nuvéa";

            // Recentrar tras cambiar el texto (ancho del label cambia)
            AjustarHeaderInicioEmp();
        }

        private void CargarProductosBajoStock()
        {
            try
            {
                using (SqlConnection con = ConexionDB.Conectar())
                using (SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT nombreProduc AS Producto,
                             cantidadStock AS Stock,
                             CONVERT(varchar(10), fechaIngreso, 103) AS fechaIngreso
                      FROM Producto
                      WHERE cantidadStock < 3
                      ORDER BY cantidadStock ASC, fechaIngreso ASC", con))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvProductosBajoStockEmpleado.DataSource = dt;
                    dgvProductosBajoStockEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos con bajo stock: " + ex.Message);
            }
        }

        private void CargarTotalesTarjetas()
        {
            try
            {
                using (SqlConnection con = ConexionDB.Conectar())
                {
                    using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Producto", con))
                        lblTotalProdEmp.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();

                    using (var cmd = new SqlCommand("SELECT ISNULL(SUM(subtotal),0) FROM detalleFactura", con))
                        lblVentasEmp.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("0.00");

                    using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Categoria", con))
                        lblCategoriasEmp.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar totales: " + ex.Message);
            }
        }

        // ===================== CHART (Top productos) =====================
        private void CargarChartTopProductos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.Conectar())
                using (SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT TOP 8 p.nombreProduc AS Producto,
                           SUM(df.cantidadProduct) AS Cantidad
                    FROM detalleFactura df
                    INNER JOIN Producto p ON p.idProducto = df.idProducto
                    WHERE df.estado = 1
                    GROUP BY p.nombreProduc
                    ORDER BY Cantidad DESC", con))
                {
                    var dt = new DataTable();
                    da.Fill(dt);

                    chartTopProductos.Series.Clear();
                    chartTopProductos.ChartAreas.Clear();
                    chartTopProductos.Titles.Clear();
                    chartTopProductos.Legends.Clear();

                    var area = new ChartArea("Area");
                    area.BackColor = Color.White;
                    area.AxisX.MajorGrid.Enabled = false;
                    area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
                    area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);
                    area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9f);
                    area.AxisX.Interval = 1;
                    chartTopProductos.ChartAreas.Add(area);

                    var serie = new Series("Top productos")
                    {
                        ChartType = SeriesChartType.Bar,
                        IsValueShownAsLabel = true,
                        LabelForeColor = Color.DimGray,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        BorderWidth = 1,
                        Palette = ChartColorPalette.BrightPastel
                    };
                    serie["PointWidth"] = "0.6";
                    chartTopProductos.Series.Add(serie);

                    foreach (DataRow r in dt.Rows)
                    {
                        string prod = r["Producto"].ToString();
                        double cant = Convert.ToDouble(r["Cantidad"]);
                        chartTopProductos.Series[0].Points.AddXY(prod, cant);
                    }

                    chartTopProductos.Titles.Add("Productos más vendidos");
                    chartTopProductos.Titles[0].Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico: " + ex.Message);

                // datos de respaldo si falla la DB
                chartTopProductos.Series.Clear();
                chartTopProductos.ChartAreas.Clear();
                chartTopProductos.Titles.Clear();

                var area = new ChartArea("Area");
                area.BackColor = Color.White;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
                area.AxisX.Interval = 1;
                chartTopProductos.ChartAreas.Add(area);

                var s = new Series("Top productos")
                {
                    ChartType = SeriesChartType.Bar,
                    IsValueShownAsLabel = true,
                    Palette = ChartColorPalette.BrightPastel
                };
                s.Points.AddXY("Cremas", 30);
                s.Points.AddXY("Shampoo", 24);
                s.Points.AddXY("Jabón", 20);
                s.Points.AddXY("Perfume", 15);
                chartTopProductos.Series.Add(s);

                chartTopProductos.Titles.Add("Productos más vendidos");
                chartTopProductos.Titles[0].Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }
    }
}



