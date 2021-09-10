using System;

namespace Model.Equipo
{
    /// <summary>
    /// Clase Equipo
    /// </summary>
    public class Equipo
    {/// <summary>
    /// Atributos privados de la clase Equipo
    /// </summary>
        private int idEquipo;
        private String nombreEquipo;
        private int numeroJugadores;
        private String nombreDirectoTecnico;
        private String presidenteEquipo;
        /// <summary>
        /// COnstructor por defecto
        /// </summary>
        public Equipo()
        {
        }
        /// <summary>
        /// Constructor sin el id del equipo
        /// </summary>
        /// <param name="nombreEquipo">Nombre del equipo</param>
        /// <param name="numeroJugadores">Numero de jugadores</param>
        /// <param name="nombreDirectoTecnico">Nombre del director Técnico del equipo</param>
        /// <param name="presidenteEquipo">Presidente del equipo</param>
        public Equipo(string nombreEquipo, int numeroJugadores, string nombreDirectoTecnico, string presidenteEquipo)
        {
            this.nombreEquipo = nombreEquipo;
            this.numeroJugadores = numeroJugadores;
            this.nombreDirectoTecnico = nombreDirectoTecnico;
            this.presidenteEquipo = presidenteEquipo;
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="idEquipo">Identificador del equipo</param>
        /// <param name="nombreEquipo">Nombre del equipo</param>
        /// <param name="numeroJugadores">Numero de jugadores</param>
        /// <param name="nombreDirectoTecnico">Nombre del director Técnico del equipo</param>
        /// <param name="presidenteEquipo">Presidente del equipo</param>
        public Equipo(int idEquipo, string nombreEquipo, int numeroJugadores, string nombreDirectoTecnico, string presidenteEquipo)
        {
            this.idEquipo = idEquipo;
            this.nombreEquipo = nombreEquipo;
            this.numeroJugadores = numeroJugadores;
            this.nombreDirectoTecnico = nombreDirectoTecnico;
            this.presidenteEquipo = presidenteEquipo;
        }
        /// <summary>
        /// Métodos getter y setter de los atributos de clase
        /// </summary>
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
