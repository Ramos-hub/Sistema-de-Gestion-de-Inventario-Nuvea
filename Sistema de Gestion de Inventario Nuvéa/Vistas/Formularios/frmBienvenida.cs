using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Modelos.Entidades;



namespace Vistas.Formularios
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }
        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrimerUso_Click(object sender, EventArgs e)
        {
            bool respuesta = ModeloPrimerUsuario.VerificacionEmpleados();
            if (respuesta == true)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
            else
            {
                frmPrimerUso frm = new frmPrimerUso();
                frm.Show();
                this.Hide();
            }
        }
        //else
        //{
        //    //frmPrimerUso nextForm = new frmPrimerUso();
        //    //nextForm.Show();
        //    //this.Hide();
        //}
    }
}
