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
using System.Windows.Forms;

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

        public void LlenarDgv(DataGridView dgvCompeticion)
        {
            string anio = "" + DateTime.Now.Year;
            encuentrosFinalizados = datosEncuentroFinalizado.GetEncuentrosFinalizados(anio);
            int posicion= 1;
            foreach (EncuentroFinalizado encuentro in encuentrosFinalizados)
            {
                string nombreEquipo = admEquipos.ObtenerEquipoPorId(encuentro.IdEquipo).NombreEquipo;
                dgvCompeticion.Rows.Add(posicion, nombreEquipo, encuentro.GolesFavor, encuentro.GolesContra, encuentro.GolesDiferencia, encuentro.Puntos );
                posicion++;
            }
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

            EncuentroFinalizado encuentroResultadoLocal= new EncuentroFinalizado(equipoLocal.IdEquipo,golLocal, golVisitante, encuentroDefinido.Id);
            EncuentroFinalizado encuentroResultadoVisitante = new EncuentroFinalizado(equipoVisitante.IdEquipo, golVisitante, golLocal, encuentroDefinido.Id);

            bool guardo = datosEncuentroFinalizado.AddEncuentroFinalizado(encuentroResultadoLocal);
            if (guardo)
            {
                guardado = datosEncuentroFinalizado.AddEncuentroFinalizado(encuentroResultadoVisitante);
            }

            return guardado;
        }

        public void CalcularPuntos(Label lblPuntos, string golFavor, string golContra)
        {
            if(!String.IsNullOrEmpty(golFavor) && !String.IsNullOrEmpty(golContra))
            {
                int gFavor = validaciones.AInt(golFavor);
                int gContra = validaciones.AInt(golContra);
                lblPuntos.Text = "" + puntos(gFavor, gContra);
            }
        }
        private int puntos(int golFavor, int golContra)
        {
            int respuesta = 0;
            if (golContra == golFavor)
            {
                respuesta = 1;
            }else if (golFavor > golContra)
            {
                respuesta = 3;
            }else if(golFavor < golContra)
            {
                respuesta = 0;
            }
            return respuesta;
        }
    }
}
