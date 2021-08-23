using Data;
using Model.Colegiados;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmAsistente2 : IAdm
    {
        List<Asistente> listaAsistente2 = new List<Asistente>();
        Asistente asistente2 = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmAsistente2 admA2 = null;

        public List<Asistente> ListaAsistente2 { get => listaAsistente2; set => listaAsistente2 = value; }
        
        //Paso para el uso de Singleton
        //Creando atributo privado y estático de la misma clase
        private AdmAsistente2 ()
        {
            listaAsistente2 = new List<Asistente>();
        }

        public static AdmAsistente2 getAdmA2()
        {
            if (admA2 == null)
                admA2 = new AdmAsistente2();
            return admA2;
        }

        //Método guardar de la interface IAdm
        public int guardar(TextBox txtcedulaAs2, TextBox txtnombreAs2, TextBox txtapellidoAs2,
            TextBox txtdomicilioAs2, TextBox txtemailAs2, TextBox txttelefonoAs2)
        {
            string cedula = txtcedulaAs2.Text,
                nombre = txtnombreAs2.Text,
                apellidos = txtapellidoAs2.Text,
                domicilio = txtdomicilioAs2.Text,
                email = txtemailAs2.Text,
                telefono = txttelefonoAs2.Text;
            int id = 0;

            asistente2 = new Asistente(0, cedula, nombre, apellidos, domicilio, email, telefono, "Izquierda");

            if (asistente2 != null)
            {
                listaAsistente2.Add(asistente2);      //Añadir a la lista
                id = GuardarAsistente2BD(asistente2); //Guardar BD
            }
            return id;
        }

        //Guardar datos a la BD
        private int GuardarAsistente2BD(Asistente asistente2)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarAsistente2(asistente2);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
            }
            if (mensaje != "") {
                MessageBox.Show(mensaje);
            }
            return id;
        }

        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaAsistente2 = datos.consultarAsistente2(id);
            foreach (Asistente datosAs2 in listaAsistente2) {
                dgvListarColegiados.Rows.Add("Asistente 2", datosAs2.Cedula, datosAs2.Nombre, datosAs2.Apellidos, datosAs2.Domicilio, datosAs2.Email, datosAs2.Telefono);
            }
        }
    }
}
