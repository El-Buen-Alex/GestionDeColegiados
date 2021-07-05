using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    [Serializable]
    public class usuarioNoRegistradoException : Exception
    {

        public usuarioNoRegistradoException(string usuario):base("El usuario:-- " + usuario+" --no se encuentra registrado en el sistema")
        {
            
        }
        public usuarioNoRegistradoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }

    }
}
