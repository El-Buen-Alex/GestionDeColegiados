using Control;
using Control.AdmEquipos;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmNuevoEquipo : Form
    {
        ValidacionGUI validacionGUI = new ValidacionGUI();
        AdmEquipo admEquipo = AdmEquipo.getEquipo();
        public frmNuevoEquipo()
        {
            InitializeComponent();
        }

        private void RefrezcarVista()
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.abrirFormNuevoEquipo();
        }

        /* Evento que desata en cadena la funcionalidad de registrar un nuevo equipo */
        private void registrar_Click(object sender, EventArgs e)
        {
            String Nombre = nombre.Text.Trim(),
                numJugadores = numjugadores.Text,
                directorNombre = director.Text,
                presidenteNombre = presidente.Text;

            bool hayVacios = validacionGUI.validarVacios(Nombre, numJugadores, directorNombre, presidenteNombre);   //Valida campos vacios al recuperar la informacion presente en los TextBox
            try
            {
                if (admEquipo.cantidadEquiposRegistrados() < 10)                                                                /*Comprueba la existencia de espacio para registrar un nuevo equipos*/
                {                                                                                                                      
                    if (hayVacios != true)
                    {
                        MessageBox.Show(Nombre + ", " + numJugadores + ", " + directorNombre + ", " + presidenteNombre);
                        admEquipo.GuardarDatos(Nombre, validacionGUI.AInt(numJugadores), directorNombre, presidenteNombre);       /*Se ejecuta el método que nos permitirá guardar la información*/
                        RefrezcarVista();
                    }
                    else
                    {
                        MessageBox.Show("Hay ciertos campos vacios");
                    }
                }
                else
                {
                    throw new registroEquipoMaximoException("EL registro máximo de equipos es de 10");
                }
            }
            catch (registroEquipoMaximoException) // Uso de las excepciones personalizadas al querer ingresar un nuevo equipo cuando ha alcanzado el límite se desata.
            {
                MessageBox.Show("EL registro máximo de equipos es de 10");
            }


        }
        /*Evento que permite el tecleo de palabras, uso de la tecla de borrado, la barra espaciadora y usar punto*/
        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Space) && e.KeyChar != '.')
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /*Evento que permite solo el ingreso de numeros en el campo de texto*/
        private void numjugadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numjugadores.Text = "";
                e.Handled = true;
                return;
            }
            
        }
        /*Evento que permite el tecleo de palabras, uso de la tecla de borrado y la barra espaciadora*/
        private void director_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                e.Handled = true;
                return;
            }
        }
        /*Evento que permite el tecleo de palabras, uso de la tecla de borrado y la barra espaciadora*/
        private void presidente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void numjugadores_TextChanged(object sender, EventArgs e)
        {
            if (validacionGUI.AInt(numjugadores.Text) < 0 || validacionGUI.AInt(numjugadores.Text) > 12)
            {
                MessageBox.Show("Solo se permite el ingreso de 12 jugadores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numjugadores.Text = "";
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void editar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
