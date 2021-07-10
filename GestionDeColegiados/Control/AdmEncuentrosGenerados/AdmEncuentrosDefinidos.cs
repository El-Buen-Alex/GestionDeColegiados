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
using Control.AdmEstadios;

namespace Control.AdmEncuentrosGenerados
{
    public class AdmEncuentrosDefinidos
    {
        private static AdmEncuentrosDefinidos admGenerarEncuentrosDefinidos = null;
        private List<EncuentroDefinido> listaEncuentrosDefinidos;
        private List<EncuentroGenerado> listaEncuentrosGenerados = new List<EncuentroGenerado>();
        private DatosEncuentroDefinido datosEncuentroDefinido = new DatosEncuentroDefinido();
        private AdmGenerarEncuentros admEncuentrosGenerados = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmColegiado admColegiados = AdmColegiado.getAdmCol();

        

        private AdmEquipo admEquipos = AdmEquipo.getEquipo();
        private AdmEstadio admEstadios = AdmEstadio.GetAdmEstadio();
      
        public void LlenarPartidosCmb(ComboBox cmbEncuentros)
        {
            cmbEncuentros.Items.Clear();
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            EncuentroGenerado encuentroGenerado;
            Equipo local, visitante;
            Estadio estadio;
            for (int x=0;x < listaEncuentrosDefinidos.Count; x++)
            {
                encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(listaEncuentrosDefinidos[x].IdEncuentroGeneradoPendiente);
                local = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
                visitante = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);
                
                estadio = admEstadios.ObtenerEstadioPorId(listaEncuentrosDefinidos[x].IdEstadio);
                cmbEncuentros.Items.Add(x+1+":" + local.NombreEquipo + " VS " + visitante.NombreEquipo +"- " +estadio.Nombre);
                listaEncuentrosGenerados.Add(encuentroGenerado);
                Console.WriteLine(encuentroGenerado.Id);
            }
        }

        public string ObtenerNombreEstadioDelPartido(int indexEncuentroDefinidoSeleccionado)
        {

            Estadio estadio = admEstadio.ObtenerEstadioPorId(listaEncuentrosDefinidos[indexEncuentroDefinidoSeleccionado].IdEstadio);
            
            return estadio.Nombre;
        }
        private EncuentroGenerado ObtenerEncuentroGenerado(int id)
        {
            return admEncuentrosGenerados.ObtenerEncuentroPorID(id);
        }
        
        public void LlenarInformacíonPartidoCompleta(int indexEncuentroSeleccionado, Label lblEquipoLocal, Label lblEquipoVisitante, Label lblEstadio, Label lblFecha, Label lblColegiado)
        {

            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            EncuentroDefinido encuentroDefinido = listaEncuentrosDefinidos[indexEncuentroSeleccionado];
            EncuentroGenerado encuentroGenerado = ObtenerEncuentroGenerado(encuentroDefinido.IdEncuentroGeneradoPendiente);
            Equipo local, visitante;
            local = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
            visitante = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);

            lblFecha.Text = "FECHA: " + encuentroDefinido.FechaDeEncuentro.ToShortDateString()+" HORA: " + encuentroDefinido.Hora.ToShortTimeString();
            Console.WriteLine("" + encuentroDefinido.FechaDeEncuentro.ToShortDateString() + "  " + encuentroDefinido.Hora.ToShortTimeString());
            lblEquipoLocal.Text = local.NombreEquipo;
            lblEquipoVisitante.Text = visitante.NombreEquipo;
            lblEstadio.Text = ObtenerNombreEstadioDelPartido(indexEncuentroSeleccionado);
            lblColegiado.Text = admColegiados.ObtenerNombreDeColegiados(encuentroDefinido.IdColegiado);
        }

        public int ObtenerNumeroPartidosPorJugar()
        {
            return datosEncuentroDefinido.ObtenerCantidadEncuentrosPorJugar();
        }

        public bool ActualizarEstadio(int indexEncuentro, int indexEstadio)
        {
            bool actualizo = false;
            int idEncuentroPorActualizar = listaEncuentrosGenerados[indexEncuentro].Id;
            int idNuevoEstadioAsociado = admEstadio.ListaEstadiosDisponibles[indexEstadio].Id;
            int idAntiguoEStadio = listaEncuentrosDefinidos[indexEncuentro].IdEstadio;
            try
            {
                actualizo = datosEncuentroDefinido.ActualizarEstadioDePartido(idEncuentroPorActualizar, idNuevoEstadioAsociado);
                if (actualizo)
                {
                    admEstadio.CambiarEstadoEstadio(idNuevoEstadioAsociado, "OCUPADO");
                    admEstadio.CambiarEstadoEstadio(idAntiguoEStadio, "DISPONIBLE");
                }
                else
                {
                    throw new ErrorActualizarEstadioException("En ActualizarEstadio-AdmEncuentrosDefinidos: ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return actualizo;
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
                    try
                    {
                        bool cambioEstadio = admEstadio.CambiarEstadoEstadio(idEsadio, "OCUPADO");
                        if (cambiarEstado)
                        {
                            guardo = true;
                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
            return guardo;
        }
    }
}
