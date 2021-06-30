using Data;
using Model.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmEquipos
{
    public class AdmEquipo
    {
        Equipo equipo = null;
        List<Equipo> listaEquipo = null;
        private static AdmEquipo admEquipo = null;
        Datos datos = new Datos();
        internal List<Equipo> Lista { get => listaEquipo; set => listaEquipo = value; }

        private AdmEquipo()
        {

        }
        public static AdmEquipo getEquipo()
        {
            if (admEquipo == null)
            {
                admEquipo = new AdmEquipo();
            }
            return admEquipo;
        }

        public void GuardarDatos(string nombre, int numJugadores, string directorNombre, string presidenteNombre)
        {
            listaEquipo = new List<Equipo>();
            equipo = new Equipo(0,nombre, numJugadores, directorNombre, presidenteNombre);
            if (equipo != null)
            {
                Console.WriteLine(equipo.NombreEquipo + ", " + equipo.NumeroJugadores + ", " + equipo.NumeroJugadores + ", " + equipo.NombreDirectoTecnico);
                listaEquipo.Add(equipo);
                registrarEquipo(equipo);
            }
        }

        private void registrarEquipo(Equipo equipo)
        {
            int id = 0;
            id = datos.InsertarEquipo(equipo);
            if (id == 0)
            {
                MessageBox.Show("Error al registrar el equipo");
            }
            else
            {
                MessageBox.Show("Registro exitoso!");
            }
        }
    }
}
