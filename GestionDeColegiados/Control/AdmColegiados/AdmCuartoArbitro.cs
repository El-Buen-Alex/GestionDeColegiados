using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase para la gestión de Cuarto Árbitro.
    /// </summary>
    /// <remarks>
    /// Crea las listas, instancias y validaciones para obtener los datos de Cuarto Árbitro.
    /// </remarks>
    public class AdmCuartoArbitro : IAdm
    {
        List<CuartoArbitro> listaCuartoArbitro = new List<CuartoArbitro>();
        CuartoArbitro cuartoArbitro = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmCuartoArbitro admCA = null;

        public List<CuartoArbitro> ListaCuartoArbitro { get => listaCuartoArbitro; set => listaCuartoArbitro = value; }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo privado de la clase AdmCuartoArbitro.
        /// </remarks>
        private AdmCuartoArbitro ()
        {
            listaCuartoArbitro = new List<CuartoArbitro>();
        }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo estático de la clase Cuarto Árbitro.
        /// </remarks>
        /// <returns>Devuelve una instancia de AdmCuartoArbitro.</returns>
        public static AdmCuartoArbitro getAdmCA()
        {
            if (admCA == null)
                admCA = new AdmCuartoArbitro();
            return admCA;
        }

        /// <summary>
        /// Método guardar de la interface IAdm.
        /// </summary>
        /// <param name="txtcedula">Cedula recogida.</param>
        /// <param name="txtnombre">Nombre recogido.</param>
        /// <param name="txtapellido">Apellido recogido.</param>
        /// <param name="txtdomicilio">Domicilio recogido.</param>
        /// <param name="txtemail">Email recogido.</param>
        /// <param name="txttelefono">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        public int guardar(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono)
        {
            string cedula = txtcedula.Text,
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                domicilio = txtdomicilio.Text,
                email = txtemail.Text,
                telefono = txttelefono.Text;
            int id = 0;

            cuartoArbitro = new CuartoArbitro(0, cedula, nombre, apellidos, domicilio, email, telefono);

            if (cuartoArbitro != null)
            {
                listaCuartoArbitro.Add(cuartoArbitro);    //Añadir a la lista
                id = GuardarCuartoArbitroBD(cuartoArbitro); //Guardar BD
            }
            return id;
        }

        /// <summary>
        /// Guardar datos de Cuarto Árbitro en la BD.
        /// </summary>
        /// <param name="cuartoArbitro">Objeto Cuarto Árbitro.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        private int GuardarCuartoArbitroBD(CuartoArbitro cuartoArbitro)
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

        /// <summary>
        /// Método obtenerDatos de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena <paramref name="dgvListarColegiados"/> con los datos del <paramref name="id"/> buscado.
        /// </remarks>
        /// <param name="id">ID de un Cuarto Árbitro.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaCuartoArbitro = datos.consultarCuartoArbitro(id);
            foreach (CuartoArbitro datosCA in listaCuartoArbitro) {
                dgvListarColegiados.Rows.Add("Cuarto Árbitro", datosCA.Cedula, datosCA.Nombre, datosCA.Apellidos, datosCA.Domicilio, datosCA.Email, datosCA.Telefono);
            }
        }

        /// <summary>
        /// Instancia de la clase Cuarto Árbitro.
        /// </summary>
        CuartoArbitro CA;

        /// <summary>
        /// Método recogerDatosEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
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

        /// <summary>
        /// Método llenarDatosFormEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena los TexBox de Editar con los datos del Cuarto Árbitro seleccionado.
        /// </remarks>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
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

        /// <summary>
        /// Modificar datos de Cuarto Árbitro en la BD.
        /// </summary>
        /// <param name="cuartoArbitro">Objeto Cuarto Árbitro.</param>
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

        /// <summary>
        /// Método eliminarArbitro de la interface IAdm
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
            cuartoArbitro = new CuartoArbitro();
            cuartoArbitro.IdArbitro = idArbitro;
            cuartoArbitro.Cedula = cedula;
            cuartoArbitro.Nombre = nombre;
            cuartoArbitro.Apellidos = apellido;
            cuartoArbitro.Domicilio = domicilio;
            cuartoArbitro.Email = email;
            cuartoArbitro.Telefono = telefono;
            int idNuevo = 0;

            if (cuartoArbitro != null) {
                eliminarCuartoArbitroBD(idArbitro);
                idNuevo = GuardarCuartoArbitroBD(cuartoArbitro);
            }
            return idNuevo;
        }

        /// <summary>
        /// Eliminar "lógico" en la BD
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        private void eliminarCuartoArbitroBD (int idArbitro) {
            string mensaje = "";
            try {
                datos.eliminarCuartoArbitroBD(idArbitro);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
