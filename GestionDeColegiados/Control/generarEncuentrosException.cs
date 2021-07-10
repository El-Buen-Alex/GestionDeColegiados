using System;

namespace Control
{
    [Serializable]
    public class generarEncuentrosException : Exception
    {
        public generarEncuentrosException(string mensajeError) : base(mensajeError)
        {

        }
    }
}
