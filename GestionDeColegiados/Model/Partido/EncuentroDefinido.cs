using System;

namespace Model
{
    public class EncuentroDefinido
    {
        private int id;
        private int idEncuentroGeneradoPendiente;
        private int idColegiado;
        private DateTime fechaDeEncuentro;
        private DateTime hora;
        private string estado;
        private int idEstadio;

        public EncuentroDefinido()
        {

        }
        public EncuentroDefinido(int idEncuentroGeneradoPendiente, int idColegiado, DateTime fechaDeEncuentro, DateTime hora, int idEStadio)
        {
            this.idEncuentroGeneradoPendiente = idEncuentroGeneradoPendiente;
            this.idColegiado = idColegiado;
            this.fechaDeEncuentro = fechaDeEncuentro;
            this.hora = hora;
            this.idEstadio = idEStadio;
        }
        public EncuentroDefinido(int idEncuentroGeneradoPendiente, int idColegiado, DateTime fechaDeEncuentro, string estado, DateTime hora, int idEStadio)
        {
            this.idEncuentroGeneradoPendiente = idEncuentroGeneradoPendiente;
            this.idColegiado = idColegiado;
            this.fechaDeEncuentro = fechaDeEncuentro;
            this.estado = estado;
            this.hora = hora;
            this.idEstadio = idEStadio;
        }

        public EncuentroDefinido(int id, int idEncuentroGeneradoPendiente, int idColegiado, DateTime fechaDeEncuentro, string estado, DateTime hora, int idEStadio)
        {
            this.id = id;
            this.idEncuentroGeneradoPendiente = idEncuentroGeneradoPendiente;
            this.idColegiado = idColegiado;
            this.fechaDeEncuentro = fechaDeEncuentro;
            this.estado = estado;
            this.hora = hora;
            this.idEstadio = idEStadio;
        }

        public int Id { get => id; set => id = value; }
        public int IdEncuentroGeneradoPendiente { get => idEncuentroGeneradoPendiente; set => idEncuentroGeneradoPendiente = value; }
        public int IdColegiado { get => idColegiado; set => idColegiado = value; }
        public DateTime FechaDeEncuentro { get => fechaDeEncuentro; set => fechaDeEncuentro = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public int IdEstadio { get => idEstadio; set => idEstadio = value; }
    }
}
