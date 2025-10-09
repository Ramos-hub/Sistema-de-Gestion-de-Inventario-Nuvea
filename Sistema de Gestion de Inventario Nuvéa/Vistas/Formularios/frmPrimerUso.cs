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
    public partial class frmPrimerUso : Form
    {
        public frmPrimerUso()
        {
            InitializeComponent();
        }

        private void btnExaminarUso_Click(object sender, EventArgs e)
        {
            try
            {
                //Definimos los tipos de archivo que se colocaran en el sistema
                openFileDialog1.Filter = "Archivos de Imagen .jpg | *.jpg | Archivos de imagen .png |*.png| Archivos de imagen .jpeg |*.jpeg| Todos los archivos |*.*";
                //Mostramos cuadro de dialogo
                DialogResult resultado = openFileDialog1.ShowDialog();
                //Cuando se de click en OK o abrir en el cuadro de Dialogo la imagen seleccionada se colocara sobre el pictureBox llamado pbLogoUso
                if (resultado == DialogResult.OK)
                {
                    pbLogoUso.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                //error al cargar la imagen
                MessageBox.Show("Ocurrio un erro al cargar la imagen, verifique el nombre de extensión del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
