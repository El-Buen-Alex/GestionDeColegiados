using Data;
using Model.Colegiados;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmCuartoArbitro : IAdm
    {
        List<CuartoArbitro> listaCuartoArbitro = new List<CuartoArbitro>();
        CuartoArbitro cuartoArbitro = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmCuartoArbitro admCA = null;

        public List<CuartoArbitro> ListaCuartoArbitro { get => listaCuartoArbitro; set => listaCuartoArbitro = value; }

        //Paso para el uso de Singleton
        //Creando atributo privado y estático de la misma clase
        private AdmCuartoArbitro ()
        {
            listaCuartoArbitro = new List<CuartoArbitro>();
        }

        public static AdmCuartoArbitro getAdmCA()
        {
            if (admCA == null)
                admCA = new AdmCuartoArbitro();
            return admCA;
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

            cuartoArbitro = new CuartoArbitro(0, cedula, nombre, apellidos, domicilio, email, telefono);

            if (cuartoArbitro != null)
            {
                listaCuartoArbitro.Add(cuartoArbitro);    //Añadir a la lista
                id = GuardarJuezCentralBD(cuartoArbitro); //Guardar BD
            }
            return id;
        }

        //Guardar datos a la BD
        private int GuardarJuezCentralBD(CuartoArbitro cuartoArbitro)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarCuartoArbitro(cuartoArbitro);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
            }
            if (mensaje != "") {
                MessageBox.Show(mensaje);
            }
            return id;
        }

        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaCuartoArbitro = datos.consultarCuartoArbitro(id);
            foreach (CuartoArbitro datosCA in listaCuartoArbitro) {
                dgvListarColegiados.Rows.Add("Cuarto Arbitro", datosCA.Cedula, datosCA.Nombre, datosCA.Apellidos, datosCA.Domicilio, datosCA.Email, datosCA.Telefono);
            }
        }
    }
}
