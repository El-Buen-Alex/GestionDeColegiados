using System;

namespace Control
{
    [Serializable]
    public class usuarioNoRegistradoException : Exception
    {

        public usuarioNoRegistradoException(string usuario) : base("El usuario y/o contraseña son incorrectos")
        {

        }
        public usuarioNoRegistradoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }

    }
}
