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

        private void registrar_Click(object sender, EventArgs e)
        {
            String Nombre = nombre.Text.Trim(),
                numJugadores = numjugadores.Text,
                directorNombre = director.Text,
                presidenteNombre = presidente.Text;

            bool hayVacios = validacionGUI.validarVacios(Nombre, numJugadores, directorNombre, presidenteNombre);
            try
            {
                if (admEquipo.cantidadEquiposRegistrados() < 10)
                {
                    if (hayVacios != true)
                    {
                        MessageBox.Show(Nombre + ", " + numJugadores + ", " + directorNombre + ", " + presidenteNombre);
                        admEquipo.GuardarDatos(Nombre, validacionGUI.EsInt(numJugadores), directorNombre, presidenteNombre);

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
            catch (registroEquipoMaximoException mensaje)
            {
                MessageBox.Show(mensaje.ToString());
            }


        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Space) && e.KeyChar != '.')
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void numjugadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void director_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void presidente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
