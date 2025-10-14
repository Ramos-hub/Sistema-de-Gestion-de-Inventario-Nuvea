﻿using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
     public class Usuario
    {
        public int idUsuario;
        public int idRol;
        public string nombre;
        public string clave;
        public string correo;
        public string telefono;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public static DataTable cargarUsuario()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select nombre, nombreRol, clave, Correo, Telefono From Usuario";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
