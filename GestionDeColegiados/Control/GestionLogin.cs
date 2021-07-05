using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control
{
    public class GestionLogin
    {

        //metodo necesario para gestionar el intento de acceder a la aplicación
        public string controlLogin(string usuario, string password)
        {
            //creamos un objeto que nos ayudará a gestionar la conexion
            ConexionUsuarioBD gestionUsuario = new ConexionUsuarioBD();
            //variable creada para posteriormente almacenar el resultado del intento de login
            string respuesta = "";
            Administrador nuevoUsuario = null;


            nuevoUsuario = gestionUsuario.ExisteUsuario(usuario, password);

            if (nuevoUsuario == null)
            {
                throw new usuarioNoRegistradoException("El usuario: " + usuario + " no está registrado en el sistema");
            }         
            return respuesta;
        }
    }
}
