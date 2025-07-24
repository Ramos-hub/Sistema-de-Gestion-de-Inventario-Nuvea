using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region "Metodo para activar Formularios"

        private Form activarForm = null;
        //Metodo que me permitira activar los formularios
        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }


        #endregion

        private void btnIniciInventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmIndex());
        }

        private void btnFacturacionInventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmFacturacion());
        }

        public void btn_Inventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInventario());
        }

        private void btnInventarioProveedores_Click(object sender, EventArgs e)
        {
            abrirForm(new frmProveedores());
        }

        private void btnInventarioHistorial_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHistorialFacturas());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            abrirForm(new frmGanacias());
        }
    }
}
