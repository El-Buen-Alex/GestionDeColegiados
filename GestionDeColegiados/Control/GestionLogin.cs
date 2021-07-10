using Model;

namespace Control
{
    public class GestionLogin
    {

        //metodo necesario para gestionar el intento de acceder a la aplicación
        public void controlLogin(string usuario, string password)
        {
            //creamos un objeto que nos ayudará a gestionar la conexion
            ConexionUsuarioBD gestionUsuario = new ConexionUsuarioBD();
            Administrador nuevoUsuario = null;

            nuevoUsuario = gestionUsuario.ExisteUsuario(usuario, password);

            if (nuevoUsuario == null)
            {
                throw new usuarioNoRegistradoException(usuario);
            }
        }
    }
}
