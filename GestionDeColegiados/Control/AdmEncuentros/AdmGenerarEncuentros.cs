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
        private List<int> idsEquiposLocales = new List<int>();
        private List<int> idsEquiposVisitantes = new List<int>();
        private List<int> numerosAleatoriosLocal = new List<int>();
        private List<int> numerosAleatoriosVisitante = new List<int>();
        public List<EncuentroGenerado> ListaEncuentrosGenerados { get => listaEncuentrosGenerados; set => listaEncuentrosGenerados = value; }
        public List<EncuentroGenerado> ListaEncuentrosGeneradosPendientes { get => listaEncuentrosGeneradosPendientes; set => listaEncuentrosGeneradosPendientes = value; }

        /*metodo necesario para llenar tuplas(encuentro entre dos equipos)
         * con la información necesaria de cada encuentro
         */
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

        internal bool DarBajaEncuentrosGenerados()
        {
            throw new NotImplementedException();
        }

        /*Metodo para pedirle a la clase admEncuentrosGenerados que nos devuelva
* un encuentro generado a través del id del mismo
*/
        public EncuentroGenerado ObtenerEncuentroPorID(int idEncuentroGeneradoPendiente)
        {
            return datosEncuentrosGenerados.ObtenerEncuentroPendiente(idEncuentroGeneradoPendiente);
        }
        /*Metodo para pedirle a la clase admEncuentrosGenerados que 
         * cambie el estado de un encuentro generado pendiente a por jugar
        */
        public bool CambiarEstadoEncuentro(int idEncuentroGeneradoPendiente)
        {
            return datosEncuentrosGenerados.CambiarEstadoEncuentro(idEncuentroGeneradoPendiente);
        }

        public bool DarBajaEncuentros()
        {
            bool respuesta = datosEncuentrosGenerados.CambiarEstadoEncuentros("N");

            return respuesta;
        }

        //constructor privado para ejecutar singleton
        private AdmGenerarEncuentros()
        {
            listaEncuentrosGenerados = new List<EncuentroGenerado>();
        }
        //metodo necesario para ejecutar singleton
        public static AdmGenerarEncuentros getAdmadmGenerarEncuentros()
        {
            if (admGenerarEncuentros == null)
            {
                admGenerarEncuentros = new AdmGenerarEncuentros();
            }
            return admGenerarEncuentros;
        }
        /*Metodo necesario para pñoder generar encuentros aleatorios 
         * llenando dos listas de contenedores con nombres, uno de equipo local y otro de 
         * equipos visiatnte
         */
        public bool generarEncuentrosAleatorios(List<Label> listaContenedoresLocal, List<Label> listaContenedoresVisitante)
        {
            bool respuesta = false;
            numerosAleatoriosLocal = generListaAleatoria(1, 6);
            numerosAleatoriosVisitante = generListaAleatoria(6, 11);
            listaEquipos = admEquipo.extraerEquipos();
            //aqui se generan encuentros aleatorios y los ids se guardan acorde a su ubicacion
            //en su lista respectiva:idsequiposLocal idsEquipoVisitante
            try
            {
                bool generoNombreEquipoLocales = llenarNombreEquipos(listaContenedoresLocal, numerosAleatoriosLocal, listaEquipos, idsEquiposLocales);
                bool generoNombreEquipoVisitantes = llenarNombreEquipos(listaContenedoresVisitante, numerosAleatoriosVisitante, listaEquipos, idsEquiposVisitantes);
                if(!generoNombreEquipoVisitantes || !generoNombreEquipoLocales)
                {
                    throw new generarEncuentrosException("Error en generarEncuentrosAleatorios");
                }
                else
                {
                    respuesta = true;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return respuesta;
        }
        public void llenarListaEncuentrosGeneradosPendientes()
        {
            this.listaEncuentrosGeneradosPendientes=datosEncuentrosGenerados.ObtenerEncuentrosPendientes();
        }
        /*Metodo donde se gestiona el llenar los nombres del encuentro de dos equipos
         * en sus contenedores respectivos
         */
        private bool llenarNombreEquipos(List<Label> contenedores, List<int> listaAleatoria, List<Equipo> equipos, List<int> idsEquipos)
        {
            bool genero=false;
            int x = 0;
            foreach (int posicionAleatoria in listaAleatoria)
            {
                contenedores[x].Text = equipos[posicionAleatoria - 1].NombreEquipo;
                idsEquipos.Add(equipos[posicionAleatoria - 1].IdEquipo);
                x++;
                genero = true;
            }
            return genero;
        }

        public int obtnerNumeroEncuentrosGeneradosPendientes()
        {
            int numeroEncuentros=0;
            try
            {
                 numeroEncuentros = datosEncuentrosGenerados.ObetnerNumeroEncuentrosPendientes();
                if (numeroEncuentros == -1)
                {
                    throw new generarEncuentrosException("Error en 'obtnerNumeroEncuentrosGeneradosPendientes()'");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             return numeroEncuentros;
        }
        /*Funcion necesaria para generar numeros aletorios en un rango definido y agregarlos
        * a una lista
        */
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
        /*Metodo para generar la lista de encuentros generados mediante la lista 
         de numeros aleatorios que se han generado previamente
        *asigna un equipo local dependiendo del id alteorio en idEquiposLocal
        *contra un equipo visitante dependiendo del id alteroio la lista idsEQuipoVisiatnte
        */
        private List<EncuentroGenerado> generarListaEncuentros()
        {
            List<EncuentroGenerado> lista = new List<EncuentroGenerado>();
            for (int x = 0; x < 5; x++)
            {
                encuentroAuxiliar = new EncuentroGenerado(idsEquiposLocales[x], idsEquiposVisitantes[x]);
                lista.Add(encuentroAuxiliar);
            }

            return lista;
        }
        /*metodo necesario para guardar encuentros aleaorias a través
         de una lista de encuentrosGenerados previamente instanciada
        con ayuda de las listas: idsEquipolocal y idsEquipovisitante que
        fueron creadas previamente*/
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
