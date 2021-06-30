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
            if( hayVacios !=true ) {
                MessageBox.Show(Nombre + ", " + numJugadores + ", " + directorNombre + ", " + presidenteNombre);
               admEquipo.GuardarDatos(Nombre, validacionGUI.EsInt(numJugadores), directorNombre, presidenteNombre);
                
            } else {
                MessageBox.Show("Hay ciertos campos vacios");
            }
        }
        
        
    }
}
