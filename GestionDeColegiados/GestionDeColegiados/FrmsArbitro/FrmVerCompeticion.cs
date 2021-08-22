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

namespace GestionDeColegiados.FrmsArbitro
{
   public partial class FrmVerCompeticion : Form
    {
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();

        public FrmVerCompeticion(bool puedeAdministrar)
        {
            InitializeComponent();
            competenciaLlenar();
            if (puedeAdministrar)
            {
                msAdmin.Visible = puedeAdministrar;
                gestionarDisponibilidadMenuAdm();
            }
        }
        private void gestionarDisponibilidadMenuAdm()
        {
            int cantidadEncuentrosFinalizados = admEncuentroFinalizado.GetCantidadEncuentrosFinalizados();
            if (cantidadEncuentrosFinalizados > 0)
            {
                msAdmin.Enabled = true;
            }
            else
            {
                msAdmin.Enabled = false;
            }
        }
        private void competenciaLlenar()
        {
            bool existe = admEncuentroFinalizado.LlenarDgv(dgvCompeticion);
            lblAdvertencia.Visible = !existe;
        }

        private void mostrarMensajeFinalizar(bool respuesta)
        {
            string mensaje = "";
            if (respuesta)
            {
                mensaje = "LIGA FINALIZADA!";
                gestionarDisponibilidadMenuAdm();
            }
            else
            {
                mensaje = "NO SE PUDO ELIMINAR";
            }
            MessageBox.Show(mensaje);
        }

        private void DAR_BAJA_RCOMPETENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("¿Seguro que quieres DAR DE BAJA la competición?", "Cuidado", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                bool resultado=admEncuentroFinalizado.DarBajaCompetencia();
                mostrarMensajeFinalizar(resultado);
            }
           
        }

        private void tERMINARCOMPETENCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres FINALIZAR la competición?", "Cuidado", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                bool resultado = admEncuentroFinalizado.FinalizarCompetencia();
                mostrarMensajeFinalizar(resultado);
            }
        }
    }
}
