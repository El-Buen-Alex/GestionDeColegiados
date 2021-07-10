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
        List<Equipo> listaEquipo = new List<Equipo>();
        List<int> indexNumeroAleatorio = new List<int>();
        List<int> indexRegistro = new List<int>();
        private static AdmEquipo admEquipo = null;
        DatosColegiados datos = new DatosColegiados();
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
        public int cantidadEquiposRegistrados()
        {
            extraerEquipos();
            return listaEquipo.Count;
        }

        public void GuardarDatos(string nombre, int numJugadores, string directorNombre, string presidenteNombre)
        {
            equipo = new Equipo(0,nombre, numJugadores, directorNombre, presidenteNombre);
            if (equipo != null)
            {
                Console.WriteLine(equipo.NombreEquipo + ", " + equipo.NumeroJugadores + ", " + equipo.NumeroJugadores + ", " + equipo.NombreDirectoTecnico);
                listaEquipo.Add(equipo);
                registrarEquipo(equipo);
            }
        }

        public void LlenarEquipos(List<Label> listaContenedores)
        {
            extraerEquipos();
            for (int x=0; x < listaEquipo.Count; x++)
            {
                listaContenedores[x].Text = listaEquipo[x].NombreEquipo;
            }
        }

        public int ObtenerCantidadEquipo()
        {
            return datos.ObtenerCantidadEquipoRegistrados();
        }
        public Equipo ObtenerEquipoPorId(int id)
        {
            return datos.ObtenerEquipoPorId(id);
        }

        public void llenarCamposTextos(TextBox cajaTexto, int numBase, int numTope)
        {
            cajaTexto.Text = "";
            extraerEquipos();
            indexNumeroAleatorio = generarNumeros(numBase, numTope);
            foreach (int indexAleatorio in indexNumeroAleatorio)
            {
                cajaTexto.Text += listaEquipo[indexAleatorio - 1].NombreEquipo + "\r\n\r\n\r ";
               
            }
        }

       public void registrarEncuentros(string tipoEquipo)
        {
            string nombreEquipo = "";
            int idEquipo = 0;
            int id = 0;
            extraerEquipos();

            foreach (int indexAleatorio in indexRegistro)
            {
                nombreEquipo=listaEquipo[indexAleatorio - 1].NombreEquipo.ToString();
                idEquipo=Convert.ToInt32(listaEquipo[indexAleatorio - 1].IdEquipo);
                id=datos.registrarEncuentrosGenerados(nombreEquipo, tipoEquipo, idEquipo);

            }
           
            if (id == '0')
            {
                MessageBox.Show("Error al registrar el encuentro");
            }
            else
            {
                MessageBox.Show("Registro exitoso!");
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

        public List<Equipo> extraerEquipos()
        {
            listaEquipo = datos.consultarEquipos();
            return listaEquipo;
            
        }
        
        public List<int> generarNumeros(int x, int y)
        {

            List<int> listaAleatorio = new List<int>();
            int numeroGenerado = 0;
            while (listaAleatorio.Count < 5)
            {
                numeroGenerado = new Random().Next(x,y);
                if (!listaAleatorio.Contains(numeroGenerado))
                {
                    listaAleatorio.Add(numeroGenerado);
                    indexRegistro.Add(numeroGenerado);
                }
            }
            return listaAleatorio;
        }

        
    }
}
