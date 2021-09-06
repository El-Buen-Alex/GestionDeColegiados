using Control.AdmColegiados;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using GestionDeColegiados.FrmsColegiado;
using System;

namespace GestionDeColegiados
{
    public partial class frmVerTodosLosColegiados : Form
    {
        //dll y variables necesarios para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmVerTodosLosColegiados()
        {
            InitializeComponent();
            admColegiado.llenarComboIdColegiado(cmbIdArbitro);
        }
        
        //metodo que controla el evento de arrastrar pantalla
        private void PanelBarraTitulo_MouseDown (object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //evento para cerrar pantalla
        private void pbCerrar_Click (object sender, System.EventArgs e) {
            Close();
        }

        //Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador
        private void pbCerrar_MouseEnter (object sender, System.EventArgs e) {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor = Color.FromArgb(202, 49, 32);
        }

        private void pbCerrar_MouseLeave (object sender, System.EventArgs e) {
            pbCerrar.BackColor = colorDefaultClose;
        }

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

        private void btnEditar_Click (object sender, System.EventArgs e) {
            DataGridViewRow filaSeleccionada = dgvListarColegiados.CurrentRow;
            string arbitro = filaSeleccionada.Cells[0].Value.ToString();
            frmEditarArbitro frmEditar = new frmEditarArbitro(arbitro,cmbIdArbitro.Text);
            admColegiado.recogerDatosEditar(dgvListarColegiados);
            frmEditar.ShowDialog();
            admColegiado.llenarDatosGrivColegiado(dgvListarColegiados, cmbIdArbitro);
        }

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

        private void btnEliminarColegiado_Click (object sender, System.EventArgs e) {
            bool eliminado = false;
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de eliminar el "+cmbIdArbitro.Text+" de colegiados!", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes) {
                eliminado = admColegiado.eliminarColegiado(cmbIdArbitro.Text,dgvListarColegiados);
                if(eliminado == true) {
                    admColegiado.llenarComboIdColegiado(cmbIdArbitro);
                    dgvListarColegiados.Rows.Clear();
                }
            }
        }
    }
}