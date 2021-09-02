using Data;
using Model.Colegiados;
using System;
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
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return id;
        }

        //Método obtenerDatos de la interface IAdm
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaCuartoArbitro = datos.consultarCuartoArbitro(id);
            foreach (CuartoArbitro datosCA in listaCuartoArbitro) {
                dgvListarColegiados.Rows.Add("Cuarto Árbitro", datosCA.Cedula, datosCA.Nombre, datosCA.Apellidos, datosCA.Domicilio, datosCA.Email, datosCA.Telefono);
            }
        }

        //Editar
        //Método recogerDatosEditar de la interface IAdm
        CuartoArbitro CA;
        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            foreach (CuartoArbitro cuartoArb in listaCuartoArbitro) {
                if (cuartoArb.Cedula == filaSeleccionada.Cells[1].Value.ToString() &&
                    cuartoArb.Nombre == filaSeleccionada.Cells[2].Value.ToString() &&
                    cuartoArb.Apellidos == filaSeleccionada.Cells[3].Value.ToString() &&
                    cuartoArb.Domicilio == filaSeleccionada.Cells[4].Value.ToString() &&
                    cuartoArb.Email == filaSeleccionada.Cells[5].Value.ToString() &&
                    cuartoArb.Telefono == filaSeleccionada.Cells[6].Value.ToString()) {
                    CA = cuartoArb;
                }
            }
        }

        //Método llenarDatosFormEditar de la interface IAdm
        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            try {
                txtCedula.Text = CA.Cedula.ToString();
                txtNombre.Text = CA.Nombre.ToString();
                txtApellido.Text = CA.Apellidos.ToString();
                txtDomicilio.Text = CA.Domicilio.ToString();
                txtEmail.Text = CA.Email.ToString();
                txtTelefono.Text = CA.Telefono.ToString();
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        //Método editarArbitro de la interface IAdm
        public void editarArbitro (int idArbitro, string cedula, string nombre, string apellido,
            string domicilio, string email, string telefono) {
            cuartoArbitro = new CuartoArbitro();
            cuartoArbitro.IdArbitro = idArbitro;
            cuartoArbitro.Cedula = cedula;
            cuartoArbitro.Nombre = nombre;
            cuartoArbitro.Apellidos = apellido;
            cuartoArbitro.Domicilio = domicilio;
            cuartoArbitro.Email = email;
            cuartoArbitro.Telefono = telefono;

            if (cuartoArbitro != null) {
                editarCuartoArbitroBD(cuartoArbitro);
            }
        }

        //Modificar datos en la BD
        private void editarCuartoArbitroBD (CuartoArbitro cuartoArbitro) {
            string mensaje = "";
            try {
                datos.editarCuartoArbitro(cuartoArbitro);
                MessageBox.Show("Sus datos fueron actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
