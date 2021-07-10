using System;

namespace Control
{
    [Serializable]
    public class ErrorActualizarEstadioException : Exception
    {
        public ErrorActualizarEstadioException(string ubicacion) : base(ubicacion + ": No se logró Actualizar El ID del estadio")
        {

        }
        public ErrorActualizarEstadioException() : base("No se logró Actualizar El ID del estadio")
        {

        }
    }
}
