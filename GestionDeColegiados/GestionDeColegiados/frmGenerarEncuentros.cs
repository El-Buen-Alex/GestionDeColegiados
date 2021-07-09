using Control.AdmEncuentrosGenerados;
using Control.AdmEquipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmGenerarEncuentros : Form
    {
        AdmEquipo admEquipo = AdmEquipo.getEquipo();
        AdmGenerarEncuentros admGenerarEncuentros = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
        private List<Label> listaContenedoresLocal = new List<Label>();
        private List<Label> listaContenedoresVisitante = new List<Label>();
        private List<PictureBox> listaPictureBox = new List<PictureBox>();
        public frmGenerarEncuentros(bool estado)
        {
            InitializeComponent();
            inciarContenedores();
            agregarPbaLista();
            cambiarAccesibilidadPictureBox(listaPictureBox, false);
            cambiarAccesibilidad(listaContenedoresLocal, false);
            cambiarAccesibilidad(listaContenedoresVisitante, false);
            if (estado)
            {
                lblOrden.Visible = false;
                btnGenerarEncuentros.Visible = false;
                btnGuardarEncuentros.Visible = false;
                lblTitulo.Text = "ENCUENTROS PENDIENTES" +
                    "\r\n DE FECHA Y COLEGIADOS";
                int limiteInferiorPb=0, limiteSuperiorPb=0;
                for(int x=0; x <admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes(); x++)
                {
                    
                    admGenerarEncuentros.LlenarTuplas(listaContenedoresLocal[x], listaContenedoresVisitante[x], x);
                    listaContenedoresLocal[x].Visible = true;
                    listaContenedoresVisitante[x].Visible = true;
                    limiteSuperiorPb = limiteInferiorPb+3;
                    ActivarPictureBox(limiteInferiorPb, limiteSuperiorPb);
                    limiteInferiorPb += 3;
                }
            }
            else
            {
                btnGuardarEncuentros.Enabled = false;
            }

        }
        private void ActivarPictureBox(int LimiteInferior, int LimiteSuperior)
        {
            for (int i =LimiteInferior; i <LimiteSuperior; i++)
            {
                listaPictureBox[i].Visible = true;
            }
        }
        private void cambiarAccesibilidadPictureBox(List<PictureBox> listaContenedores, bool estado)
        {
            foreach (PictureBox pictureBox in listaContenedores)
            {
                pictureBox.Visible = estado;
            }

        }
        private void cambiarAccesibilidad(List<Label> listaContenedores, bool estado)
        {
            foreach(Label contenedor in listaContenedores)
            {
                contenedor.Visible = estado;
            }
            
        }
        private void agregarPbaLista()
        {
            listaPictureBox.Add(pictureBox1);
            listaPictureBox.Add(pictureBox2);
            listaPictureBox.Add(pictureBox3);
            listaPictureBox.Add(pictureBox4);
            listaPictureBox.Add(pictureBox5);
            listaPictureBox.Add(pictureBox6);
            listaPictureBox.Add(pictureBox7);
            listaPictureBox.Add(pictureBox8);
            listaPictureBox.Add(pictureBox9);
            listaPictureBox.Add(pictureBox10);
            listaPictureBox.Add(pictureBox11);
            listaPictureBox.Add(pictureBox12);
            listaPictureBox.Add(pictureBox13);
            listaPictureBox.Add(pictureBox14);
            listaPictureBox.Add(pictureBox15);

        }
        private void inciarContenedores()
        {
            listaContenedoresLocal.Add(lblEquipo1);
            listaContenedoresLocal.Add(lblEquipo2);
            listaContenedoresLocal.Add(lblEquipo3);
            listaContenedoresLocal.Add(lblEquipo4);
            listaContenedoresLocal.Add(lblEquipo5);
            listaContenedoresVisitante.Add(lblEquipo6);
            listaContenedoresVisitante.Add(lblEquipo7);
            listaContenedoresVisitante.Add(lblEquipo8);
            listaContenedoresVisitante.Add(lblEquipo9);
            listaContenedoresVisitante.Add(lblEquipo10);
        }
        private void generarEncuentros_Click(object sender, EventArgs e)
        {
            cambiarAccesibilidad(listaContenedoresLocal, true);
            cambiarAccesibilidad(listaContenedoresVisitante, true);
            cambiarAccesibilidadPictureBox(listaPictureBox, true);
            
            admGenerarEncuentros.generarEncuentrosAleatorios(listaContenedoresLocal, listaContenedoresVisitante);
                
            btnGuardarEncuentros.Enabled = true;
        }

        private void guardarDatos_Click(object sender, EventArgs e)
        {
            string guardo = admGenerarEncuentros.guardarEncuentrosAleatorios();

            MessageBox.Show(guardo);
            if (guardo[0] == 'S')
            {
                btnGenerarEncuentros.Visible = false;
                btnGuardarEncuentros.Visible = false;
            }
        }
        
    }
}
