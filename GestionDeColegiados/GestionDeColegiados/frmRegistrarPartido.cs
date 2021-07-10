using Control.AdmColegiados;
using Control.AdmEncuentrosGenerados;
using Control.AdmEstadios;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmRegistrarPartido : Form
    {
        private AdmColegiado admColegiado = AdmColegiado.getAdmCol();
        private AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEncuentrosDefinidos admGenerarEncuentroDefinido = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmEstadio admEstadio = AdmEstadio.GetAdmEstadio();
        public frmRegistrarPartido()
        {
            InitializeComponent();
            refrezcarContenedores();

        }
        private void refrezcarContenedores()
        {
            admGenerarEncuentros.LlenarPrimeraTupla(lblEquipoLocal, lblEquipoVisitante);
            admColegiado.LlenarColegiadosCmb(cmbGrupoColegiado);
            admEstadio.LlenarEstadiosCmb(cmbEstadio);
        }
        private void cambiarAccesibilidadControlesGraficos(bool accesibilidad)
        {
            dtpFechaEncuentro.Enabled = accesibilidad;
            cmbGrupoColegiado.Enabled = accesibilidad;
            btnRegistrar.Enabled = accesibilidad;
            dtpHora.Enabled = accesibilidad;
            cmbEstadio.Enabled = accesibilidad;
            btnSiguiente.Enabled = !accesibilidad;
        }
        private void controladoresGUINoDisponibles()
        {
            dtpFechaEncuentro.Enabled = false;
            cmbGrupoColegiado.Enabled = false;
            dtpHora.Enabled = false;
            btnRegistrar.Enabled = false;
            btnSiguiente.Enabled = false;
            cmbEstadio.Enabled = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int grupoSeleccionado = cmbGrupoColegiado.SelectedIndex;
            DateTime fechaPartido = dtpFechaEncuentro.Value;
            DateTime horaPartido = dtpHora.Value;
            int estadioSeleccionado = cmbEstadio.SelectedIndex;
            bool guardo = admGenerarEncuentroDefinido.GuardarEncuentroDefinido(grupoSeleccionado, fechaPartido, horaPartido, estadioSeleccionado);
            if (guardo)
            {
                cambiarAccesibilidadControlesGraficos(false);
            }
            if (admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes() == 0)
            {
                controladoresGUINoDisponibles();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            refrezcarContenedores();
            cambiarAccesibilidadControlesGraficos(true);
        }
    }
}
