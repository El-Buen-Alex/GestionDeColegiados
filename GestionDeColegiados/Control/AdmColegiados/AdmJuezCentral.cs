using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase para la gestión de Juez Central.
    /// </summary>
    /// <remarks>
    /// Crea las listas, instancias y validaciones para obtener los datos de Juez Central.
    /// </remarks>
    public class AdmJuezCentral : IAdm
    {
        List<JuezCentral> listaJuezCentral = new List<JuezCentral>();
        JuezCentral juezCentral = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmJuezCentral admJ = null;

        public List<JuezCentral> ListaJuezCentral { get => listaJuezCentral; set => listaJuezCentral = value; }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo privado de la clase AdmJuezCentral.
        /// </remarks>
        private AdmJuezCentral ()
        {
            listaJuezCentral = new List<JuezCentral>();
        }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo estático de la clase Juez Central.
        /// </remarks>
        /// <returns>Devuelve una instancia de AdmJuezCentral.</returns>
        public static AdmJuezCentral getAdmJ()
        {
            if (admJ == null)
                admJ = new AdmJuezCentral();
            return admJ;
        }

        /// <summary>
        /// Método guardar de la interface IAdm.
        /// </summary>
        /// <param name="txtcedulaJC">Cedula recogida.</param>
        /// <param name="txtnombreJC">Nombre recogido.</param>
        /// <param name="txtapellidoJC">Apellido recogido.</param>
        /// <param name="txtdomicilioJC">Domicilio recogido.</param>
        /// <param name="txtemailJC">Email recogido.</param>
        /// <param name="txttelefonoJC">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
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

        /// <summary>
        /// Guardar datos de Juez Central en la BD.
        /// </summary>
        /// <param name="juezCentral">Objeto Juez Central.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
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

        /// <summary>
        /// Método obtenerDatos de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena <paramref name="dgvListarColegiados"/> con los datos del <paramref name="id"/> buscado.
        /// </remarks>
        /// <param name="id">ID de un Juez Central.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaJuezCentral = datos.consultarJuezCentral(id);
            foreach (JuezCentral datosJC in listaJuezCentral) {
                dgvListarColegiados.Rows.Add("Juez Central", datosJC.Cedula, datosJC.Nombre, 
                    datosJC.Apellidos, datosJC.Domicilio, datosJC.Email, datosJC.Telefono);
            }
        }

        /// <summary>
        /// Instancia de la clase Asistente.
        /// </summary>
        JuezCentral JC;

        /// <summary>
        /// Método recogerDatosEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
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

        /// <summary>
        /// Método llenarDatosFormEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena los TexBox de Editar con los datos del Juez Central seleccionado.
        /// </remarks>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
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

        /// <summary>
        /// Método editarArbitro de la interface IAdm.
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        /// <param name="cedula">Cedula recogida.</param>
        /// <param name="nombre">Nombre recogido.</param>
        /// <param name="apellido">Apellido recogido.</param>
        /// <param name="domicilio">Domicilio recogido.</param>
        /// <param name="email">Email recogido.</param>
        /// <param name="telefono">Telefono recogido.</param>
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

        /// <summary>
        /// Modificar datos de Asistente1 en la BD.
        /// </summary>
        /// <param name="juezCentral">Objeto Juez Central.</param>
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

        /// <summary>
        /// Método eliminarArbitro de la interface IAdm.
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        /// <param name="cedula">Cedula recogida.</param>
        /// <param name="nombre">Nombre recogido.</param>
        /// <param name="apellido">Apellido recogido.</param>
        /// <param name="domicilio">Domicilio recogido.</param>
        /// <param name="email">Email recogido.</param>
        /// <param name="telefono">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        public int eliminarArbitro (int idArbitro, string cedula, string nombre, string apellido,
            string domicilio, string email, string telefono) {
            juezCentral = new JuezCentral();
            juezCentral.IdArbitro = idArbitro;
            juezCentral.Cedula = cedula;
            juezCentral.Nombre = nombre;
            juezCentral.Apellidos = apellido;
            juezCentral.Domicilio = domicilio;
            juezCentral.Email = email;
            juezCentral.Telefono = telefono;
            int idNuevo = 0;

            if (juezCentral != null) {
                eliminarJuezCentralBD(idArbitro);
                idNuevo = GuardarJuezCentralBD(juezCentral);
            }
            return idNuevo;
        }

        /// <summary>
        /// Eliminar "lógico" en la BD.
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        private void eliminarJuezCentralBD (int idArbitro) {
            string mensaje = "";
            try {
                datos.eliminarJuezCentralBD(idArbitro);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}