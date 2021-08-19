using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control.AdmEncuentrosGenerados;
using Control.AdmEquipos;
using Model;
using Model.Equipo;
using Model.Partido;
using Data;

namespace Control.AdmEncuentros
{
    public class AdmEncuentroFinalizado
    {
        private static AdmEncuentroFinalizado admEncuentroFinalizado = null;
        private List<EncuentroFinalizado> encuentrosFinalizados;
        private AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmGenerarEncuentros admEncuentrosGenerados = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEquipo admEquipos = AdmEquipo.getEquipo();
        private ValidacionGUI validaciones = new ValidacionGUI();
        private DatosEncuentroFinalizado datosEncuentroFinalizado = new DatosEncuentroFinalizado();
        
        private AdmEncuentroFinalizado()
        {
            encuentrosFinalizados = new List<EncuentroFinalizado>();
        }

        public static AdmEncuentroFinalizado GetAdmEncuentrosFinalizados()
        {
            if(admEncuentroFinalizado == null)
            {
                admEncuentroFinalizado = new AdmEncuentroFinalizado();
            }

            return admEncuentroFinalizado;
        }


        public bool GuardarEncuentroFinalizado(int index, string golesLocal, string golesVisitante)
        {
            bool guardado= true;

            EncuentroDefinido encuentroDefinido = admEncuentrosDefinidos.ListaEncuentrosDefinidos[index];
            EncuentroGenerado encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(encuentroDefinido.IdEncuentroGeneradoPendiente);

            Equipo equipoLocal = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
            Equipo equipoVisitante= admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);

            int golLocal = validaciones.AInt(golesLocal);
            int golVisitante = validaciones.AInt(golesVisitante);

            EncuentroFinalizado encuentroResultadoLocal= new EncuentroFinalizado(equipoLocal.IdEquipo,golLocal, golVisitante);
            EncuentroFinalizado encuentroResultadoVisitante = new EncuentroFinalizado(equipoVisitante.IdEquipo, golVisitante, golLocal);

            bool guardo = datosEncuentroFinalizado.AddEncuentroFinalizado(encuentroResultadoLocal);
            if (guardo)
            {
                guardado = datosEncuentroFinalizado.AddEncuentroFinalizado(encuentroResultadoVisitante);
            }

            return guardado;
        }
    }
}
