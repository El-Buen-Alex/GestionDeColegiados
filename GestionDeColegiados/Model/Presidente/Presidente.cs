﻿using System;

namespace Model
{
    public class Administrador
    {
        private int id;
        private string password, nombre, rol, ultimoAcceso;

        public int Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password1 { get => password; set => password = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public string UltimoAcceso { get => ultimoAcceso; set => ultimoAcceso = value; }
    }
}
