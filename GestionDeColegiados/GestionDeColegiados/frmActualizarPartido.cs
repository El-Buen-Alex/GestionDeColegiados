using Control;
using Control.AdmEncuentrosGenerados;
using Control.AdmColegiados;
using Control.AdmEstadios;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmCambiarEstadioPartido : Form
    {
        AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        AdmEstadio admEstadio = AdmEstadio.GetAdmEstadio();
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();
        private bool muestraInfo;
        private ValidacionGUI validacionGUI = new ValidacionGUI();
        public frmCambiarEstadioPartido()
        {
            InitializeComponent();
            //se setean los controladores graficos
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            cambiarDisponibilidadControladoresUi(false);
           

        }
        

        private void EnviarDatosGuardar()
        {
            int indexEncuentro, indexEstadio, indexColegiados;
            if (cmbEncuentros.Items.ToString() != "" && cmbEstadios.Items.ToString() != "")
            {
                //se recupera la posicion del encuentro al que se desea cambiar el estadio
                //se selecciona el nuevo estadio al que se desea asignar al encuentro
                indexEncuentro = cmbEncuentros.SelectedIndex;
                indexEstadio = cmbEstadios.SelectedIndex;
                indexColegiados = cmbGrupoColegiado.SelectedIndex;
                DateTime fecha = dtpFechaEncuentro.Value;
                DateTime hora = dtpHora.Value;

                //se intenta cambiar el estadio al encuentro
                bool actualizo = admEncuentrosDefinidos.ActualizarEncuentroDefinido(indexEncuentro, indexEstadio, indexColegiados, fecha, hora);
                if (actualizo)
                {
                    // si no ocurre problemas al cambiar, se refrezcan los componentes y 
                    //se muestra que el cambio se realizó con exito
                    MessageBox.Show("El cambio se realizo con exito");
                    cambiarDisponibilidadControladoresUi(false);
                    cambiarAccesibilidadBotonGuardar(false);
                }
                else
                {
                    MessageBox.Show("No se logró modificar el registro.");
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            EnviarDatosGuardar();
        }

        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cuando el usuario seleccione un encuentro
             el contenido del lblEstadioActual se seteara con el
            nombre del estadio actual del encuentro que se ha seleccionado*/
            int indexEncuentroDefinidoSeleccionado = cmbEncuentros.SelectedIndex;
            muestraInfo = admEncuentrosDefinidos.LlenarInformacíonPartidoCompleta(indexEncuentroDefinidoSeleccionado, lblEquipoLocal, lblEquipoVisitante, cmbEstadios, dtpFechaEncuentro, dtpHora, cmbGrupoColegiado, txtColegiados);
            if (muestraInfo)
            {
                cambiarDisponibilidadControladoresUi(true);
                validarFecha();
            }
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
        private void cambiarAccesibilidadBotonGuardar(bool estado)
        {
            btnGuardarCambios.Enabled = estado;
        }
        
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si se selecciona un nuevo estadio, habilitará la opcion de guardar
            btnGuardarCambios.Enabled = true;
        }
        private void cmbColegiados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si se selecciona un nuevo estadio, habilitará la opcion de guardar
            int indexColegiados = cmbGrupoColegiado.SelectedIndex;
            string s = admColegiado.ObtenerNombreDeColegiadosIndex(indexColegiados);
            txtColegiados.Text = s;
            btnGuardarCambios.Enabled = true;
        }

        private void validarFecha()
        {
            bool fecha = validacionGUI.ValidarFecha(dtpFechaEncuentro.Value);
            if (!fecha)
            {
                cambiarDisponibilidadControladoresUi(false);
                cambiarAccesibilidadBotonGuardar(false);
                dtpFechaEncuentro.Enabled = true;
                lblFechaMenor.Visible = true;
            }
            else
            {
                lblFechaMenor.Visible = false;
                cambiarDisponibilidadControladoresUi(muestraInfo);
                cambiarAccesibilidadBotonGuardar(muestraInfo);
            }
        }

        private void dtpFechaEncuentro_ValueChanged(object sender, EventArgs e)
        {
            validarFecha();
           
        }
        private void dtpHoraEncuentro_ValueChanged(object sender, EventArgs e)
        {
            cambiarAccesibilidadBotonGuardar(muestraInfo);
        }

    }
}
