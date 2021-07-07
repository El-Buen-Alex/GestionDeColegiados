using Model;
using Data;
using Model.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control.AdmColegiados;
using Control.AdmEstadios;
using System.Windows.Forms;
using Control.AdmEquipos;

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
        private AdmEquipo admEquipos = AdmEquipo.getEquipo();
      
        public void LlenarPartidosCmb(ComboBox cmbEncuentros)
        {
            
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            listaEncuentrosGenerados = new List<EncuentroGenerado>();
            EncuentroGenerado encuentroGenerado;
            Equipo local, visitante;
            for (int x=0;x < listaEncuentrosDefinidos.Count; x++)
            {
                encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(listaEncuentrosDefinidos[x].IdEncuentroGeneradoPendiente);
                local = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
                visitante = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);
                cmbEncuentros.Items.Add("1: " + local.NombreEquipo + " VS " + visitante.NombreEquipo);
                listaEncuentrosGenerados.Add(encuentroGenerado);
            }
        }

        private AdmEstadio admEstadio = AdmEstadio.GetAdmEstadio();
        
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

        public bool GuardarEncuentroDefinido(int grupoColegiado, DateTime fechaPartido, DateTime horaPartido, int estadioSeleccionado)
        {
            bool guardo = false;
            int idEncuentroGeneradoPendiente = admEncuentrosGenerados.ListaEncuentrosGeneradosPendientes[0].Id;
            int idColegiado = admColegiados.ListaintegColeg[grupoColegiado].IdGrupoColegiado;
            int idEsadio = admEstadio.ListaEstadiosDisponibles[estadioSeleccionado].Id;
            EncuentroDefinido encuentroDefinido = new EncuentroDefinido(idEncuentroGeneradoPendiente, idColegiado, fechaPartido, "PorJugar", horaPartido, idEsadio);
            int id = datosEncuentroDefinido.GuardarEncuentroDefinido(encuentroDefinido);
            if (id != 0)
            {
               
               bool cambiarEstado= admEncuentrosGenerados.CambiarEstadoEncuentro(idEncuentroGeneradoPendiente);
                if (cambiarEstado)
                {
                    bool cambioEstadio=admEstadio.CambiarEstadoEstadio(idEsadio);
                    if (cambiarEstado)
                    {
                        guardo = true;
                    }
                }
            }
            return guardo;
        }
    }
}
