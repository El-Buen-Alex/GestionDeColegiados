using Model;
using System;

namespace Control
{
    public class GestionLogin
    {
        private ConexionUsuarioBD gestionUsuario = new ConexionUsuarioBD();
        //metodo necesario para gestionar el intento de acceder a la aplicación
        public string controlLogin(string usuario, string password)
        {
            //creamos una cadena que ayudará a dar respuesta del proceso
            string respuesta = "";
            try
            {
                Administrador nuevoUsuario = obtenerUsuario(usuario, password);
                if (nuevoUsuario == null)
                {
                    //se lanza la excepcion
                    respuesta = "ERROR: ";
                    throw new usuarioNoRegistradoException(usuario);
                }
                else
                {
                    respuesta = nuevoUsuario.Rol;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                respuesta = "ERROR: "+ex.Message;
            }
            return respuesta;
        }

        public string CambiarPass(string newPass, int idUser)
        {
            string cambio = gestionUsuario.CambiarPassword(newPass, idUser);
            
            return cambio;
        }

        private Administrador obtenerUsuario(string username, string password)
        {
            ConexionUsuarioBD gestionUsuario = new ConexionUsuarioBD();
            Administrador usuario = null;
            //creamos una cadena que ayudará a dar respuesta del proceso
            string respuesta = "";
            try
            {
                usuario = gestionUsuario.ExisteUsuario(username.Trim(), password);

                if (usuario == null)
                {
                    //se lanza la excepcion
                    throw new usuarioNoRegistradoException(username);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                respuesta = ex.Message;
            }
            return usuario;
        }
        public int obtenerId(string usuario, string password)
        {
            Administrador user = obtenerUsuario(usuario, password);

            return user.Id;
        }

        public bool validarUltimoAcceso(string usuario, string password)
        {
            bool respuesta = true;
            Administrador admin = obtenerUsuario(usuario, password);
            if (String.IsNullOrEmpty(admin.PrimerAcceso))
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}
