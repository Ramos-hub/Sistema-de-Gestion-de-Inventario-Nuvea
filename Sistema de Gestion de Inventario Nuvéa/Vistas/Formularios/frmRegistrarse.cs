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

namespace Vistas.Formularios
{
    public partial class frmRegistrarse: Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
            string claveHash = Rol.EncriptarContra(txtRegistrarseContra.Text);
            txtNumTel.KeyPress += (s, ev) =>
            {
                if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar))
                    ev.Handled = true;
            };
            txtNombreUsuarioRegis.ShortcutsEnabled = false;
            txtCorreoRegis.ShortcutsEnabled = false;
            txtRegistrarseContra.ShortcutsEnabled = false;
            txtNumTel.ShortcutsEnabled = false;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuarioRegis.Text;
            string correo = txtCorreoRegis.Text;
            string clave = txtRegistrarseContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave)) 
            {
                MessageBox.Show("Por favor ingrese todos los datos");
                return;
            }
            SqlConnection conexion = ConexionDB.Conectar();
            {
              string consultaQuery = "insert into Usuario (nombre, clave, correo) values (@nombre, @clave, @correo)";
              SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
              cmd.Parameters.AddWithValue("@nombre", usuario);
              cmd.Parameters.AddWithValue("@clave", clave);
              cmd.Parameters.AddWithValue("@correo", correo);
                    
              int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
               {
                 MessageBox.Show("¡Se ha registrado Exitosamente!");
                 new frmLogin().Show();
                 this.Hide();
               }
            else {
                MessageBox.Show("No se pudo crear su cuenta");
            }
              conexion.Close();
            }

            string usuarioEncri = txtNombreUsuarioRegis.Text.Trim();
            string correoEncri = txtCorreoRegis.Text.Trim();
            string claveEncri = txtRegistrarseContra.Text; 
            string numTel = txtNumTel.Text.Trim();
            string hash = Seguridad.CrearHash(clave);

            string sql = "INSERT INTO Usuario (idRol, nombre, clave, correo, telefono) " +
                         "VALUES (@rol, @nombre, @clave, @correo, @tel)";

            using (SqlConnection cn = ConexionDB.Conectar())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@rol", 2);           
                cmd.Parameters.AddWithValue("@nombre", usuario);
                cmd.Parameters.AddWithValue("@clave", hash);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@tel", numTel);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cuenta creada.");
            this.Close();
        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
