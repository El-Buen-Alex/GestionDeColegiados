using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EncuentroDefinido
    {
        private int id;
        private int idEncuentroGeneradoPendiente;
        private int idColegiado;
        private DateTime fechaDeEncuentro;
        private string estado;

        public EncuentroDefinido(int idEncuentroGeneradoPendiente, int idColegiado, DateTime fechaDeEncuentro, string estado)
        {
            this.idEncuentroGeneradoPendiente = idEncuentroGeneradoPendiente;
            this.idColegiado = idColegiado;
            this.fechaDeEncuentro = fechaDeEncuentro;
            this.estado = estado;
        }

        public EncuentroDefinido(int id, int idEncuentroGeneradoPendiente, int idColegiado, DateTime fechaDeEncuentro, string estado)
        {
            this.id = id;
            this.idEncuentroGeneradoPendiente = idEncuentroGeneradoPendiente;
            this.idColegiado = idColegiado;
            this.fechaDeEncuentro = fechaDeEncuentro;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int IdEncuentroGeneradoPendiente { get => idEncuentroGeneradoPendiente; set => idEncuentroGeneradoPendiente = value; }
        public int IdColegiado { get => idColegiado; set => idColegiado = value; }
        public DateTime FechaDeEncuentro { get => fechaDeEncuentro; set => fechaDeEncuentro = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
