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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        void VerificarEmpresa()
        {

        }
        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            //Verificar si existen empresas registradas
            //si no existen 
            //abrir formulario frmPrimerUso
            //si existe empresa
            //Verificar si existen usuarios
            //si existen muestra FrmLogin
            //No existen muestra formulario primer usuario
        }
    }
}
