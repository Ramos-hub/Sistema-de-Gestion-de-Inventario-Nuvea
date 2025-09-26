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
    public partial class frmGanacias: Form
    {
        public frmGanacias()
        {
            InitializeComponent();
            this.Load += frmGanacias_Load;
        }

        private void frmGanacias_Load(object sender, EventArgs e)
        {
            // Carga todo al abrir
            CargarGananciasTotales();       // 3 tarjetas (día, semana, mes)
            CargarGananciasPorCategoria();  // tabla izquierda
            CargarDetalleGanancias();
        }
        private decimal EscalarDecimal(string sql, params SqlParameter[] prms)
        {
            SqlConnection conexion = ConexionDB.Conectar();

            using (var cmd = new SqlCommand(sql, conexion))
            {
                if (prms != null) cmd.Parameters.AddRange(prms);
                object x = cmd.ExecuteScalar();
                if (x == null || x == DBNull.Value) return 0m;
                return Convert.ToDecimal(x);
            }
        }

        private DataTable Tabla(string sql, params SqlParameter[] prms)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var da = new SqlDataAdapter(sql, conexion))
            {
                if (prms != null) da.SelectCommand.Parameters.AddRange(prms);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ====== 1) Tarjetas: Día, Semana, Mes ======
        private void CargarGananciasTotales()
        {
            // Ganancia del DÍA (solo facturas pagadas)
            string qDia = @"
            SELECT ISNULL(SUM(subtotal),0)
            FROM detalleFactura
            WHERE estado = 1 AND CAST(fecha AS date) = CAST(GETDATE() AS date);";

            // Ganancia de la SEMANA (últimos 7 días incluyendo hoy)
            string qSem = @"
            SELECT ISNULL(SUM(subtotal),0)
            FROM detalleFactura
            WHERE estado = 1
              AND fecha >= DATEADD(day,-6, CAST(GETDATE() AS date))
              AND fecha <  DATEADD(day, 1, CAST(GETDATE() AS date));";

            // Ganancia del MES (mes actual)
            string qMes = @"
            SELECT ISNULL(SUM(subtotal),0)
            FROM detalleFactura
            WHERE estado = 1
              AND fecha >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
              AND fecha <  DATEADD(month,1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1));";

            lblResultadoDiarias.Text = EscalarDecimal(qDia).ToString("0.00");
            lblResultadoSemanal.Text = EscalarDecimal(qSem).ToString("0.00");
            lblResultadoMensual.Text = EscalarDecimal(qMes).ToString("0.00");
        }

        // ====== 2) Tabla: Ganancias por categoría (últimos 30 días) ======
        private void CargarGananciasPorCategoria()
        {
            string sql = @"
            SELECT c.nombreCat AS Categoria,
                   ISNULL(SUM(df.subtotal),0) AS Ganancia
            FROM detalleFactura df
            INNER JOIN Producto  p ON df.idProducto = p.idProducto
            INNER JOIN Categoria c ON p.idCategoria = c.idCategoria
            WHERE df.estado = 1
              AND df.fecha >= DATEADD(day,-30, CAST(GETDATE() AS date))
              AND df.fecha <  DATEADD(day, 1, CAST(GETDATE() AS date))
            GROUP BY c.nombreCat
            ORDER BY Ganancia DESC;";

            dgvGanancias.DataSource = Tabla(sql);
            dgvGanancias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ====== 3) Tabla: Detalle de ganancias (últimos 30 días) ======
        private void CargarDetalleGanancias()
        {
            string sql = @"
            SELECT 
                df.fecha      AS Fecha,
                cl.nombreCliente AS Cliente,
                p.nombreProduc  AS Producto,
                df.subtotal   AS Subtotal,
                CASE WHEN df.estado=1 THEN 'Pagada' ELSE 'Pendiente' END AS Estado
            FROM detalleFactura df
            INNER JOIN Cliente  cl ON df.idCliente = cl.idCliente
            INNER JOIN Producto p  ON df.idProducto = p.idProducto
            WHERE df.fecha >= DATEADD(day,-30, CAST(GETDATE() AS date))
              AND df.fecha <  DATEADD(day, 1, CAST(GETDATE() AS date))
            ORDER BY df.fecha DESC;";

            dgvDetalle.DataSource = Tabla(sql);
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
