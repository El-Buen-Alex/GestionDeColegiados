﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema
{
    class ConexionBD
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "presidente";
            string password = "1234presi5";
            string bd = "campeonatos";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}