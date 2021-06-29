using Control;
using Control.AdmColegiados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeColegiados { 
    public partial class frmNuevoGrupoColegiado : Form {
        ValidacionGUI validacionGUI = new ValidacionGUI();
        AdmJuezCentral admJuezCentral = AdmJuezCentral.getAdmJ();
        AdmAsistente1 admAsistente1 = AdmAsistente1.getAdmA1();
        AdmAsistente2 admAsistente2 = AdmAsistente2.getAdmA2();
        AdmCuartoArbitro admCuartoArbitro = AdmCuartoArbitro.getAdmCA();
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmNuevoGrupoColegiado(){
            InitializeComponent();
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

        private void btnsiguiente1_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            if (vacio != true) {
                ocultarCamposJuezCentral();
            } else {
                camposIncompletos();
            }
        }

        private void btnsiguiente2_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            if (vacio != true) {
                ocultarCamposAsistente1();
            } else {
                camposIncompletos();
            }
        }

        private void btnsiguiente3_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            if (vacio != true) {
                ocultarCamposAsistente2();
            } else {
                camposIncompletos();
            }
        }

        private void btnRegistrar_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            if (vacio != true) {
                registrarColegiado();
            } else {
                camposIncompletos();
            }
        }

        private void camposIncompletos () {
            MessageBox.Show("Hay ciertos campos vacios");
        }

        private void registrarColegiado () {
            int idJuezCentral = obtenerIdJuezCentral(),
                idAsistente1 = obtenerIdAsistente1(),
                idAsistente2 = obtenerIdAsistente2(),
                idCuartoArbitro = obtenerIdCuartoArbitro();
            bool vacio = validacionGUI.validarnum(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            if(vacio != true) {
                admColegiado.Guardar(idJuezCentral,idAsistente1,idAsistente2,idCuartoArbitro);
            } else {
                MessageBox.Show("No se pudo agregar colegiados");
            }
        }

        private int obtenerIdJuezCentral () {
            int id = 0;
            id = admJuezCentral.Guardar(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            return id;
        }
        private int obtenerIdAsistente1 () {
            int id = 0;
            id = admAsistente1.Guardar(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            return id;
        }
        private int obtenerIdAsistente2 () {
            int id = 0;
            id = admAsistente2.Guardar(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            return id;
        }
        private int obtenerIdCuartoArbitro () {
            int id = 0;
            id = admCuartoArbitro.Guardar(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            return id;
        }
        private void ocultarCamposJuezCentral () {
            labJuezCentral.Visible = false;
            txtcedulaJC.Visible = false;
            txtnombreJC.Visible = false;
            txtapellidoJC.Visible = false;
            txtdomicilioJC.Visible = false;
            txtemailJC.Visible = false;
            txttelefonoJC.Visible = false;
            btnsiguiente1.Visible = false;

            labAsist1.Visible = true;
            txtcedulaAs1.Visible = true;
            txtnombreAs1.Visible = true;
            txtapellidoAs1.Visible = true;
            txtdomicilioAs1.Visible = true;
            txtemailAs1.Visible = true;
            txttelefonoAs1.Visible = true;
            btnsiguiente2.Visible = true;
        }
        private void ocultarCamposAsistente1 () {
            labAsist1.Visible = false;
            txtcedulaAs1.Visible = false;
            txtnombreAs1.Visible = false;
            txtapellidoAs1.Visible = false;
            txtdomicilioAs1.Visible = false;
            txtemailAs1.Visible = false;
            txttelefonoAs1.Visible = false;
            btnsiguiente2.Visible = false;

            labAsist2.Visible = true;
            txtcedulaAs2.Visible = true;
            txtnombreAs2.Visible = true;
            txtapellidoAs2.Visible = true;
            txtdomicilioAs2.Visible = true;
            txtemailAs2.Visible = true;
            txttelefonoAs2.Visible = true;
            btnsiguiente3.Visible = true;
        }
        private void ocultarCamposAsistente2 () {
            labAsist2.Visible = false;
            txtcedulaAs2.Visible = false;
            txtnombreAs2.Visible = false;
            txtapellidoAs2.Visible = false;
            txtdomicilioAs2.Visible = false;
            txtemailAs2.Visible = false;
            txttelefonoAs2.Visible = false;
            btnsiguiente3.Visible = false;

            labCuartoArb.Visible = true;
            txtcedulaCA.Visible = true;
            txtnombreCA.Visible = true;
            txtapellidoCA.Visible = true;
            txtdomicilioCA.Visible = true;
            txtemailCA.Visible = true;
            txttelefonoCA.Visible = true;
            btnRegistrar.Visible = true;
        }
    }
}