using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control {
    public class ValidacionGUI {

        public int EsInt (string valor) {
            int x = 0;
            try {
                x = int.Parse(valor);
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public double EsDouble (string valor) {
            double x = 0.0;
            try {
                x = double.Parse(valor);
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public float EsFloat (string valor) {
            float x = 0;
            try {
                x = float.Parse(valor);
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public bool validarVacios (TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC, 
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC) {
            bool vacio = true;
            if (txtcedulaJC.Text!="" && txtnombreJC.Text != "" && txtapellidoJC.Text != "" && 
                txtdomicilioJC.Text != "" && txtemailJC.Text != "" && txttelefonoJC.Text != "") {
                return vacio = false;
            }
            return vacio;
        }

        public bool validarVacios2 (TextBox txtcedulaAs, TextBox txtnombreAs, TextBox txtapellidoAs, 
            TextBox txtdomicilioAs, TextBox txtemailAs, TextBox txttelefonoAs, ComboBox cmbbandaAs) {
            bool vacio = true;
            if (txtcedulaAs.Text != "" && txtnombreAs.Text != "" && txtapellidoAs.Text != "" &&
                txtdomicilioAs.Text != "" && txtemailAs.Text != "" && txttelefonoAs.Text != "" && cmbbandaAs.Text != "") {
                return vacio = false;
            }
            return vacio;
        }

        public bool validarnum (int idJuezCentral, int idAsistente1, int idAsistente2, int idCuartoArbitro) {
            bool vacio = true;
            if (idJuezCentral != 0 && idAsistente1 != 0 && idAsistente2 != 0 && idCuartoArbitro != 0) {
                vacio = false;
            }
            return vacio;
        }
    }
}
