using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class AdmCuartoArbitro : IAdm{
        List<CuartoArbitro> listaCuartoArbitro = new List<CuartoArbitro>();
        CuartoArbitro cuartoArbitro = null;
        ValidacionGUI v = new ValidacionGUI();
        Datos datos = new Datos();

        private static AdmCuartoArbitro admCA = null;

        public List<CuartoArbitro> ListaCuartoArbitro { get => listaCuartoArbitro; set => listaCuartoArbitro = value; }

        private AdmCuartoArbitro () {
            listaCuartoArbitro = new List<CuartoArbitro>();
        }

        public static AdmCuartoArbitro getAdmCA () {
            if (admCA == null)
                admCA = new AdmCuartoArbitro();
            return admCA;
        }

        //Agregar
        public int guardar (TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC,
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC) {
            string cedula = txtcedulaJC.Text,
                nombre = txtnombreJC.Text,
                apellidos = txtapellidoJC.Text,
                domicilio = txtdomicilioJC.Text,
                email = txtemailJC.Text,
                telefono = txttelefonoJC.Text;
            int id = 0;

            cuartoArbitro = new CuartoArbitro(0, cedula, nombre, apellidos, domicilio, email, telefono);

            if (cuartoArbitro != null) {
                listaCuartoArbitro.Add(cuartoArbitro);
                id = GuardarJuezCentralBD(cuartoArbitro); //Guardar BD
            }
            return id;
        }

        private int GuardarJuezCentralBD (CuartoArbitro cuartoArbitro) {
            int id = 0;

            id = datos.InsertarCuartoArbitro(cuartoArbitro);
            if (id == 0) {
                MessageBox.Show("No se ha podido comunicar con la BD");
            }
            return id;
        }
    }
}
