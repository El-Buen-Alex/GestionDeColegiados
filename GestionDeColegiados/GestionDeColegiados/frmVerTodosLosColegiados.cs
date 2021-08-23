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
            admColegiado.llenarComboIdColegiado(cmbIdArbitro);
        }

        private void btnBuscar_Click (object sender, System.EventArgs e) {
            admColegiado.llenarDatosGrivColegiado(dgvListarColegiados, cmbIdArbitro);
        }

        private void btnEditar_Click (object sender, System.EventArgs e) {
            dgvEditar.Visible = true;
            btnActualizar.Visible = true;
        }

        private void btnEliminar_Click (object sender, System.EventArgs e) {
            dgvEditar.Visible = false;
            btnActualizar.Visible = false;
            MessageBox.Show("¡Está seguro de eliminar!\nSi acepta tendrá que agregar uno nuevo","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
        }
    }
}
