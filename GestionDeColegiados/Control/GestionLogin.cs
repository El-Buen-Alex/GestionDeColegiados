using Model;
using System;

namespace Control
{
    public class GestionLogin
    {

        //metodo necesario para gestionar el intento de acceder a la aplicación
        public string controlLogin(string usuario, string password)
        {
            //creamos un objeto que nos ayudará a gestionar la conexion
            ConexionUsuarioBD gestionUsuario = new ConexionUsuarioBD();
            Administrador nuevoUsuario = null;
            //creamos una cadena que ayudará a dar respuesta del proceso
            string respuesta = "";
            try
            {
                nuevoUsuario = gestionUsuario.ExisteUsuario(usuario.Trim(), password);

                if (nuevoUsuario == null)
                {
                    //se lanza la excepcion
                    throw new usuarioNoRegistradoException(usuario);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                respuesta = ex.Message;
            }
            return respuesta;
        }
    }
}
