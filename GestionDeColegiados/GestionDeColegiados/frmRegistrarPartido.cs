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
            /*pasamos posicion 0, porque cada vez que se asigna un estadio y coleggiado a un 
             ecneuntroG generado pendiente, este cambia de estado("por jugar") y en la lista existe
            un encuentro menos por definir estadio y colegiado*/
            admGenerarEncuentros.LlenarTuplas(lblEquipoLocal, lblEquipoVisitante,0);
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
            bool guardo = admGenerarEncuentroDefinido.GuardarEncuentroDefinido(grupoSeleccionado, fechaPartido, horaPartido, estadioSeleccionado,0);
            if (guardo)
            {
                //si guarda se bloquea la capacidad de editar algun encuentro ya definido
                cambiarAccesibilidadControlesGraficos(false);
            }
            if (admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes() == 0)
            {
                //Si ya no existen encuentros pedientes por definir colegiados, estado y fecha
                //se bloquea la capacidad de interactuar completamente con esta interfaz
                controladoresGUINoDisponibles();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //si da clic en siguiente, se resetean los componentes y 
            //se cambia la accesbilidad de la ventana grafica
            refrezcarContenedores();
            cambiarAccesibilidadControlesGraficos(true);
        }
    }
}
