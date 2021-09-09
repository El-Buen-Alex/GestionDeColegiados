namespace Model.Colegiados
{
    /// <summary>
    /// Clase <c>IntegrantesColegiados</c> para obtener nombre de los arbitros registrados.
    /// </summary>
    public class IntegrantesColegiados
    {
        private int idGrupoColegiado;
        private string nombrejuezCentral;
        private string nombreasistente1;
        private string nombreasistente2;
        private string nombrecuartoArbitro;

        /// <summary>
        /// Métodos Getter y Setter de los atributos de <c>IntegrantesColegiados</c>.
        /// </summary>
        public string NombrejuezCentral { get => nombrejuezCentral; set => nombrejuezCentral = value; }
        public string Nombreasistente1 { get => nombreasistente1; set => nombreasistente1 = value; }
        public string Nombreasistente2 { get => nombreasistente2; set => nombreasistente2 = value; }
        public string NombrecuartoArbitro { get => nombrecuartoArbitro; set => nombrecuartoArbitro = value; }
        public int IdGrupoColegiado { get => idGrupoColegiado; set => idGrupoColegiado = value; }

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