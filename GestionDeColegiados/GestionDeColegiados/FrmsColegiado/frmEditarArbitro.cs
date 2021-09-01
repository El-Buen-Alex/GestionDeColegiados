using Control;
using Control.AdmColegiados;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestionDeColegiados.FrmsColegiado 
{
    public partial class frmEditarArbitro : Form 
    {
        //dll y variables necesarios para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        ValidacionGUI validacionGUI = new ValidacionGUI();
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmEditarArbitro (string arbitro, string idColegiado) {
            InitializeComponent();
            lblEditar.Text += arbitro;
            lblID.Text = idColegiado;
        }

        //Evento Load en frm
        private void frmEditarArbitro_Load (object sender, EventArgs e) {
            admColegiado.LlenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
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

        private void btnActualizar_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
            bool cedulaRepetida = admColegiado.validarCedula(txtCedula);
            if (vacio == true) {
                MessageBox.Show("Hay ciertos campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cedulaRepetida == true) {
                MessageBox.Show("El árbitro que ingresó ya se encuentra registrado!!\nIngrese uno nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (vacio != true && cedulaRepetida != true) {
                DialogResult resultado;
                resultado = MessageBox.Show("¡Está seguro de actualizar!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes) {
                    string cedula = txtCedula.Text,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        domicilio = txtDomicilio.Text,
                        email = txtEmail.Text,
                        telefono = txtTelefono.Text;
                    admColegiado.editarArbitro(lblID.Text, cedula, nombre, apellido, domicilio, email, telefono);
                    MessageBox.Show("Sus datos fueron actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void btnCancelar_Click (object sender, EventArgs e) {
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de cancelar!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes) {
                Close();
            }
        }
    }
}