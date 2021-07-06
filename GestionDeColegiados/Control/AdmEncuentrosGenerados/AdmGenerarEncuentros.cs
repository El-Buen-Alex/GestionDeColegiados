using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;
using Control.AdmEquipos;
using System.Windows.Forms;
using Model.Equipo;

namespace Control.AdmEncuentrosGenerados
{
    public class AdmGenerarEncuentros
    {
        private List<EncuentroGenerado> listaEncuentrosGenerados;
        private EncuentroGenerado encuentroAuxiliar = null;
        private static AdmGenerarEncuentros admGenerarEncuentros=null;
        private AdmEquipo admEquipo = AdmEquipo.getEquipo();
        private List<Equipo> listaEquipos;
        private List<int> numerosAleatoriosLocal = new List<int>();
        private List<int> numerosAleatoriosVisitante = new List<int>();

        public List<EncuentroGenerado> ListaEncuentrosGenerados { get => listaEncuentrosGenerados; set => listaEncuentrosGenerados = value; }
        private AdmGenerarEncuentros()
        {
            listaEncuentrosGenerados = new List<EncuentroGenerado>();
        }
        public static AdmGenerarEncuentros getAdmadmGenerarEncuentros()
        {
            if (admGenerarEncuentros == null)
            {
                admGenerarEncuentros = new AdmGenerarEncuentros();
            }
            return admGenerarEncuentros;
        }

        public void generarEncuentrosAleatorios(List<Label> listaContenedoresLocal, List<Label> listaContenedoresVisitante)
        {
            numerosAleatoriosLocal = generListaAleatoria(1, 6);
            numerosAleatoriosVisitante = generListaAleatoria(6, 11);
            listaEquipos = admEquipo.extraerEquipos();
            llenarNombreEquipos(listaContenedoresLocal,numerosAleatoriosLocal, listaEquipos);
            llenarNombreEquipos(listaContenedoresVisitante,numerosAleatoriosVisitante, listaEquipos);

        }
       private string llenarNombreEquipos(List<Label> contenedores,List<int> listaAleatoria, List<Equipo> equipos)
        {
            string nombreEquipos = "";
            Console.WriteLine("vine  ");
            int x = 0;
            foreach (int posicionAleatoria in listaAleatoria)
            {
                Console.WriteLine(posicionAleatoria);
                contenedores[x].Text = equipos[posicionAleatoria - 1].NombreEquipo;
                x++;
            }
            return nombreEquipos;
        }
       
        private List<int> generListaAleatoria(int limiteInferior, int limiteSuperior)
        {
            List<int> listaAleatoria = new List<int>();
            int numeroGenerado = 0;
            while (listaAleatoria.Count()< 5)
            {
                numeroGenerado = new Random().Next(limiteInferior, limiteSuperior);
                if (!listaAleatoria.Contains(numeroGenerado))
                {
                    Console.WriteLine(numeroGenerado);
                    listaAleatoria.Add(numeroGenerado);
                }
            }
            return listaAleatoria;
        }
    }
}
