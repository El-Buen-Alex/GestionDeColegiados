using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Equipo
{
    public class Equipo
    {
        private int idEquipo;
        private String nombreEquipo;
        private int numeroJugadores;
        private String nombreDirectoTecnico;
        private String presidenteEquipo;

        public Equipo()
        {
        }

        public Equipo(string nombreEquipo, int numeroJugadores, string nombreDirectoTecnico, string presidenteEquipo)
        {
            this.nombreEquipo = nombreEquipo;
            this.numeroJugadores = numeroJugadores;
            this.nombreDirectoTecnico = nombreDirectoTecnico;
            this.presidenteEquipo = presidenteEquipo;
        }

        public Equipo(int idEquipo, string nombreEquipo, int numeroJugadores, string nombreDirectoTecnico, string presidenteEquipo)
        {
            this.idEquipo = idEquipo;
            this.nombreEquipo = nombreEquipo;
            this.numeroJugadores = numeroJugadores;
            this.nombreDirectoTecnico = nombreDirectoTecnico;
            this.presidenteEquipo = presidenteEquipo;
        }

        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public int NumeroJugadores { get => numeroJugadores; set => numeroJugadores = value; }
        public string NombreDirectoTecnico { get => nombreDirectoTecnico; set => nombreDirectoTecnico = value; }
        public string PresidenteEquipo { get => presidenteEquipo; set => presidenteEquipo = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
