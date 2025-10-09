using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //Verificar si existen empresas registradas
            PrimerUsoControler objprimer = new PrimerUsoControler();
            bool respuesta = objprimer.VerificarEmpresa();
            if (respuesta == true)
            {

                //si no existen 
                //abrir formulario frmPrimerUso
                //si existe empresa
                //Verificar si existen usuarios
                //si existen muestra FrmLogin
                //No existen muestra formulario primer usuario
            }
            else
            {
                frmPrimerUso nextForm = new frmPrimerUso();
                nextForm.Show();
                this.Hide();
            }

        }
    }
}
