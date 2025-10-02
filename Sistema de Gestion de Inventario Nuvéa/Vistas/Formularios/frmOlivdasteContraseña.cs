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
using Modelos.Entidades;
using System.Configuration;

namespace Vistas.Formularios
{
    public partial class frmOlivdasteContraseña : Form
    {
        private readonly RecuperacionService rec = new RecuperacionService();

        // flag para controlar si ya se está enviando
        private bool enviando = false;

        public frmOlivdasteContraseña()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (enviando) return; // si ya está enviando, no hace nada
            enviando = true;      // activo el flag
            btnEnviarCorreo.Enabled = false; // desactivo el botón

            string correo = txtCorreoRecu.Text.Trim(); // agarro el correo del textbox

            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Poné tu correo primero 😅", "Recuperar");
                enviando = false;
                btnEnviarCorreo.Enabled = true;
                return;
            }

            try
            {
                // primero reviso si ese correo existe en la base de datos
                if (!rec.ExisteCorreo(correo))
                {
                    MessageBox.Show("Si el correo está registrado, te mandaremos una nueva clave 😉", "Recuperar");
                    return;
                }

                // genero una clave nueva de 8 caracteres
                string nuevaClave = rec.GenerarClave(8);

                // la guardo en la base (con hash)
                rec.GuardarNuevaClave(correo, nuevaClave);

                // mando el correo con la clave nueva
                rec.EnviarCorreo(correo, nuevaClave);

                // aviso en la pantalla
                lblInfo.Text = "¡Listo! revisa tu correo 📧";
                MessageBox.Show("Te mandamos la nueva clave a tu correo ✨", "Recuperar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Recuperar");
            }
        }
    }
}
