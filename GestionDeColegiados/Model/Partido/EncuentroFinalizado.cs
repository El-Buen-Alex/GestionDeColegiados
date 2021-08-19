﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Partido
{
    public class EncuentroFinalizado
    {
        private int id;
        private int golesFavor;
        private int golesContra;
        private int golesDiferencia;
        private int puntos;
        private int idEquipo;
        private string copa;
        private string estado;

        public EncuentroFinalizado()
        {
           
        }

        private int CalcularPuntos(int golFavor, int golContra)
        {
            int puntos = 0;
            if (golFavor > golContra)
            {
                puntos = 3;
            }
            else if (golFavor < golContra)
            {
                puntos = 0;
            }
            else if (golFavor == golContra)
            {
                puntos = 1;
            }

            return puntos;
        }
        public EncuentroFinalizado(int idEquipo, int golFavor, int golContra)
        {
            this.idEquipo = idEquipo;
            this.GolesFavor = golFavor;
            this.GolesContra = golContra;
            this.golesDiferencia = this.GolesFavor - this.GolesContra;
            CalcularPuntos(golFavor, golContra);
        }

        public EncuentroFinalizado( int golesFavor, int golesContra,
           int golesDiferencia, int puntos, int idEquipo, string copa, string estado )
        {
            this.id = 0;
            this.golesFavor = golesFavor;
            this.golesContra = golesContra;
            this.golesDiferencia = golesDiferencia;
            this.puntos = puntos;
            this.idEquipo = idEquipo;
            this.copa = copa;
            this.estado = estado;
            this.golesDiferencia = this.GolesFavor - this.GolesContra;
        }

        public EncuentroFinalizado(int id, int golesFavor, int golesContra,
            int golesDiferencia, int puntos, int idEquipo, string copa, string estado)
        {
            this.id = id;
            this.golesFavor = golesFavor;
            this.golesContra = golesContra;
            this.golesDiferencia = golesDiferencia;
            this.puntos = puntos;
            this.idEquipo = idEquipo;
            this.copa = copa;
            this.estado = estado;
            this.golesDiferencia = this.GolesFavor - this.GolesContra;
        }

        public int Id { get => id; set => id = value; }

        public int GolesFavor { get => golesFavor; set => golesFavor = value; }

        public int GolesContra { get => golesContra; set => golesContra = value; }

        public int GolesDiferencia { get => golesDiferencia; set => golesDiferencia = value; }

        public int Puntos { get => puntos; set => puntos = value; }

        public int IdEquipo { get => idEquipo; set => idEquipo = value; }

        public string Copa { get => copa; set => copa = value; }

        public string Estado { get => estado; set => estado = value; }

    }
}
