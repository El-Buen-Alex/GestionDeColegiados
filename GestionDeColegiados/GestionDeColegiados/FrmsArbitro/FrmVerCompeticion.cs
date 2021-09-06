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
using Control.AdmEstadios;

namespace GestionDeColegiados.FrmsArbitro
{
   public partial class FrmVerCompeticion : Form
    {
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();
        private AdmEncuentrosDefinidos admEncuentroDefinido = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEstadio admEstadio = AdmEstadio.GetAdmEstadio();
        public FrmVerCompeticion(bool puedeAdministrar)
        {
            InitializeComponent();
            competenciaLlenar();
            if (puedeAdministrar)
            {
                msAdmin.Visible = puedeAdministrar;
                gestionarDisponibilidadMenuAdm();
                existenEncuentrosDefinidos();
                existenEncuentrosGenerados();
            }
        }

        private void cambiarDisponibilidadMsAdmin(int cantidad)
        {
            if (cantidad > 0)
            {
                msAdmin.Enabled = true;
            }
            else
            {
                msAdmin.Enabled = false;
            }
        }

        private void existenEncuentrosDefinidos()
        {
            int cantidad = admEncuentroDefinido.ObtenerCantidadEncuentrosDefinidos();
            cambiarDisponibilidadMsAdmin(cantidad);
        }
        private void existenEncuentrosGenerados()
        {
            int cantidad=admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes();
            cambiarDisponibilidadMsAdmin(cantidad);
        }
        private void gestionarDisponibilidadMenuAdm()
        {
            int cantidadEncuentrosFinalizados = admEncuentroFinalizado.GetCantidadEncuentrosFinalizados();
            cambiarDisponibilidadMsAdmin(cantidadEncuentrosFinalizados);
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
                admEstadio.PonerEstadiosDisponibles();
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
            string pregunta = "¿Seguro que quieres DAR DE BAJA la competición?\n";
            string mensaje = "Esto Hará que se vuelva a generar y definir encuentros en una nueva copa.";
            string reaccion = "Pero no se podrá visualizar en futuras busquedas.";
            DialogResult res = MessageBox.Show(pregunta + mensaje + reaccion, "CUIDADO", MessageBoxButtons.YesNo);       
            if (res == DialogResult.Yes)
            {
                bool resultado=admEncuentroFinalizado.DarBajaCompetencia();
                if (resultado)
                {
                    resultado = admEncuentroDefinido.DarBajaEncuentrosDefinidos();
                    if (resultado)
                    {
                        resultado = admGenerarEncuentros.DarBajaEncuentros();
                    }
                }
                mostrarMensajeFinalizar(resultado);
            }
           
        }

        private void fINALIZARCOMPETENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pregunta = "¿Seguro que quieres FINALIZAR la competición?\n";
            string mensaje = "Esto Hará que se vuelva a generar y definir encuentros en una nueva copa";
            string reaccion = "Se podrá visualizar en futuras busquedas.";
            DialogResult res = MessageBox.Show(pregunta + mensaje + reaccion, "CUIDADO", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                bool resultado = admEncuentroFinalizado.FinalizarCompetencia();
                mostrarMensajeFinalizar(resultado);
            }
        }
        private void ReiniciarTodaCompetencia()
        {
            string pregunta = "¿Seguro que quieres REINICIAR la competición?\n";
            string mensaje = "Esto Hará que se elimine todo menos los encuentros que esten generados";
            DialogResult res = MessageBox.Show(pregunta+mensaje, "Cuidado", MessageBoxButtons.YesNo);
            bool resultado = false;
            if (res == DialogResult.Yes)
            {
                int cantidadEF = admEncuentroFinalizado.GetCantidadEncuentrosFinalizados();
                if (cantidadEF > 0)
                {
                    resultado = admEncuentroFinalizado.ReinicarCompetencia();
                }
                int cantidadED = admEncuentroDefinido.ObtenerCantidadEncuentrosDefinidos();
                if (cantidadED>0)
                {
                    resultado = admEncuentroDefinido.ReinicarCompetencia();
                }
                mostrarMensajeFinalizar(resultado);
            }
        }
        private void rEINICIARTODALACOMPETENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReiniciarTodaCompetencia();
        }

        private void rEINICIARRESULTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pregunta = "¿Seguro que quieres REINICIAR LOS RESULTADOS de la competición?\n";
            string mensaje = "Esto Hará que se elimine todo menos los encuentros que esten GENERADOS y DEFINIDOS";
            DialogResult res = MessageBox.Show(pregunta + mensaje, "ALERTA", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                bool resultado = admEncuentroFinalizado.ReinicarCompetencia();
                mostrarMensajeFinalizar(resultado);
            }
        }
    }
}
