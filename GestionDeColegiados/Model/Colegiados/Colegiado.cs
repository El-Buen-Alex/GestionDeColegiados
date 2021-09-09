namespace Model.Colegiados
{
    /// <summary>
    /// Clase Colegiado que va a registrar los id de los arbitros.
    /// </summary>
    public class Colegiado
    {
        private int idcolegiado;
        private int idjuezcentral;
        private int idasistente1;
        private int idasistente2;
        private int idcuartoarbitro;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Colegiado () {
        }

        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="idcolegiado">ID de colegiado.</param>
        /// <param name="idjuezcentral">ID de Juez Central.</param>
        /// <param name="idasistente1">ID de Asistente 1.</param>
        /// <param name="idasistente2">ID de Asistente 2.</param>
        /// <param name="idcuartoarbitro">ID de Cuarto Arbitro.</param>
        public Colegiado (int idcolegiado, int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro)
        {
            this.idcolegiado = idcolegiado;
            this.idjuezcentral = idjuezcentral;
            this.idasistente1 = idasistente1;
            this.idasistente2 = idasistente2;
            this.idcuartoarbitro = idcuartoarbitro;
        }

        /// <summary>
        /// Métodos Getter y Setter de los atributos de colegiado.
        /// </summary>
        public int Idcolegiado { get => idcolegiado; set => idcolegiado = value; }
        public int Idjuezcentral { get => idjuezcentral; set => idjuezcentral = value; }
        public int Idasistente1 { get => idasistente1; set => idasistente1 = value; }
        public int Idasistente2 { get => idasistente2; set => idasistente2 = value; }
        public int Idcuartoarbitro { get => idcuartoarbitro; set => idcuartoarbitro = value; }

        /// <summary>
        /// Método que “convierte” el objeto a mostrar en texto.
        /// </summary>
        /// <returns>Devuelve una cadena de texto.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}