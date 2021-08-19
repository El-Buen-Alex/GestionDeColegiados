using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control.AdmEncuentros;
using Control.AdmEncuentrosGenerados;

namespace GestionDeColegiados.FrmsArbitro
{
    public partial class FrmRegistrarResultado : Form
    {
        private AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();
        public FrmRegistrarResultado()
        {
            InitializeComponent();
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            cambiarDisponibilidadControladoresUi(false);
        }

        private void cambiarDisponibilidadControladoresUi(bool estado)
        {
            lblEquipoLocal.Enabled = estado;
            lblEquipoVisitante.Enabled = estado;
            txtGolesLocal.Enabled = estado;
            txtGolesVisitante.Enabled = estado;
            lblPuntosLocal1.Enabled = estado;
            lblPuntosVisitante.Enabled = estado;
            lblPuntosLocalResultado.Visible = estado;
            lblPuntosVisitanteResultado.Visible = estado;
            btnGuardarCambios.Enabled = estado;
        }

        private void refrezcarComponentes()
        {
            int index = cmbEncuentros.SelectedIndex;
            admEncuentrosDefinidos.LlenarMatch(index, lblEquipoLocal, lblEquipoVisitante);
        }
        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrezcarComponentes();
            cambiarDisponibilidadControladoresUi(true);
        }
        private void enviarDatosGuardar()
        {
            string golesLocal = txtGolesLocal.Text;
            string golesVisitante = txtGolesVisitante.Text;
            if (String.IsNullOrEmpty(golesLocal) || String.IsNullOrEmpty(golesVisitante))
            {
                MessageBox.Show("Ingrese la cantidad de Goles realizado por los equipos correctamente");
            }
            else
            {
                int index = cmbEncuentros.SelectedIndex;
                bool guardado = admEncuentroFinalizado.GuardarEncuentroFinalizado(index, golesLocal, golesVisitante);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            enviarDatosGuardar();
        }
    }
}
