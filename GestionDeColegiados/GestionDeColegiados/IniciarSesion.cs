using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Control;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionDeColegiados
{
    public partial class btnIniciarSesion : Form
    {
        //dlly variables necesarios para poder mover de lugar la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*variables necesarias para gestionar efectos visuales cuando el mouse se posiciona
            dentro de un controlador previamente determinado
        */
        private Color colorDefaultClose;
        private Color colorDefaultMin;

        string usuario;
        string password;


        public btnIniciarSesion()
        {
            InitializeComponent();

        }

        

        // metodo necesario para gestionar el movimiento de la ventana
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Eventos que generan un efecto visual en cuanto el mouse pasa por dicho controlador
        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            colorDefaultClose = pbCerrar.BackColor;
            pbCerrar.BackColor= Color.FromArgb(202, 49, 32);
        }
        protected void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.BackColor = colorDefaultClose;
        }

        protected void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            colorDefaultMin= pbMinimizar.BackColor;
            pbMinimizar.BackColor= Color.FromArgb(52, 58, 64);
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = colorDefaultMin;
        }

        //Evento que abre el formulario luego de un inicio de sesión exitoso
        private void button1_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            password = txtPassword.Text;

            validarCamposVaciosLogin();

            GestionLogin gestionLogin = new GestionLogin();


            if (string.IsNullOrEmpty(usuario) || (string.IsNullOrEmpty(password)))
            {
                validarCamposVaciosLogin();
            }
            else
            {
                //metodo que envia el usuario y contraseña ingrsado para validar si los datos fueron ingresados correctamente
                string respuesta= "";
                try
                {
                    gestionLogin.controlLogin(usuario, password);
                    this.Hide();
                    MenuPrincipal pantallaPrincipal = new MenuPrincipal();
                    pantallaPrincipal.Show();
                }
                catch(usuarioNoRegistradoException ex)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }            
        }

        //metodo que valida si existen campos vacios en la GUI
        private void validarCamposVaciosLogin()
        {
            usuario = txtUsuario.Text;
            password = txtPassword.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un usuario");
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(txtPassword, "Debe ingresar una contraseña");
            }
        }
    }
}