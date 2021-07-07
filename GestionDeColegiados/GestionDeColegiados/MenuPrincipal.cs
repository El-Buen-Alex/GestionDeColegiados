using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Control;
using Control.AdmEquipos;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Control.AdmEncuentrosGenerados;

namespace GestionDeColegiados
{
    public partial class MenuPrincipal : Form
    {

        //dlly variables necesarios para poder mover de lugar la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        private Color colorDefaultMin;

        private AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEquipo admEquipo = AdmEquipo.getEquipo();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionColegiados_MouseEnter(object sender, EventArgs e)
        {

            flpOpcionGestionColegiado.Visible = true;
        }

        private void btnGestionEquipos2_MouseEnter(object sender, EventArgs e)
        {
            flpOpcionGestionEquipo.Visible = true;
        }

        private void btnGestionEncuentros2_MouseEnter(object sender, EventArgs e)
        {
            flpOpcionGestionEncuentros.Visible = true;
        }



        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlPanelContenedor.Controls.Count > 0)
                this.pnlPanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlPanelContenedor.Controls.Add(fh);
            this.pnlPanelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnNuevoGrupoColegiados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmNuevoGrupoColegiado());
        }

        private void btnVerTodosColegiados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmVerTodosLosColegiados());
        }

        private void btnAnadirEquipo_Click(object sender, EventArgs e)
        {
            if(admEquipo.ObtenerCantidadEquipo() < 10)
            {
                AbrirFormEnPanel(new frmNuevoEquipo());
            }
            else
            {
                AbrirFormEnPanel(new frmListaEquipos()); 
            }
            
        }

        private void btnGenerarEncuentros_Click(object sender, EventArgs e)
        {
            if(admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes() == 0)
            {
                AbrirFormEnPanel(new frmGenerarEncuentros(false));
            }
            else
            {
                MessageBox.Show("Ya se han generado y registrados los encuentros");
                AbrirFormEnPanel(new frmGenerarEncuentros(true));
                
            }
        }

        private void btnAsignarColegiados_Click(object sender, EventArgs e)
        {
            int numeroEncuentros = admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes();
            if (numeroEncuentros == 0)
            {
                MessageBox.Show("Ya se han asignado fecha y colegiados a los encuentros");
            }
            else
            {
                AbrirFormEnPanel(new frmRegistrarPartido());
            }
            
        }

        private void btnCambiarGrupo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCambiarEstadioPartido());
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {

        }

        //metodo que controla el evento de arrastrar pantalla
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //evento para minimizar pantalla
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
    }
}
