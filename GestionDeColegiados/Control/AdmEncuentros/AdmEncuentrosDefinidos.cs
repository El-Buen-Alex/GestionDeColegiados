using Control.AdmColegiados;
using Control.AdmEquipos;
using Control.AdmEstadios;
using Data;
using Model;
using Model.Equipo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        /*metodo usado para llenar encuentros en un combobox
         se recupera los encuentros definidos, el nombre de equipo local y visitante
        ademas del estadio*/
        public void LlenarPartidosCmb(ComboBox cmbEncuentros)
        {
            cmbEncuentros.Items.Clear();
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            EncuentroGenerado encuentroGenerado;
            Equipo local, visitante;
            Estadio estadio;
            for (int x = 0; x < listaEncuentrosDefinidos.Count; x++)
            {
                encuentroGenerado = admEncuentrosGenerados.ObtenerEncuentroPorID(listaEncuentrosDefinidos[x].IdEncuentroGeneradoPendiente);
                local = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
                visitante = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);

                estadio = admEstadios.ObtenerEstadioPorId(listaEncuentrosDefinidos[x].IdEstadio);
                cmbEncuentros.Items.Add(x + 1 + ":" + local.NombreEquipo + " VS " + visitante.NombreEquipo + "- " + estadio.Nombre);
                listaEncuentrosGenerados.Add(encuentroGenerado);
            }
        }

        

        /*metodo para pedirle a AdmEstadio que nos devuelva el nombre de un estadio a través del id*/
        public string ObtenerNombreEstadioDelPartido(int indexEncuentroDefinidoSeleccionado)
        {

            Estadio estadio = admEstadio.ObtenerEstadioPorId(listaEncuentrosDefinidos[indexEncuentroDefinidoSeleccionado].IdEstadio);

            return estadio.Nombre;
        }
        /*metodo para pedirle a EncuentroGenerado que nos devuelva el nombre de un Encuentro Generado a través del id*/
        private EncuentroGenerado ObtenerEncuentroGenerado(int id)
        {
            return admEncuentrosGenerados.ObtenerEncuentroPorID(id);
        }
        /*meotdo usado para llenar la informacion completa de un encuentro 
         *obteniendo el nombre de los equipos 
         *estadio
         *fecha
         *y grupo de colegiados
         */

        private void LlenarDatosPartido(int indexEncuentroSeleccionado, Label lblEquipoLocal, Label lblEquipoVisitante, EncuentroDefinido encuentroDefinido)
        {
            EncuentroGenerado encuentroGenerado = ObtenerEncuentroGenerado(encuentroDefinido.IdEncuentroGeneradoPendiente);
            Equipo local, visitante;
            local = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoLocal);
            visitante = admEquipos.ObtenerEquipoPorId(encuentroGenerado.IdEquipoVisitante);
            lblEquipoLocal.Text = local.NombreEquipo;
            lblEquipoVisitante.Text = visitante.NombreEquipo;
        }

        private void LlenarFechaHoraPartido(Label lblFecha, EncuentroDefinido encuentroDefinido)
        {
            lblFecha.Text = "FECHA: " + encuentroDefinido.FechaDeEncuentro.ToShortDateString() + " HORA: " + encuentroDefinido.Hora.ToShortTimeString();

        }

        public void LlenarInformacíonPartidoCompleta(int indexEncuentroSeleccionado, Label lblEquipoLocal, Label lblEquipoVisitante, Label lblEstadio, Label lblFecha, Label lblColegiado)
        {
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            EncuentroDefinido encuentroDefinido = listaEncuentrosDefinidos[indexEncuentroSeleccionado];
            LlenarDatosPartido(indexEncuentroSeleccionado, lblEquipoLocal, lblEquipoVisitante, encuentroDefinido);
            LlenarFechaHoraPartido(lblFecha, encuentroDefinido);
            lblEstadio.Text = ObtenerNombreEstadioDelPartido(indexEncuentroSeleccionado);
            lblColegiado.Text = admColegiados.ObtenerNombreDeColegiados(encuentroDefinido.IdColegiado);
           
        }
        public int ObtenerNumeroPartidosPorJugar()
        {
            return datosEncuentroDefinido.ObtenerCantidadEncuentrosPorJugar();
        }

 
        public bool LlenarInformacíonPartidoCompleta(int indexEncuentroSeleccionado, Label lblEquipoLocal, Label lblEquipoVisitante, ComboBox cmbEstadios, DateTimePicker dtpFechaEncuentro, DateTimePicker dtpHora, ComboBox cmbGrupoColegiado)
        {
            bool respuesta = false;
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            EncuentroDefinido encuentroDefinido = listaEncuentrosDefinidos[indexEncuentroSeleccionado];
            EncuentroGenerado encuentroGenerado = ObtenerEncuentroGenerado(encuentroDefinido.IdEncuentroGeneradoPendiente);
            LlenarDatosPartido(indexEncuentroSeleccionado, lblEquipoLocal, lblEquipoVisitante, encuentroDefinido);
            string estadio= ObtenerNombreEstadioDelPartido(indexEncuentroSeleccionado);
            admEstadio.SeleccionarEstadio(cmbEstadios, estadio);
            dtpFechaEncuentro.Value = encuentroDefinido.FechaDeEncuentro;
            dtpHora.Value = encuentroDefinido.Hora;
            return respuesta;
        }
        /*Metodo que actualiza el estadio de un encuentro definido
         */
        public bool ActualizarEstadio(int indexEncuentro, int indexEstadio)
        {
            bool actualizo = false;
            listaEncuentrosDefinidos = datosEncuentroDefinido.ObtenerEncuentros();
            admEstadio.refrezcarListaEstadiosDisponibles();
            int idEncuentroPorActualizar = listaEncuentrosGenerados[indexEncuentro].Id;
            int idNuevoEstadioAsociado = admEstadio.ListaEstadiosDisponibles[indexEstadio].Id;
            int idAntiguoEStadio = listaEncuentrosDefinidos[indexEncuentro].IdEstadio;
            try
            {
                actualizo = datosEncuentroDefinido.ActualizarEstadioDePartido(idEncuentroPorActualizar, idNuevoEstadioAsociado);
                if (actualizo)
                {
                    admEstadio.CambiarEstadoEstadio(idNuevoEstadioAsociado, "N");
                    admEstadio.CambiarEstadoEstadio(idAntiguoEStadio, "A");
                }
                else
                {
                    throw new ErrorActualizarEstadioException("En ActualizarEstadio-AdmEncuentrosDefinidos: ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return actualizo;
        }
        /*metodo que guarda un encuentro deifnido y a su vez cambia el estado
         de un encuentro generado
         y el estadio al que fue asignado*/
        public bool GuardarEncuentroDefinido(int grupoColegiado, DateTime fechaPartido, DateTime horaPartido, int estadioSeleccionado, int posicion)
        {
            bool guardo = false;
            admEncuentrosGenerados.llenarListaEncuentrosGeneradosPendientes();
            admColegiados.llenarListaColegiados();
            admEstadio.refrezcarListaEstadiosDisponibles();
            int idEncuentroGeneradoPendiente = admEncuentrosGenerados.ListaEncuentrosGeneradosPendientes[posicion].Id;
            int idColegiado = admColegiados.ListaintegColeg[grupoColegiado].IdGrupoColegiado;
            int idEsadio = admEstadio.ListaEstadiosDisponibles[estadioSeleccionado].Id;
            EncuentroDefinido encuentroDefinido = new EncuentroDefinido(idEncuentroGeneradoPendiente, idColegiado, fechaPartido, "A", horaPartido, idEsadio);
            int id = datosEncuentroDefinido.GuardarEncuentroDefinido(encuentroDefinido);
            if (id != 0)
            {

                bool cambiarEstado = admEncuentrosGenerados.CambiarEstadoEncuentro(idEncuentroGeneradoPendiente);
                if (cambiarEstado)
                {
                    try
                    {
                        bool cambioEstadio = admEstadio.CambiarEstadoEstadio(idEsadio, "N");
                        if (cambiarEstado)
                        {
                            guardo = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        guardo = false;
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            return guardo;
        }
    }
}
