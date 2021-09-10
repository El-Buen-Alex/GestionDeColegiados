using Control.AdmEncuentros;
using Control.AdmEncuentrosGenerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados.FrmsArbitro
{
    public partial class FrmMenuArbitro : Form
    {
        private AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();
        //dll y variables necesarios para poder mover de lugar la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        private Color colorDefaultMin;
        public FrmMenuArbitro()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            /*preguntamos si existe minimo un formulario ya abierto
            si es así entonces lo cerramos*/
            if (this.pnlPanelContenedor.Controls.Count > 0)
                this.pnlPanelContenedor.Controls.RemoveAt(0);
            //finalmente abrimos el frm que se desea mostrar en el panel principal
            Form formAMostrar = formhija as Form;
            formAMostrar.TopLevel = false;
            formAMostrar.Dock = DockStyle.Fill;
            this.pnlPanelContenedor.Controls.Add(formAMostrar);
            this.pnlPanelContenedor.Tag = formAMostrar;
            formAMostrar.Show();

        }
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pbMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //evento para cerrar pantalla
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador

        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor = Color.FromArgb(202, 49, 32);
        }
        protected void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.BackColor = colorDefaultClose;
        }

        protected void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            colorDefaultMin = pbMinimizar.BackColor;
            pbMinimizar.BackColor = Color.FromArgb(52, 58, 64);
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = colorDefaultMin;
        }

        

        private void btnGestionColegiado1_MouseEnter(object sender, EventArgs e)
        {
            flpGestionPartidoFinalizado.Visible = true;
        }

        private void btnRegistrarPartido_Click(object sender, EventArgs e)
        {
            int cantEncuentrosDefinidos = admEncuentrosDefinidos.ObtenerNumeroPartidosPorJugar();
            if (cantEncuentrosDefinidos == 0)
            {
                MessageBox.Show("No existen encuentros definidos por registrar");
            }
            else
            {
                AbrirFormEnPanel(new FrmRegistrarResultado());
            }
           
        }
        private void existenRegistrosArbir(object formhija)
        {
            int cantEncuentrosFinalizados = admEncuentroFinalizado.GetCantidadEncuentrosFinalizados();
            if (cantEncuentrosFinalizados > 0)
            {
                AbrirFormEnPanel(formhija);
            }
        }
        private void btnActualizarPartidoFinalizado_Click(object sender, EventArgs e)
        {
            existenRegistrosArbir(new FrmEditarPartidoFinalizado());
        }

        private void btnVerTodosPartidos_Click(object sender, EventArgs e)
        {
            
             AbrirFormEnPanel(new FrmVerCompeticion(false));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            btnIniciarSesion frm = new btnIniciarSesion();
            frm.Show();
        }
    }
}
