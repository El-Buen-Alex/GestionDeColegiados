using Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control.AdmColegiados;

namespace Control.AdmEncuentrosGenerados
{
    public class AdmEncuentrosDefinidos
    {
        public static AdmEncuentrosDefinidos admGenerarEncuentrosDefinidos = null;
        private List<EncuentroDefinido> listaEncuentrosDefinidos;
        private List<EncuentroGenerado> listaEncuentrosGenerados;
        private DatosEncuentroDefinido datosEncuentroDefinido = new DatosEncuentroDefinido();
        private AdmGenerarEncuentros admEncuentrosGenerados = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmColegiado admColegiados = AdmColegiado.getAdmCol();
        private AdmEncuentrosDefinidos()
        {
            listaEncuentrosDefinidos = new List<EncuentroDefinido>();
        }

        public List<EncuentroDefinido> ListaEncuentrosDefinidos { get => listaEncuentrosDefinidos; set => listaEncuentrosDefinidos = value; }

        public static AdmEncuentrosDefinidos GetAdmGenerarEncuentrosDefinidos()
        {
            if (admGenerarEncuentrosDefinidos == null)
            {
                admGenerarEncuentrosDefinidos = new AdmEncuentrosDefinidos();
            }
            return admGenerarEncuentrosDefinidos;
        }

        public bool GuardarEncuentroDefinido(int grupoColegiado, DateTime fechaPartido)
        {
            bool guardo = false;
            int idEncuentroGeneradoPendiente = admEncuentrosGenerados.ListaEncuentrosGeneradosPendientes[0].Id;
            int idColegiado = admColegiados.ListaintegColeg[grupoColegiado].IdGrupoColegiado;
            EncuentroDefinido encuentroDefinido = new EncuentroDefinido(idEncuentroGeneradoPendiente, idColegiado, fechaPartido, "PorJugar");
            int id = datosEncuentroDefinido.GuardarEncuentroDefinido(encuentroDefinido);
            if (id != 0)
            {
               bool cambiarEstado= admEncuentrosGenerados.CambiarEstadoEncuentro(idEncuentroGeneradoPendiente);
                if (cambiarEstado)
                {
                    guardo = true;
                }
            }
            return guardo;
        }
    }
}
