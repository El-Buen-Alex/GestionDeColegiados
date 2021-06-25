using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Colegiados {
    public class Colegiado {
        private int idcolegiado;
        private int idjuezcentral;
        private int idasistente1;
        private int idasistente2;
        private int idcuartoarbitro;

        public int Idcolegiado { get => idcolegiado; set => idcolegiado = value; }
        public int Idjuezcentral { get => idjuezcentral; set => idjuezcentral = value; }
        public int Idasistente1 { get => idasistente1; set => idasistente1 = value; }
        public int Idasistente2 { get => idasistente2; set => idasistente2 = value; }
        public int Idcuartoarbitro { get => idcuartoarbitro; set => idcuartoarbitro = value; }

        public Colegiado (int idcolegiado, int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro) {
            this.idcolegiado = idcolegiado;
            this.idjuezcentral = idjuezcentral;
            this.idasistente1 = idasistente1;
            this.idasistente2 = idasistente2;
            this.idcuartoarbitro = idcuartoarbitro;
        }

        public override string ToString () {
            return base.ToString();
        }
    }
}
