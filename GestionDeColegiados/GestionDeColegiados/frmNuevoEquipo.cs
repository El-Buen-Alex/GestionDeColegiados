using Control;
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
    public partial class frmNuevoEquipo : Form
    {
        ValidacionGUI validacionGUI = new ValidacionGUI();
        AdmEquipo admEquipo = AdmEquipo.getEquipo();
        registroEquipoMaximoException excepcionEquipos = null;
        public frmNuevoEquipo()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            int id = 0;
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
            catch(registroEquipoMaximoException mensaje)
            {
                MessageBox.Show(mensaje.ToString());
            }
            
            
        }
        
        
    }
}
