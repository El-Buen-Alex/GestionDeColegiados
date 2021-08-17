using Control.AdmEncuentrosGenerados;
using Control.AdmEstadios;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmCambiarEstadioPartido : Form
    {
        AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        AdmEstadio admEstadio = AdmEstadio.GetAdmEstadio();
        public frmCambiarEstadioPartido()
        {
            InitializeComponent();
            //se setean los controladores graficos
            cambiarDisponibilidadControladoresUi(false);
            refrezcarComponentes();

        }
        private void refrezcarComponentes()
        {
            cmbEstadios.Enabled = false;
            admEstadio.LlenarEstadiosCmb(cmbEstadios);
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            cmbEstadios.SelectedItem = null;
            btnGuardarCambios.Enabled = false;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int indexEncuentro, indexEstadio;
            if (cmbEncuentros.Items.ToString() != "" && cmbEstadios.Items.ToString() != "")
            {
                //se recupera la posicion del encuentro al que se desea cambiar el estadio
                //se selecciona el nuevo estadio al que se desea asignar al encuentro
                indexEncuentro = cmbEncuentros.SelectedIndex;
                indexEstadio = cmbEstadios.SelectedIndex;
                //se intenta cambiar el estadio al encuentro
                bool actualizo = admEncuentrosDefinidos.ActualizarEstadio(indexEncuentro, indexEstadio);
                if (actualizo)
                {
                    // si no ocurre problemas al cambiar, se refrezcan los componentes y 
                    //se muestra que el cambio se realizó con exito
                    MessageBox.Show("El cambio se realizo con exito");
                    refrezcarComponentes();
                }
                else
                {
                    MessageBox.Show("No se logró modificar el registro.");
                }
            }
        }

        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cuando el usuario seleccione un encuentro
             el contenido del lblEstadioActual se seteara con el
            nombre del estadio actual del encuentro que se ha seleccionado*/
            int indexEncuentroDefinidoSeleccionado = cmbEncuentros.SelectedIndex;
            cambiarDisponibilidadControladoresUi(true);
            bool lleno = admEncuentrosDefinidos.LlenarInformacíonPartidoCompleta(indexEncuentroDefinidoSeleccionado, lblEquipoLocal, lblEquipoVisitante, cmbEstadios, dtpFechaEncuentro, dtpHora, cmbGrupoColegiado);
        }
        private void cambiarDisponibilidadControladoresUi(bool estado)
        {
            lblEquipoLocal.Enabled = estado;
            lblEquipoVisitante.Enabled = estado;
            dtpFechaEncuentro.Enabled = estado;
            dtpHora.Enabled = estado;
            cmbGrupoColegiado.Enabled = estado;
            cmbEstadios.Enabled = estado;
        }
        private void cmbEstadios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si se selecciona un nuevo estadio, habilitará la opcion de guardar
            btnGuardarCambios.Enabled = true;
        }
    }
}
