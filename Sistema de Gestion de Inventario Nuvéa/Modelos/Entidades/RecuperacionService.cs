using Modelo.Conexion;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Modelos.Entidades
{
    public class RecuperacionService
    {
        // clave aleatoria
        public string GenerarClave(int tam = 8)
        {
            string letras = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789!@#$%";
            Random r = new Random();
            return new string(Enumerable.Repeat(letras, tam).Select(s => s[r.Next(s.Length)]).ToArray());
        }

        // ver si el correo existe
        public bool ExisteCorreo(string correo)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE correo=@c", conexion))
            {
                cmd.Parameters.AddWithValue("@c", correo);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // actualizar clave con hash
        public void GuardarNuevaClave(string correo, string claveNueva)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(claveNueva);
            SqlConnection conexion = ConexionDB.Conectar();
            using (var cmd = new SqlCommand("UPDATE Usuario SET clave=@p WHERE correo=@c", conexion))
            {
                cmd.Parameters.AddWithValue("@p", hash);
                cmd.Parameters.AddWithValue("@c", correo);
                cmd.ExecuteNonQuery();
            }
        }

        // mandar correo por Gmail
        public void EnviarCorreo(string para, string claveNueva)
        {
            string user = "sistemadeinventarionuvea@gmail.com";
            string pass = "pqqh ejie fukv mvsq";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(user, "Soporte Nuvéa");
            mail.To.Add(para);
            mail.Subject = "Recuperación de contraseña";
            mail.Body = $"Tu nueva contraseña es: {claveNueva}\nCámbiala al entrar.";
            mail.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(user, pass);
            smtp.Send(mail);
        }
    }
}
