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
using Vistas.Formularios;

namespace Vistas.Formularios
{
    public partial class frmIndex: Form
    {
        public frmIndex()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmInicio_Load);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            CargarProductosBajoStock();
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
    }
}
