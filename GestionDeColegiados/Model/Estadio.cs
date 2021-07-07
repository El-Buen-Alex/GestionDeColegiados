using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Estadio
    {
        private int id;
        private string nombre;
        private string estado;

        public Estadio()
        {

        }
        public Estadio(int id, string nombre, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
