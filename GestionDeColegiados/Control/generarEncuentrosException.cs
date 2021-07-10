using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    [Serializable]
    public class generarEncuentrosException:Exception
    {
        public generarEncuentrosException(string mensajeError):base(mensajeError)
        {

        }
    }
}
