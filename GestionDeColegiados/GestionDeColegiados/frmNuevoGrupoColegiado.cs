using Control;
using Control.AdmColegiados;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmNuevoGrupoColegiado : Form
    {
        ValidacionGUI validacionGUI = new ValidacionGUI();
        Contexto contexto = null;
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmNuevoGrupoColegiado()
        {
            InitializeComponent();
        }

        private void validarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void validarLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            if (vacio != true)
            {
                camposJuezCentral(false);
                camposAsistente1(true);
            }
            else
            {
                camposIncompletos();
            }
        }

        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            if (vacio != true)
            {
                camposAsistente1(false);
                camposAsistente2(true);
            }
            else
            {
                camposIncompletos();
            }
        }

        private void btnsiguiente3_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            if (vacio != true)
            {
                camposAsistente2(false);
                camposCuartoArbitro(true);
            }
            else
            {
                camposIncompletos();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            if (vacio != true)
            {
                registrarColegiado();
                limpiarCamposJuezCentral();
                limpiarCamposAsistente1();
                limpiarCamposAsistente2();
                limpiarCamposArbitroCentral();
            }
            else
            {
                camposIncompletos();
            }
        }

        private void camposIncompletos()
        {
            MessageBox.Show("Hay ciertos campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registrarColegiado()
        {
            int idJuezCentral = obtenerIdJuezCentral(),
                idAsistente1 = obtenerIdAsistente1(),
                idAsistente2 = obtenerIdAsistente2(),
                idCuartoArbitro = obtenerIdCuartoArbitro();
            bool vacio = validacionGUI.validarnum(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            if (vacio != true)
            {
                admColegiado.Guardar(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            }
            else
            {
                MessageBox.Show("No se pudo agregar colegiados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int obtenerIdJuezCentral()
        {
            int id = 0;
            contexto = new Contexto(AdmJuezCentral.getAdmJ());
            id = contexto.obtenerDatos(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            return id;
        }
        private int obtenerIdAsistente1()
        {
            int id = 0;
            contexto = new Contexto(AdmAsistente1.getAdmA1());
            id = contexto.obtenerDatos(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            return id;
        }
        private int obtenerIdAsistente2()
        {
            int id = 0;
            contexto = new Contexto(AdmAsistente2.getAdmA2());
            id = contexto.obtenerDatos(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            return id;
        }
        private int obtenerIdCuartoArbitro()
        {
            int id = 0;
            contexto = new Contexto(AdmCuartoArbitro.getAdmCA());
            id = contexto.obtenerDatos(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            return id;
        }
        private void camposJuezCentral(bool valor)
        {
            labJuezCentral.Visible = valor;
            txtcedulaJC.Visible = valor;
            txtnombreJC.Visible = valor;
            txtapellidoJC.Visible = valor;
            txtdomicilioJC.Visible = valor;
            txtemailJC.Visible = valor;
            txttelefonoJC.Visible = valor;
            btnsiguiente1.Visible = valor;
        }
        private void camposAsistente1(bool valor)
        {
            labAsist1.Visible = valor;
            txtcedulaAs1.Visible = valor;
            txtnombreAs1.Visible = valor;
            txtapellidoAs1.Visible = valor;
            txtdomicilioAs1.Visible = valor;
            txtemailAs1.Visible = valor;
            txttelefonoAs1.Visible = valor;
            btnsiguiente2.Visible = valor;
        }
        private void camposAsistente2(bool valor)
        {
            labAsist2.Visible = valor;
            txtcedulaAs2.Visible = valor;
            txtnombreAs2.Visible = valor;
            txtapellidoAs2.Visible = valor;
            txtdomicilioAs2.Visible = valor;
            txtemailAs2.Visible = valor;
            txttelefonoAs2.Visible = valor;
            btnsiguiente3.Visible = valor;
        }
        private void camposCuartoArbitro(bool valor)
        {
            labCuartoArb.Visible = valor;
            txtcedulaCA.Visible = valor;
            txtnombreCA.Visible = valor;
            txtapellidoCA.Visible = valor;
            txtdomicilioCA.Visible = valor;
            txtemailCA.Visible = valor;
            txttelefonoCA.Visible = valor;
            btnRegistrar.Visible = valor;
        }
        private void limpiarCamposJuezCentral()
        {
            txtcedulaJC.Text = "";
            txtnombreJC.Text = "";
            txtapellidoJC.Text = "";
            txtdomicilioJC.Text = "";
            txtemailJC.Text = "";
            txttelefonoJC.Text = "";
        }
        private void limpiarCamposAsistente1()
        {
            txtcedulaAs1.Text = "";
            txtnombreAs1.Text = "";
            txtapellidoAs1.Text = "";
            txtdomicilioAs1.Text = "";
            txtemailAs1.Text = "";
            txttelefonoAs1.Text = "";
        }
        private void limpiarCamposAsistente2()
        {
            txtcedulaAs2.Text = "";
            txtnombreAs2.Text = "";
            txtapellidoAs2.Text = "";
            txtdomicilioAs2.Text = "";
            txtemailAs2.Text = "";
            txttelefonoAs2.Text = "";
        }
        private void limpiarCamposArbitroCentral()
        {
            txtcedulaCA.Text = "";
            txtnombreCA.Text = "";
            txtapellidoCA.Text = "";
            txtdomicilioCA.Text = "";
            txtemailCA.Text = "";
            txttelefonoCA.Text = "";
        }
    }
}