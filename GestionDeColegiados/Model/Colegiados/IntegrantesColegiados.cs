namespace Model.Colegiados
{
    public class IntegrantesColegiados
    {
        private int idGrupoColegiado;
        private string nombrejuezCentral;
        private string nombreasistente1;
        private string nombreasistente2;
        private string nombrecuartoArbitro;

        public string NombrejuezCentral { get => nombrejuezCentral; set => nombrejuezCentral = value; }
        public string Nombreasistente1 { get => nombreasistente1; set => nombreasistente1 = value; }
        public string Nombreasistente2 { get => nombreasistente2; set => nombreasistente2 = value; }
        public string NombrecuartoArbitro { get => nombrecuartoArbitro; set => nombrecuartoArbitro = value; }
        public int IdGrupoColegiado { get => idGrupoColegiado; set => idGrupoColegiado = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
