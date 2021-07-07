using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Control.AdmEncuentrosGenerados;
using Control.AdmColegiados;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmAsignarGrupoColegiados : Form
    {
        private AdmColegiado admColegiado = AdmColegiado.getAdmCol();
        private AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEncuentrosDefinidos admGenerarEncuentroDefinido = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        public frmAsignarGrupoColegiados()
        {
            InitializeComponent();
            refrezcarContenedores();
        }
         private void refrezcarContenedores()
        {
            admGenerarEncuentros.LlenarPrimeraTupla(lblEquipoLocal, lblEquipoVisitante);
            admColegiado.LlenarColegiadosCmb(cmbGrupoColegiado);
        }
        private void cambiarAccesibilidadControlesGraficos(bool accesibilidad)
        {
            dtpFechaEncuentro.Enabled = accesibilidad;
            cmbGrupoColegiado.Enabled = accesibilidad;
            btnRegistrar.Enabled = accesibilidad;
            btnSiguiente.Enabled = !accesibilidad;
        }
        private void controladoresGUINoDisponibles()
        {
            dtpFechaEncuentro.Enabled = false;
            cmbGrupoColegiado.Enabled = false;
            btnRegistrar.Enabled = false;
            btnSiguiente.Enabled = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int grupoSeleccionado = cmbGrupoColegiado.SelectedIndex;
            DateTime fechaPartido = dtpFechaEncuentro.Value;
            Console.WriteLine(fechaPartido);
            bool guardo=admGenerarEncuentroDefinido.GuardarEncuentroDefinido(grupoSeleccionado, fechaPartido);
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
