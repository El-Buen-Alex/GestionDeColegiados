using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados.FrmsColegiado 
{
    public partial class frmElimAgregarArbitro : Form 
    {
        //dll y variables necesarios para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;

        public frmElimAgregarArbitro (string arbitro) {
            InitializeComponent();
            lblAgregar.Text += arbitro;
        }

        //metodo que controla el evento de arrastrar pantalla
        private void PanelBarraTitulo_MouseDown (object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //evento para cerrar pantalla
        private void pbCerrar_Click (object sender, EventArgs e) {
            Close();
        }

        //Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador
        private void pbCerrar_MouseEnter (object sender, EventArgs e) {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor = Color.FromArgb(202, 49, 32);
        }

        private void pbCerrar_MouseLeave (object sender, EventArgs e) {
            pbCerrar.BackColor = colorDefaultClose;
        }

        private void validarNumeros_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        private void validarLetras_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                (e.KeyChar != Convert.ToChar(Keys.Space))) {
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click (object sender, EventArgs e) {
            MessageBox.Show("Sus datos fueron actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
