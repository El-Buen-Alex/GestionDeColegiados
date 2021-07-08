using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Control.AdmEncuentrosGenerados;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmTodosLosEncuentrosDefinidos : Form
    {
        AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        public frmTodosLosEncuentrosDefinidos()
        {
            InitializeComponent();
            admEncuentrosDefinidos.LlenarPartidosCmb(cmbEncuentros);
            CambiarAccesibilidadControladoresGUI(false);
        }
        
        private void CambiarAccesibilidadControladoresGUI(bool estado)
        {
            pbTupla.Visible = estado;
            lblColegiados.Visible = estado;
            lblEquipoLocal.Visible = estado;
            lblEquipoVisitante.Visible = estado;
            lblEstadio.Visible = estado;
            lblFecha.Visible = estado;
            lblTituloColegiados.Visible = estado;
        }
        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexEncuentroSeleccionado = cmbEncuentros.SelectedIndex;
            admEncuentrosDefinidos.LlenarInformacíonPartidoCompleta(indexEncuentroSeleccionado,lblEquipoLocal, lblEquipoVisitante, lblEstadio, lblFecha, lblColegiados);
            CambiarAccesibilidadControladoresGUI(true);
        }
    }
}
