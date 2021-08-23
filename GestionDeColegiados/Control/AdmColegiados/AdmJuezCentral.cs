using Data;
using Model.Colegiados;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmJuezCentral : IAdm
    {
        List<JuezCentral> listaJuezCentral = new List<JuezCentral>();
        JuezCentral juezCentral = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmJuezCentral admJ = null;

        public List<JuezCentral> ListaJuezCentral { get => listaJuezCentral; set => listaJuezCentral = value; }

        //Paso para el uso de Singleton
        //Creando atributo privado y estático de la misma clase
        private AdmJuezCentral ()
        {
            listaJuezCentral = new List<JuezCentral>();
        }

        public static AdmJuezCentral getAdmJ()
        {
            if (admJ == null)
                admJ = new AdmJuezCentral();
            return admJ;
        }

        //Método guardar de la interface IAdm
        public int guardar(TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC,
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC)
        {
            string cedula = txtcedulaJC.Text,
                nombre = txtnombreJC.Text,
                apellidos = txtapellidoJC.Text,
                domicilio = txtdomicilioJC.Text,
                email = txtemailJC.Text,
                telefono = txttelefonoJC.Text;
            int id = 0;

            juezCentral = new JuezCentral(0, cedula, nombre, apellidos, domicilio, email, telefono);

            if (juezCentral != null)
            {
                listaJuezCentral.Add(juezCentral);      //Añadir a la lista
                id = GuardarJuezCentralBD(juezCentral); //Guardar BD
            }
            return id;
        }

        //Guardar datos a la BD
        private int GuardarJuezCentralBD(JuezCentral juezCentral)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarJuezCentral(juezCentral);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
            }
            if (mensaje != "") {
                MessageBox.Show(mensaje);
            }
            return id;
        }

        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaJuezCentral = datos.consultarJuezCentral(id);
            foreach (JuezCentral datosJC in listaJuezCentral) {
                dgvListarColegiados.Rows.Add("Juez Central", datosJC.Cedula, datosJC.Nombre, datosJC.Apellidos, datosJC.Domicilio, datosJC.Email, datosJC.Telefono);
            }
        }
    }
}
