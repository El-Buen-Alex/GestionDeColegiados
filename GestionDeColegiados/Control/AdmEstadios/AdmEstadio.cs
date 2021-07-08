using System;
using Model;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void LlenarEstadiosCmb(ComboBox cmbEstadio)
        {
            cmbEstadio.Items.Clear();
            listaEstadiosDisponibles = datosEstadios.obtenerEstadiosDisponibles();
            cmbEstadio.DisplayMember = "nombre";
            cmbEstadio.DataSource = listaEstadiosDisponibles;
        }
        public Estadio ObtenerEstadioPorId(int idEstadio)
        {
            return datosEstadios.ObtenerEstadioPorId(idEstadio);
        }
        public bool CambiarEstadoEstadio(int idEsadio, string estado)
        {
           return datosEstadios.CambiarEstado(idEsadio, estado);
        }
    }
}
