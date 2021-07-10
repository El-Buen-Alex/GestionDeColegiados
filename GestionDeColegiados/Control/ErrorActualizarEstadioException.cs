using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    [Serializable]
    public class ErrorActualizarEstadioException:Exception
    {
        public ErrorActualizarEstadioException(string ubicacion):base(ubicacion+ ": No se logró Actualizar El ID del estadio")
        {

        }
        public ErrorActualizarEstadioException() : base("No se logró Actualizar El ID del estadio")
        {

        }
    }
}
