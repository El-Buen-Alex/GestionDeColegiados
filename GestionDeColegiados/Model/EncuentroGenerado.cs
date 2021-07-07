using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EncuentroGenerado
    {
        private int id;
        private int idEquipoLocal;
        private int idEquipoVisitante;
        private string estado;

        public EncuentroGenerado()
        {

        }
        public EncuentroGenerado(int idEquipoLocal, int idEquipoVisitante, string estado)
        {
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
            this.estado = estado;
        }
        public EncuentroGenerado(int id, int idEquipoLocal, int idEquipoVisitante, string estado)
        {
            this.id = id;
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int IdEquipoLocal { get => idEquipoLocal; set => idEquipoLocal = value; }
        public int IdEquipoVisitante { get => idEquipoVisitante; set => idEquipoVisitante = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
