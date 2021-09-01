using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class CambiarPass : Form
    {
        private int idUser;
        private GestionLogin gestionLogin = new GestionLogin();
        public CambiarPass(int idUsuraio)
        {
            idUser = idUsuraio;
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string newPass = txtPass.Text.Trim();
            bool cambiar=gestionLogin.CambiarPass(newPass, this.idUser);
            if (cambiar)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
