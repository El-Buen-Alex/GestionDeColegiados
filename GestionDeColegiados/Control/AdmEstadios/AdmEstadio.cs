using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmEstadios
{
    public class AdmEstadio
    {
        private static AdmEstadio admEstadio = null;
        private List<Estadio> listaEstadiosDisponibles;
        private DatosEstadios datosEstadios = new DatosEstadios();

        private AdmEstadio()
        {
            listaEstadiosDisponibles = new List<Estadio>();
        }

        public List<Estadio> ListaEstadiosDisponibles { get => listaEstadiosDisponibles; set => listaEstadiosDisponibles = value; }

        public static AdmEstadio GetAdmEstadio()
        {
            if (admEstadio == null)
            {
                admEstadio = new AdmEstadio();
            }
            return admEstadio;
        }
        public void refrezcarListaEstadiosDisponibles()
        {
            listaEstadiosDisponibles = datosEstadios.obtenerEstadiosDisponibles();
        }
        public void LlenarEstadiosCmb(ComboBox cmbEstadio)
        {
            cmbEstadio.DataSource = null;
            listaEstadiosDisponibles = datosEstadios.obtenerEstadiosDisponibles();
            cmbEstadio.DisplayMember = "nombre";
            cmbEstadio.DataSource = listaEstadiosDisponibles;
        }
        public void LlenarEstadiosCmb(ComboBox cmbEstadio, Estadio estadio)
        {
            cmbEstadio.DataSource = null;
            listaEstadiosDisponibles = datosEstadios.obtenerEstadiosDisponibles();
            listaEstadiosDisponibles.Insert(0, estadio);
            cmbEstadio.DisplayMember = "nombre";
            cmbEstadio.DataSource = listaEstadiosDisponibles;
        }
        public Estadio ObtenerEstadioPorId(int idEstadio)
        {
            return datosEstadios.ObtenerEstadioPorId(idEstadio);
        }
        public bool CambiarEstadoEstadio(int idEsadio, string estado)
        {
            bool cambio = false;
            cambio = datosEstadios.CambiarEstado(idEsadio, estado);
            if (!cambio)
            {
                throw new ErrorActualizarEstadioException("Error en CambiarEstadoEstadio-AdmEstadio");
            }

            return cambio;
        }

        public void PonerEstadiosDisponibles()
        {
            bool respuesta=datosEstadios.PutEstadiosDisponibles();
        }

        public void SeleccionarEstadio(ComboBox cmbEstadios, Estadio estadio)
        {
            LlenarEstadiosCmb(cmbEstadios, estadio);
            cmbEstadios.SelectedIndex = 0;
        }

        internal Estadio ObtenerEstadioPorIndex(int indexEncuentroSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
