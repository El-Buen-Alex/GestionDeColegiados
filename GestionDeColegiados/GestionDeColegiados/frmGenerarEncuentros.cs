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
        public frmGenerarEncuentros()
        {
            InitializeComponent();
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
            if (admEquipo.cantidadEquiposRegistrados() <10)
            {
                MessageBox.Show("No existen Equipos registrados, primero ingrese algunos!");
            }
            else
            {
                admGenerarEncuentros.generarEncuentrosAleatorios(listaContenedoresLocal, listaContenedoresVisitante);
            }
        }

       /* private void generar_Click(object sender, EventArgs e)
        {
            nombreEquipo =admEquipo.extraerNombreEquipos();
            if (nombreEquipo.Count == 0)
            {
                MessageBox.Show("No existen Equipos registrados, primero ingrese algunos!");
            }
            else if(nombreEquipo.Count==10)
            {
                admEquipo.llenarCamposTextos(local, 1,6);
                admEquipo.llenarCamposTextos(visitante, 6, 11);

            }
            else
            {
                MessageBox.Show("Para generar encuentros deben haber 10 equipos. "+nombreEquipo.Count+" es la cantidad de equipos existentes.");
            }
            
        }*/
       

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        /*
        private void guardarDatos_Click(object sender, EventArgs e)
        {
            nombreEquipo = admEquipo.extraerNombreEquipos();
            if (nombreEquipo.Count == 0)
            {
                MessageBox.Show("No existen Equipos registrados, primero ingrese algunos!");
            }
            else if(!(local.Text=="")==true && !(visitante.Text=="")==true)
            {
               admEquipo.registrarEncuentros("estado");
            }
            else
            {
                MessageBox.Show("No ha generado encuentros!");
            }
        }*/
    }
}
