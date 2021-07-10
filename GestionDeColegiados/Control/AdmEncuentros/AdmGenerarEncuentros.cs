using Control.AdmEquipos;
using Data;
using Model;
using Model.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Control.AdmEncuentrosGenerados
{
    public class AdmGenerarEncuentros
    {
        private List<EncuentroGenerado> listaEncuentrosGenerados;
        private List<EncuentroGenerado> listaEncuentrosGeneradosPendientes;
        private EncuentroGenerado encuentroAuxiliar = null;
        private static AdmGenerarEncuentros admGenerarEncuentros = null;
        private AdmEquipo admEquipo = AdmEquipo.getEquipo();
        private List<Equipo> listaEquipos;
        private DatosEnuenctrosGenerados datosEncuentrosGenerados = new DatosEnuenctrosGenerados();

        public void LlenarPrimeraTupla(Label lblEquipoLocal, Label lblEquipoVisitante)
        {
            listaEncuentrosGeneradosPendientes = datosEncuentrosGenerados.ObtenerEncuentrosPendientes();
            int idEquipoLocal = listaEncuentrosGeneradosPendientes[0].IdEquipoLocal;
            int idEquipoVisitante = listaEncuentrosGeneradosPendientes[0].IdEquipoVisitante;
            Equipo equipoLocal = admEquipo.ObtenerEquipoPorId(idEquipoLocal);
            Equipo equipoVisitante = admEquipo.ObtenerEquipoPorId(idEquipoVisitante);
            lblEquipoLocal.Text = equipoLocal.NombreEquipo;
            lblEquipoVisitante.Text = equipoVisitante.NombreEquipo;
        }

        public void LlenarTuplas(Label lblEquipoLocal, Label lblEquipoVisitante, int posicion)
        {
            listaEncuentrosGeneradosPendientes = datosEncuentrosGenerados.ObtenerEncuentrosPendientes();
            int idEquipoLocal = listaEncuentrosGeneradosPendientes[posicion].IdEquipoLocal;
            int idEquipoVisitante = listaEncuentrosGeneradosPendientes[posicion].IdEquipoVisitante;
            Equipo equipoLocal = admEquipo.ObtenerEquipoPorId(idEquipoLocal);
            Equipo equipoVisitante = admEquipo.ObtenerEquipoPorId(idEquipoVisitante);
            lblEquipoLocal.Text = equipoLocal.NombreEquipo;
            lblEquipoVisitante.Text = equipoVisitante.NombreEquipo;
        }

        public EncuentroGenerado ObtenerEncuentroPorID(int idEncuentroGeneradoPendiente)
        {
            return datosEncuentrosGenerados.ObtenerEncuentrosPendientes(idEncuentroGeneradoPendiente);
        }

        private List<int> idsEquiposLocales = new List<int>();
        private List<int> idsEquiposVisitantes = new List<int>();

        private List<int> numerosAleatoriosLocal = new List<int>();
        private List<int> numerosAleatoriosVisitante = new List<int>();

        public List<EncuentroGenerado> ListaEncuentrosGenerados { get => listaEncuentrosGenerados; set => listaEncuentrosGenerados = value; }
        public List<EncuentroGenerado> ListaEncuentrosGeneradosPendientes { get => listaEncuentrosGeneradosPendientes; set => listaEncuentrosGeneradosPendientes = value; }

        public bool CambiarEstadoEncuentro(int idEncuentroGeneradoPendiente)
        {
            return datosEncuentrosGenerados.CambiarEstadoEncuentro(idEncuentroGeneradoPendiente);
        }

        private AdmGenerarEncuentros()
        {
            listaEncuentrosGenerados = new List<EncuentroGenerado>();
        }
        public static AdmGenerarEncuentros getAdmadmGenerarEncuentros()
        {
            if (admGenerarEncuentros == null)
            {
                admGenerarEncuentros = new AdmGenerarEncuentros();
            }
            return admGenerarEncuentros;
        }
        public void generarEncuentrosAleatorios(List<Label> listaContenedoresLocal, List<Label> listaContenedoresVisitante)
        {

            numerosAleatoriosLocal = generListaAleatoria(1, 6);
            numerosAleatoriosVisitante = generListaAleatoria(6, 11);
            listaEquipos = admEquipo.extraerEquipos();
            llenarNombreEquipos(listaContenedoresLocal, numerosAleatoriosLocal, listaEquipos, idsEquiposLocales);
            llenarNombreEquipos(listaContenedoresVisitante, numerosAleatoriosVisitante, listaEquipos, idsEquiposVisitantes);

        }
        private string llenarNombreEquipos(List<Label> contenedores, List<int> listaAleatoria, List<Equipo> equipos, List<int> idsEquipos)
        {
            string nombreEquipos = "";
            int x = 0;
            foreach (int posicionAleatoria in listaAleatoria)
            {
                contenedores[x].Text = equipos[posicionAleatoria - 1].NombreEquipo;
                idsEquipos.Add(equipos[posicionAleatoria - 1].IdEquipo);
                x++;
            }
            return nombreEquipos;
        }

        public int obtnerNumeroEncuentrosGeneradosPendientes()
        {
            int numeroEncuentros = datosEncuentrosGenerados.ObetnerNumeroEncuentrosPendientes();
            return numeroEncuentros;
        }

        private List<int> generListaAleatoria(int limiteInferior, int limiteSuperior)
        {
            List<int> listaAleatoria = new List<int>();
            int numeroGenerado = 0;
            while (listaAleatoria.Count() < 5)
            {
                numeroGenerado = new Random().Next(limiteInferior, limiteSuperior);
                if (!listaAleatoria.Contains(numeroGenerado))
                {
                    listaAleatoria.Add(numeroGenerado);
                }
            }
            return listaAleatoria;
        }

        private List<EncuentroGenerado> generarListaEncuentros()
        {
            List<EncuentroGenerado> lista = new List<EncuentroGenerado>();
            for (int x = 0; x < 5; x++)
            {
                encuentroAuxiliar = new EncuentroGenerado(idsEquiposLocales[x], idsEquiposVisitantes[x], "PENDIENTE");
                lista.Add(encuentroAuxiliar);
            }

            return lista;
        }

        public string guardarEncuentrosAleatorios()
        {
            listaEncuentrosGenerados = generarListaEncuentros();
            bool guardo = false;
            string mensaje = "";
            try
            {
                guardo = datosEncuentrosGenerados.GuardarEncuentrosGenerados(listaEncuentrosGenerados);
                if (guardo)
                {
                    mensaje = "Se ha guardado con exito los encuentros generados";
                }
                else
                {
                    mensaje = "No se logro guardar con exito. Intente nuevamente.";
                    throw new generarEncuentrosException("Error en guardarEncuentrosAleatorios-AdmGenerarEncuentros");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return mensaje;
        }
    }
}
