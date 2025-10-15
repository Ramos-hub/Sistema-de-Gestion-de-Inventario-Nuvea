using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmSoporte : Form
    {
        // Rutas a los manuales 
        private readonly string rutaManualUsuario = Path.Combine(Application.StartupPath, "Manuales", "Manual_de_Usuario_Nuvea.pdf");
        private readonly string rutaManualTecnico = Path.Combine(Application.StartupPath, "Manuales", "Manual_Tecnico_Nuvea.pdf");

        public frmSoporte()
        {
            InitializeComponent();
            // Configurar textos de los LinkLabels
            lnkVerUsuario.Text = "Abrir Manual de Usuario";
            lnkDescargarUsuario.Text = "Descargar Manual de Usuario";
            lnkVerTecnico.Text = "Abrir Manual Técnico";
            lnkDescargarTecnico.Text = "Descargar Manual Técnico";
        }

        private void lnkVerUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirArchivo(rutaManualUsuario);
        }

        private void lnkDescargarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DescargarArchivo(rutaManualUsuario, "ManualUsuario.pdf");
        }

        private void lnkVerTecnico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirArchivo(rutaManualTecnico);
        }

        private void lnkDescargarTecnico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DescargarArchivo(rutaManualTecnico, "ManualTecnico.pdf");
        }

        private void AbrirArchivo(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    MessageBox.Show($"No se encontró el archivo:\n{ruta}", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el archivo.\n\nDetalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DescargarArchivo(string rutaOrigen, string nombreSugerido)
        {
            try
            {
                if (!File.Exists(rutaOrigen))
                {
                    MessageBox.Show($"No se encontró el archivo:\n{rutaOrigen}", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Title = "Guardar manual como...";
                    sfd.FileName = nombreSugerido;
                    sfd.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(rutaOrigen, sfd.FileName, true);
                        MessageBox.Show("Archivo guardado correctamente.", "Descarga completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo guardar el archivo.\n\nDetalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
