using Control.AdmEncuentrosGenerados;
using Control.AdmEquipos;
using System;
using System.Collections.Generic;
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

        public List<Label> ListaContenedoresLocal { get => listaContenedoresLocal; set => listaContenedoresLocal = value; }
        public List<Label> ListaContenedoresVisitante { get => listaContenedoresVisitante; set => listaContenedoresVisitante = value; }


        /// <summary>
        /// Constructor del form de Generar encuentro
        /// </summary>
        /// <remarks>Si el parametro ingresado es falso, se puede generar, caso contrario se muestran los encuentros</remarks>
        /// <param name="estado">Define si los encuentros ya han sido generados o aún no</param>
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
                int limiteInferiorPb = 0, limiteSuperiorPb = 0;
                for (int x = 0; x < admGenerarEncuentros.obtnerNumeroEncuentrosGeneradosPendientes(); x++)
                {

                    admGenerarEncuentros.LlenarTuplas(listaContenedoresLocal[x], listaContenedoresVisitante[x], x);
                    listaContenedoresLocal[x].Visible = true;
                    listaContenedoresVisitante[x].Visible = true;
                    limiteSuperiorPb = limiteInferiorPb + 3;
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
            /*por cada encuentro pendiente se deben mostrar 3 picturebox de la lista 
            se añade el limite inferior desde donde se va a habilitar hasta doonde se va a 
            habilitar dichos picturebox*/
            for (int i = LimiteInferior; i < LimiteSuperior; i++)
            {
                listaPictureBox[i].Visible = true;
            }
        }
        private void cambiarAccesibilidadPictureBox(List<PictureBox> listaContenedores, bool estado)
        {
            /*establecemos que todos los picturebox se mostraran en un estado
            que se pasará por parametro*/
            foreach (PictureBox pictureBox in listaContenedores)
            {
                pictureBox.Visible = estado;
            }

        }
        private void cambiarAccesibilidad(List<Label> listaContenedores, bool estado)
        {
            /*establecemos que todos los labels se mostraran en un estado
           que se pasará por parametro*/
            foreach (Label contenedor in listaContenedores)
            {
                contenedor.Visible = estado;
            }

        }
        private void agregarPbaLista()
        {
            //añadimos los pciturebox a la lista
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
            //añadimos los labels a la lista
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
            //mostramos los label y picturebox necesarios para generar encuentros
            cambiarAccesibilidad(listaContenedoresLocal, true);
            cambiarAccesibilidad(listaContenedoresVisitante, true);
            cambiarAccesibilidadPictureBox(listaPictureBox, true);
            bool genero=admGenerarEncuentros.generarEncuentrosAleatorios(listaContenedoresLocal, listaContenedoresVisitante);
            //una vez generado los encuentros se activa la opcion de guardar encuentros
            if (genero)
            {
                btnGuardarEncuentros.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se logró generar Encuentros");
            }
        }

        private void guardarDatos_Click(object sender, EventArgs e)
        {
            //se guarda los encuentos y retorna un mensaje respuesta a la acción de guardar
            string guardo = admGenerarEncuentros.guardarEncuentrosAleatorios();
            MessageBox.Show(guardo);
            if (guardo[0] == 'S')
            {
                //si guarda con exito, los controladores se deshabilitan
                btnGenerarEncuentros.Enabled = false;
                btnGuardarEncuentros.Enabled = false;
                btnGenerarEncuentros.Visible = false;
                btnGuardarEncuentros.Visible = false;
            }
        }

    }
}
