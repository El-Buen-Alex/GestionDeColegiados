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
            admEstadio.LlenarEstadiosCmb(cmbEstadios);
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cmbEncuentros.Items.ToString() != "" && cmbEstadios.Items.ToString()!="")
            {

            }
        }

        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
        }
    }
}
