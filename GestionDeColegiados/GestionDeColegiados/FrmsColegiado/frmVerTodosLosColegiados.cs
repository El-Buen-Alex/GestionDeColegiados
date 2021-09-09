using Control.AdmColegiados;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using GestionDeColegiados.FrmsColegiado;

namespace GestionDeColegiados
{
    /// <summary>
    /// Formulario para ver, editar y eliminar (Áribtros y colegiado).
    /// </summary>
    public partial class frmVerTodosLosColegiados : Form
    {
        /// <summary>
        /// DLL y variables necesarias para poder mover el formulario.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmVerTodosLosColegiados ()
        {
            InitializeComponent();
            admColegiado.llenarComboIdColegiado(cmbIdArbitro);
        }

        /// <summary>
        /// Método que controla el evento de arrastrar pantalla.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void PanelBarraTitulo_MouseDown (object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Evento para cerrar pantalla.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void pbCerrar_Click (object sender, System.EventArgs e) {
            Close();
        }

        /// <summary>
        /// Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void pbCerrar_MouseEnter (object sender, System.EventArgs e) {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor = Color.FromArgb(202, 49, 32);
        }

        /// <summary>
        /// Eventos que generan un efecto visual en cuanto el mouse sale por dicho controlador.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void pbCerrar_MouseLeave (object sender, System.EventArgs e) {
            pbCerrar.BackColor = colorDefaultClose;
        }

        /// <summary>
        /// Evento click para el botón buscar.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnBuscar_Click (object sender, System.EventArgs e) {
            if (cmbIdArbitro.Text.CompareTo("") != 0) {
                admColegiado.llenarDatosGrivColegiado(dgvListarColegiados, cmbIdArbitro);
                btnEditar.Enabled = true;
                btnEliminarArbitro.Enabled = true;
                btnEliminarColegiado.Enabled = true;
            } else {
                MessageBox.Show("Debe seleccionar algún grupo para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Evento click para el botón editar.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>>
        private void btnEditar_Click (object sender, System.EventArgs e) {
            DataGridViewRow filaSeleccionada = dgvListarColegiados.CurrentRow;
            string arbitro = filaSeleccionada.Cells[0].Value.ToString();
            frmEditarArbitro frmEditar = new frmEditarArbitro(arbitro,cmbIdArbitro.Text);
            admColegiado.recogerDatosEditar(dgvListarColegiados);
            frmEditar.ShowDialog();
            admColegiado.llenarDatosGrivColegiado(dgvListarColegiados, cmbIdArbitro);
        }

        /// <summary>
        /// Evento click para el botón eliminar árbitro.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>>
        private void btnEliminarArbitro_Click (object sender, System.EventArgs e) {
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de eliminar un árbitro!\nSi acepta tendrá que agregar uno nuevo","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes) {
                DataGridViewRow row = dgvListarColegiados.CurrentRow;
                string arbitro = row.Cells[0].Value.ToString();
                frmElimAgregarArbitro frmAgregar = new frmElimAgregarArbitro(arbitro,cmbIdArbitro.Text);
                admColegiado.recogerDatosEliminar(dgvListarColegiados);
                frmAgregar.ShowDialog();
                admColegiado.llenarDatosGrivColegiado(dgvListarColegiados, cmbIdArbitro);
            }
        }

        /// <summary>
        /// Evento click para el botón eliminar colegiado.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>>
        private void btnEliminarColegiado_Click (object sender, System.EventArgs e) {
            bool eliminado = false;
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de eliminar el "+cmbIdArbitro.Text+" de colegiados!", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes) {
                eliminado = admColegiado.eliminarColegiado(cmbIdArbitro.Text);
                if(eliminado == true) {
                    admColegiado.llenarComboIdColegiado(cmbIdArbitro);
                    dgvListarColegiados.Rows.Clear();
                }
            }
        }
    }
}