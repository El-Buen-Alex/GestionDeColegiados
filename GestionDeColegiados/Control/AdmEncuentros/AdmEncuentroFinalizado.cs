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

        public bool LlenarDgv(DataGridView dgvCompeticion)
        {
            bool respuesta = false ;
            string anio = "" + DateTime.Now.Year;
            encuentrosFinalizados = datosEncuentroFinalizado.GetEncuentrosFinalizados(anio);
            if (encuentrosFinalizados.Count > 0)
            {
                int posicion = 1;
                foreach (EncuentroFinalizado encuentro in encuentrosFinalizados)
                {
                    string nombreEquipo = admEquipos.ObtenerEquipoPorId(encuentro.IdEquipo).NombreEquipo;
                    dgvCompeticion.Rows.Add(posicion, nombreEquipo, encuentro.GolesFavor, encuentro.GolesContra, encuentro.GolesDiferencia, encuentro.Puntos);
                    posicion++;
                }
                respuesta = true;
            }
            return respuesta;
        }
        private int CalcularPuntosVisitante(int puntos)
        {
            int puntosVisitante = 0;
            if (puntos == 0)
            {
                puntosVisitante = 3;
            }else if (puntos == 1)
            {
                puntosVisitante = 1;
            }else if (puntos == 3)
            {
                puntosVisitante = 0;
            }
            return puntosVisitante;
        }
        public void LlenarInformacionPartido(int index, TextBox txtGolesLocal, TextBox txtGolesVisitante, Label lblPuntosLocalResultado, Label lblPuntosVisitanteResultado)
        {
            EncuentroDefinido encuentroDefinido = admEncuentrosDefinidos.GetEncuentroDefinidoByIndex(index);
            EncuentroGenerado encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(encuentroDefinido.IdEncuentroGeneradoPendiente);
            EncuentroFinalizado encuentroFinalizado = datosEncuentroFinalizado.GetEncuentroFinalizadoByIDefinidoEquipo(encuentroDefinido.Id, encuentroGenerado.IdEquipoLocal);
            txtGolesLocal.Text = encuentroFinalizado.GolesFavor.ToString();
            txtGolesVisitante.Text = encuentroFinalizado.GolesContra.ToString();
            int puntosLocal = encuentroFinalizado.Puntos;
            lblPuntosLocalResultado.Text = puntosLocal.ToString();
            lblPuntosVisitanteResultado.Text = CalcularPuntosVisitante(puntosLocal).ToString();
        }
        private EncuentroFinalizado GetEncuentro(int idEquipo, int idDefinido, string golesFavor, string golesContra)
        {
            
            Equipo equipo = admEquipos.ObtenerEquipoPorId(idEquipo);
            
            int golAFavor = validaciones.AInt(golesFavor);
            int golEnContra = validaciones.AInt(golesContra);
            return new EncuentroFinalizado(equipo.IdEquipo, golAFavor, golEnContra, idDefinido);

        }
        public bool UpdateEncuentroFinalizado(int index, string golesLocal, string golesVisitante)
        {
            bool respuesta = false;

            EncuentroDefinido encuentroDefinido = admEncuentrosDefinidos.ListaEncuentrosDefinidos[index];
            EncuentroGenerado encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(encuentroDefinido.IdEncuentroGeneradoPendiente);


            EncuentroFinalizado encuentroResultadoLocal = GetEncuentro(encuentroGenerado.IdEquipoLocal, encuentroDefinido.Id, golesLocal, golesVisitante);
            EncuentroFinalizado encuentroResultadoVisitante = GetEncuentro(encuentroGenerado.IdEquipoVisitante, encuentroDefinido.Id, golesVisitante, golesLocal);
            
            respuesta = datosEncuentroFinalizado.UpdateEncuentroFinalizado(encuentroResultadoLocal);
            if (respuesta)
            {
                respuesta = datosEncuentroFinalizado.UpdateEncuentroFinalizado(encuentroResultadoVisitante);
            }
            return respuesta;
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

        public int GetCantidadEncuentrosFinalizados()
        {
            string anio = DateTime.Now.Year.ToString();
            int cantidad= datosEncuentroFinalizado.GetCantidadEncuentrosFinalizados(anio);
            if (cantidad < 0)
            {

            }
            return cantidad;
        }
    }
}
