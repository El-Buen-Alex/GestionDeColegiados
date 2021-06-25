using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class AdmJuezCentral {
        List<JuezCentral> listaJuezCentral = new List<JuezCentral>();
        JuezCentral juezCentral = null;
        ValidacionGUI v = new ValidacionGUI();
        Datos datos = new Datos();

        private static AdmJuezCentral admJ = null;

        public List<JuezCentral> ListaJuezCentral { get => listaJuezCentral; set => listaJuezCentral = value; }

        private AdmJuezCentral () {
            listaJuezCentral = new List<JuezCentral>();
        }

        public static AdmJuezCentral getAdmJ () {
            if (admJ == null)
                admJ = new AdmJuezCentral();
            return admJ;
        }

        //Agregar
        public int Guardar (TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC,
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC) {
            string cedula = txtcedulaJC.Text,
                nombre = txtnombreJC.Text,
                apellidos = txtapellidoJC.Text,
                domicilio = txtdomicilioJC.Text,
                email = txtemailJC.Text,
                telefono = txttelefonoJC.Text;
            int id = 0;

            juezCentral = new JuezCentral(0,cedula,nombre,apellidos,domicilio,email,telefono);

            if (juezCentral != null) {
                listaJuezCentral.Add(juezCentral);
                id = GuardarJuezCentral(juezCentral); //Guardar BD
            }
            return id;
        }

        private int GuardarJuezCentral (JuezCentral juezCentral) {
            int id = 0;
            
            id = datos.InsertarJuezCentral(juezCentral);
            if (id >= 1) {
                MessageBox.Show("Se ha guardado correctamente");
            } else {
                MessageBox.Show("No se ha podido comunicar con la BD");
            }
            return id;
        }
    }
}
