using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas.Formularios
{
    public partial class frmIndex: Form
    {
        public frmIndex()
        {
            InitializeComponent();
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
          
           frmInventario fi = new frmInventario();
            fi.StartPosition = FormStartPosition.CenterScreen;
            fi.Show();
           

        }
    }
}
