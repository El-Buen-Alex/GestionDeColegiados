using Control.AdmColegiados;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmVerTodosLosColegiados : Form
    {
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmVerTodosLosColegiados()
        {
            InitializeComponent();
            admColegiado.llenarDatos(dgvListarColegiados);
        }
    }
}
