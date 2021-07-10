using System;

namespace Control
{
    [Serializable]
    public class registroEquipoMaximoException : Exception
    {
        public string nombreEquipo { get; }
        public registroEquipoMaximoException(string mensaje) : base(mensaje)
        {

        }
        public registroEquipoMaximoException(string mensaje, Exception inner)
        : base(mensaje, inner) { }

        public registroEquipoMaximoException(string mensaje, string nombreEquipo)
            : this(mensaje)
        {
            this.nombreEquipo = nombreEquipo;
        }
    }
}
