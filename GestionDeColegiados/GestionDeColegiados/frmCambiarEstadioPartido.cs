using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Control.AdmEncuentrosGenerados;
using Control.AdmEstadios;
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
            refrezcarComponentes();
            
        }
        private void refrezcarComponentes()
        {
            cmbEstadios.Enabled = false;
            admEstadio.LlenarEstadiosCmb(cmbEstadios);
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            lblEstadioActual.Text = "  ";
            cmbEstadios.SelectedItem = null;
            btnGuardarCambios.Enabled = false;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int indexEncuentro, indexEstadio;

            if (cmbEncuentros.Items.ToString() != "" && cmbEstadios.Items.ToString()!="")
            {
                indexEncuentro = cmbEncuentros.SelectedIndex;
                indexEstadio = cmbEstadios.SelectedIndex;
                bool actualizo = admEncuentrosDefinidos.ActualizarEstadio(indexEncuentro, indexEstadio);
                if (actualizo)
                {
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
            int indexEncuentroDefinidoSeleccionado = cmbEncuentros.SelectedIndex;
            lblEstadioActual.Text= admEncuentrosDefinidos.ObtenerNombreEstadioDelPartido(indexEncuentroDefinidoSeleccionado);
            cmbEstadios.Enabled = true;
        }

        private void cmbEstadios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
        }
    }
}
