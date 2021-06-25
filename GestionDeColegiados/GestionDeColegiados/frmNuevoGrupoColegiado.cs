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
        int idJuezCentral = 0, idAsistente1 = 0, idAsistente2 = 0, idCuartoArbitro = 0;

        public frmNuevoGrupoColegiado(){
            InitializeComponent();
        }

        private void btnsiguiente1_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            if (vacio != true) {
                idJuezCentral = admJuezCentral.Guardar(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            } else {
                camposIncompletos();
            }
        }

        private void btnsiguiente2_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios2(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1, cmbbandaAs1);
            if (vacio != true) {
                idAsistente1 = admAsistente1.Guardar(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1, cmbbandaAs1);
            } else {
                camposIncompletos();
            }
        }

        private void btnsiguiente3_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios2(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2, cmbbandaAs2);
            if (vacio != true) {
                idAsistente2 = admAsistente2.Guardar(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2, cmbbandaAs2);
            } else {
                camposIncompletos();
            }
        }

        private void btnsiguiente4_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarVacios(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            if (vacio != true) {
                idCuartoArbitro = admCuartoArbitro.Guardar(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            } else {
                camposIncompletos();
            }
        }

        public void camposIncompletos () {
            MessageBox.Show("Hay ciertos campos vacios");
        }

        private void btnRegistrar_Click (object sender, EventArgs e) {
            bool vacio = validacionGUI.validarnum(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            if(vacio != true) {
                admColegiado.Guardar(idJuezCentral,idAsistente1,idAsistente2,idCuartoArbitro);
            } else {
                MessageBox.Show("No se pudo agregar colegiados");
            }
        }
    }
}
