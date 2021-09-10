using Control.AdmColegiados;
using Control.AdmEncuentros;
using Control.AdmEncuentrosGenerados;
using Control.AdmEquipos;
using GestionDeColegiados.FrmsArbitro;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class MenuPrincipal : Form
    {

        //dll y variables necesarios para poder mover de lugar la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        private Color colorDefaultMin;
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();
        private AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private AdmEquipo admEquipo = AdmEquipo.getEquipo();
        private AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmColegiado admColegiado = AdmColegiado.getAdmCol();

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


       /// <summary>
       /// Metodo encargado de pintar cada ventana en un panel
       /// </summary>
       /// <param name="formhija">Form que será pintado en un panel</param>
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

        private void btnNuevoGrupoColegiados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmNuevoGrupoColegiado());
        }

        private void btnVerTodosColegiados_Click(object sender, EventArgs e)
        {
            if (admColegiado.obtenerCantidadColegiado() == 0)
            {
                MessageBox.Show("No se han registrado colegiados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AbrirFormEnPanel(new frmNuevoGrupoColegiado());
            }
            else
            {
                frmVerTodosLosColegiados verColegiados = new frmVerTodosLosColegiados();
                verColegiados.ShowDialog();
            }
        }

        private void btnAnadirEquipo_Click(object sender, EventArgs e)
        {
            if (admEquipo.ObtenerCantidadEquipo() < 10)
            {
                AbrirFormEnPanel(new frmNuevoEquipo());
            }
            else
            {
                AbrirFormEnPanel(new frmListaEquipos());
            }
        }

        private void ExaminarAccesibilidadGenerarEncuentrosPorCantidadEquipo()
        {
            if (admEquipo.ObtenerCantidadEquipo() == 10)
            {
                ExaminarAccesibilidadGenerarEncuentros();
            }
            else
            {
                string faltaEquipo = "Para generar encuentros debe existir 10 equipos registrados" +
                    "\n\rExisten: " + admEquipo.ObtenerCantidadEquipo() + " Equipos registrados." +
                    " Por favor ingrese: " + (10 - admEquipo.ObtenerCantidadEquipo()) + " más";
                MessageBox.Show(faltaEquipo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AbrirFormEnPanel(new frmNuevoEquipo());
            }
        }

        private void ExaminarAccesibilidadGenerarEncuentros()
        {
            if (admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes() == 0)
            {
                AbrirFormEnPanel(new frmGenerarEncuentros(false));
            }
            else
            {
                MessageBox.Show("Ya se han generado y registrados los encuentros");
                AbrirFormEnPanel(new frmGenerarEncuentros(true));
            }
        }
        private void btnGenerarEncuentros_Click(object sender, EventArgs e)
        {
            int cantEncuentrosDefinidos = admEncuentrosDefinidos.ObtenerNumeroPartidosPorJugar();
            if (cantEncuentrosDefinidos == 0)
            {
                ExaminarAccesibilidadGenerarEncuentrosPorCantidadEquipo();
            }
            else
            {
                MessageBox.Show("Existen: " + cantEncuentrosDefinidos + " Por jugar, no se puede Generar Encuentros");
                AbrirFormEnPanel(new frmTodosLosEncuentrosDefinidos());
            }

        }

        private void btnAsignarColegiados_Click(object sender, EventArgs e)
        {
            int numeroEncuentros = admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes();
            if (numeroEncuentros == 0)
            {
                MessageBox.Show("No hay encuentros disponibles para asignar fecha y colegiados ");
            }
            else
            {
                AbrirFormEnPanel(new frmRegistrarPartido());
            }

        }

        private void btnCambiarEstadio_Click(object sender, EventArgs e)
        {
            if (admEncuentrosDefinidos.ObtenerNumeroPartidosPorJugar() == 0)
            {
                MessageBox.Show("No hay Partidos por definir. Por favor, genere encuentros primero");
            }
            else
            {
                AbrirFormEnPanel(new frmCambiarEstadioPartido());
            }
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

        private void btnVerEncuentrosDefinidos_Click(object sender, EventArgs e)
        {
            if (admEncuentrosDefinidos.ObtenerNumeroPartidosPorJugar() == 0)
            {
                MessageBox.Show("No hay Partidos por definir. Por favor, genere encuentros primero");
            }
            else
            {
                AbrirFormEnPanel(new frmTodosLosEncuentrosDefinidos());
            }
        }

        private void btnVerTodosPartidos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmVerCompeticion(true));
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            flpVerCompetencia.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            btnIniciarSesion frm = new btnIniciarSesion();
            frm.Show();
        }
        public void abrirFormNuevoEquipo()
        {
            if (admEquipo.ObtenerCantidadEquipo() < 10)
            {
                AbrirFormEnPanel(new frmNuevoEquipo());
            }
            else
            {
                AbrirFormEnPanel(new frmListaEquipos());
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            abrirFormNuevoEquipo();
        }

        private void ExaminarAccesibilidadEditarEquipoPorEncuentrosGenerados()
        {
            if (admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes() == 0 && admEncuentroFinalizado.GetCantidadEncuentrosFinalizados() == 0 && admEncuentrosDefinidos.ObtenerCantidadEncuentrosDefinidos() == 0)
            {
                AbrirFormEnPanel(new frmVerTodos());
            }
            else
            {
                MessageBox.Show("Existen encuentros generados o definidos. No se pueden eliminar o editar equipos.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (admEquipo.ObtenerCantidadEquipo() > 0)
            {
                ExaminarAccesibilidadEditarEquipoPorEncuentrosGenerados();
            }
            else
            {
                MessageBox.Show("Ingrese primero algunos equipos");
                AbrirFormEnPanel(new frmNuevoEquipo());
            }
        }
    }
}
