using Data;
using Model.Colegiados;
using System;
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

        //Guardar datos en la BD
        private int GuardarJuezCentralBD(JuezCentral juezCentral)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarJuezCentral(juezCentral);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return id;
        }

        //Método obtenerDatos de la interface IAdm
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaJuezCentral = datos.consultarJuezCentral(id);
            foreach (JuezCentral datosJC in listaJuezCentral) {
                dgvListarColegiados.Rows.Add("Juez Central", datosJC.Cedula, datosJC.Nombre, 
                    datosJC.Apellidos, datosJC.Domicilio, datosJC.Email, datosJC.Telefono);
            }
        }

        //Método recogerDatosEditar de la interface IAdm
        JuezCentral JC;
        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            foreach (JuezCentral juezCentral in listaJuezCentral) {
                if (juezCentral.Cedula == filaSeleccionada.Cells[1].Value.ToString() &&
                    juezCentral.Nombre == filaSeleccionada.Cells[2].Value.ToString() &&
                    juezCentral.Apellidos == filaSeleccionada.Cells[3].Value.ToString() &&
                    juezCentral.Domicilio == filaSeleccionada.Cells[4].Value.ToString() &&
                    juezCentral.Email == filaSeleccionada.Cells[5].Value.ToString() &&
                    juezCentral.Telefono == filaSeleccionada.Cells[6].Value.ToString()) {
                    JC = juezCentral;
                }
            }
        }

        //Método llenarDatosFormEditar de la interface IAdm
        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, 
            TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            try {
                txtCedula.Text = JC.Cedula.ToString();
                txtNombre.Text = JC.Nombre.ToString();
                txtApellido.Text = JC.Apellidos.ToString();
                txtDomicilio.Text = JC.Domicilio.ToString();
                txtEmail.Text = JC.Email.ToString();
                txtTelefono.Text = JC.Telefono.ToString();
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        //Método editarArbitro de la interface IAdm
        public void editarArbitro (int idArbitro, string cedula, string nombre, string apellido,
            string domicilio, string email, string telefono) {
            juezCentral = new JuezCentral();
            juezCentral.IdArbitro = idArbitro;
            juezCentral.Cedula = cedula;
            juezCentral.Nombre = nombre;
            juezCentral.Apellidos = apellido;
            juezCentral.Domicilio = domicilio;
            juezCentral.Email = email;
            juezCentral.Telefono = telefono;

            if (juezCentral != null) {
                EditarJuezCentralBD(juezCentral);  //BD
            }
        }

        //Modificar datos en la BD
        private void EditarJuezCentralBD (JuezCentral juezCentral) {
            string mensaje = "";
            try {
                datos.EditarJuezCentralBD(juezCentral);
                MessageBox.Show("Sus datos fueron actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}