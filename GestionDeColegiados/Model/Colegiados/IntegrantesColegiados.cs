using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Colegiados {
    public class IntegrantesColegiados {
        private string nombrejuezCentral;
        private string nombreasistente1;
        private string nombreasistente2;
        private string nombrecuartoArbitro;

        public string NombrejuezCentral { get => nombrejuezCentral; set => nombrejuezCentral = value; }
        public string Nombreasistente1 { get => nombreasistente1; set => nombreasistente1 = value; }
        public string Nombreasistente2 { get => nombreasistente2; set => nombreasistente2 = value; }
        public string NombrecuartoArbitro { get => nombrecuartoArbitro; set => nombrecuartoArbitro = value; }

        public override string ToString () {
            return base.ToString();
        }
    }
}
