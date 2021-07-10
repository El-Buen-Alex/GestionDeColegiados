using Control.AdmEquipos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmListaEquipos : Form
    {
        private List<Label> listaContenedores = new List<Label>();
        private AdmEquipo admEquipo = AdmEquipo.getEquipo();
        public frmListaEquipos()
        {
            InitializeComponent();
            listaContenedores.Add(lblEquipo1);
            listaContenedores.Add(lblEquipo2);
            listaContenedores.Add(lblEquipo3);
            listaContenedores.Add(lblEquipo4);
            listaContenedores.Add(lblEquipo5);
            listaContenedores.Add(lblEquipo6);
            listaContenedores.Add(lblEquipo7);
            listaContenedores.Add(lblEquipo8);
            listaContenedores.Add(lblEquipo9);
            listaContenedores.Add(lblEquipo10);
            admEquipo.LlenarEquipos(listaContenedores);
        }
    }
}
