using Control.AdmEncuentrosGenerados;
using Control.AdmEquipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmCambiarPartido : Form
    {
        AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        AdmEquipo admEquipo = AdmEquipo.getEquipo();
        public frmCambiarPartido()
        {
            InitializeComponent();
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            cambiarDisponibilidadControladoresUi(false);
            cambiarAccesibilidadBotonGuardar(false);
        }
        private void cambiarDisponibilidadControladoresUi(bool estado)
        {
            lblEquipoLocal.Enabled = estado;
            lblEquipoVisitante.Enabled = estado;
            lblCambiar1.Enabled = estado;
            lblCambiar2.Enabled = estado;
            cmbEquipoLocal.Enabled = estado;
            cmbEquipoVisitante.Enabled = estado;
        }
        private void cambiarAccesibilidadBotonGuardar(bool estado)
        {
            btnGuardarCambios.Enabled = estado;
        }


        private void refrezcarComponentes()
        {
            int indexPartido = cmbEncuentros.SelectedIndex;
            admEncuentrosDefinidos.LlenarMatch(indexPartido,lblEquipoLocal, lblEquipoVisitante);
            string equipoLocal = lblEquipoLocal.Text;
            string equipoVisitante = lblEquipoVisitante.Text;
            admEquipo.ObserverCmbEquipos(cmbEquipoLocal, equipoVisitante, equipoLocal);
            admEquipo.ObserverCmbEquipos(cmbEquipoVisitante, equipoLocal, equipoVisitante);
            cambiarDisponibilidadControladoresUi(true);
        }

        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrezcarComponentes();
        }


        private void cmbEquipoLocal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string equipoLocal = cmbEquipoLocal.Text;
            string equipoVisitante = cmbEquipoVisitante.Text;
            admEquipo.ObserverCmbEquipos(cmbEquipoLocal, equipoVisitante, equipoLocal);
            admEquipo.ObserverCmbEquipos(cmbEquipoVisitante, equipoLocal, equipoVisitante);
        }

        private void cmbEquipoVisitante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string equipoLocal = cmbEquipoLocal.Text;
            string equipoVisitante = cmbEquipoVisitante.Text;
            admEquipo.ObserverCmbEquipos(cmbEquipoLocal, equipoVisitante, equipoLocal);
            admEquipo.ObserverCmbEquipos(cmbEquipoVisitante, equipoLocal, equipoVisitante);
        }
    }
}
