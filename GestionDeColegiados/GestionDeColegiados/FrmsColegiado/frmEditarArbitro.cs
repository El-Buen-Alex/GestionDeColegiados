using Control;
using Control.AdmColegiados;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestionDeColegiados.FrmsColegiado 
{
    /// <summary>
    /// Formulario para editar Áribtros.
    /// </summary>
    public partial class frmEditarArbitro : Form 
    {
        /// <summary>
        /// DLL y variables necesarias para poder mover el formulario.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color colorDefaultClose;
        ValidacionGUI validacionGUI = new ValidacionGUI();
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        /// <param name="arbitro">Tipo de árbitro.</param>
        /// <param name="idColegiado">ID del colegiado.</param>
        public frmEditarArbitro (string arbitro, string idColegiado) {
            InitializeComponent();
            lblEditar.Text += arbitro;
            lblID.Text = idColegiado;
        }

        /// <summary>
        /// Evento Load del formulario.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void frmEditarArbitro_Load (object sender, EventArgs e) {
            admColegiado.LlenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
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
        private void pbCerrar_Click (object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void pbCerrar_MouseEnter (object sender, EventArgs e) {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor = Color.FromArgb(202, 49, 32);
        }

        /// <summary>
        /// Eventos que generan un efecto visual en cuanto el mouse sale por dicho controlador.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void pbCerrar_MouseLeave (object sender, EventArgs e) {
            pbCerrar.BackColor = colorDefaultClose;
        }

        /// <summary>
        /// Evento para validar que solo ingrese números.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void validarNumeros_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento para validar que solo ingrese letras.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void validarLetras_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                (e.KeyChar != Convert.ToChar(Keys.Space))) {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento para cambiar el estado del CheckBox
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void chbxHabilitar_CheckedChanged (object sender, EventArgs e) {
            if (chbxHabilitar.Checked == true) {
                txtCedula.Enabled = true;
            } else {
                txtCedula.Enabled = false;
            }
        }

        /// <summary>
        /// Evento click para el botón actualizar.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnActualizar_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
            bool cedulaRepetida = admColegiado.validarCedula(txtCedula);
            if (vacio == true) {
                MessageBox.Show("Hay ciertos campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtCedula.Enabled == false) {
                actualiza();
            } else {
                if (cedulaRepetida == true) {
                    MessageBox.Show("El árbitro que ingresó ya se encuentra registrado!!\nIngrese uno nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (vacio != true && cedulaRepetida != true) {
                    actualiza();
                }
            }
        }

        /// <summary>
        /// Evento click para el botón Cancelar.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnCancelar_Click (object sender, EventArgs e) {
            DialogResult resultado;
            resultado = MessageBox.Show("¡Está seguro de cancelar!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes) {
                Close();
            }
        }

        /// <summary>
        /// Método para actualizar y enviar los datos ingresados del formulario.
        /// </summary>
        private void actualiza () {
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
                Close();
            }
        }
    }
}