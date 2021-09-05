using Control;
using Control.AdmEquipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmEditarEquipo : Form
    {
        AdmEquipo equipo = AdmEquipo.getEquipo();
        ValidacionGUI valida = new ValidacionGUI();
        public frmEditarEquipo(String id)
        {
            InitializeComponent();
            equipo.LlenarCampos(idEquipo, nombre, numjugadores, director, presidente, id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de cancelar!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String Nombre = nombre.Text.Trim(),
               numJugadores = numjugadores.Text,
               directorNombre = director.Text,
               presidenteNombre = presidente.Text,
               id=idEquipo.Text;
                
            bool hayVacios = valida.validarVacios(Nombre, numJugadores, directorNombre, presidenteNombre);   //Valida campos vacios al recuperar la informacion presente en los TextBox
            if (hayVacios != true)
            {
                MessageBox.Show(Nombre + ", " + numJugadores + ", " + directorNombre + ", " + presidenteNombre);
                equipo.ActualizarDatos(valida.AInt(id), Nombre, valida.AInt(numJugadores), directorNombre, presidenteNombre);       /*Se ejecuta el método que nos permitirá guardar la información*/

            }
            else
            {
                MessageBox.Show("Hay ciertos campos vacios");
            }
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            
            
            bool hayVacios = valida.validarVacios(nombre.Text.Trim(), numjugadores.Text, director.Text, presidente.Text);
            if (hayVacios!=true)
            {
                resultado = MessageBox.Show("¡Está seguro de regresar al apartado anterior, \n Si no ha dado clic en el botón Actualizar se perderán sus datos!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resultado == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                resultado = MessageBox.Show("¡Está seguro de regresar al apartado anterior, \n Hay ciertor campos vacíos!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resultado == DialogResult.Yes)
                {
                    Close();
                }
            }
            

        }
    }
}
