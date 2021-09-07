using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase para la gestión de Asistente2.
    /// </summary>
    /// <remarks>
    /// Crea las listas, instancias y validaciones para obtener los datos de Asistente2.
    /// </remarks>
    public class AdmAsistente2 : IAdm
    {
        List<Asistente> listaAsistente2 = new List<Asistente>();
        Asistente asistente2 = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmAsistente2 admA2 = null;

        public List<Asistente> ListaAsistente2 { get => listaAsistente2; set => listaAsistente2 = value; }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo privado de la clase AdmAsistente2.
        /// </remarks>
        private AdmAsistente2 ()
        {
            listaAsistente2 = new List<Asistente>();
        }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo estático de la clase AdmAistente2.
        /// </remarks>
        /// <returns>Devuelve una instancia de AdmAsistente2.</returns>
        public static AdmAsistente2 getAdmA2()
        {
            if (admA2 == null)
                admA2 = new AdmAsistente2();
            return admA2;
        }

        /// <summary>
        /// Método guardar de la interface IAdm.
        /// </summary>
        /// <param name="txtcedulaAs2">Cedula recogida.</param>
        /// <param name="txtnombreAs2">Nombre recogido.</param>
        /// <param name="txtapellidoAs2">Apellido recogido.</param>
        /// <param name="txtdomicilioAs2">Domicilio recogido.</param>
        /// <param name="txtemailAs2">Email recogido.</param>
        /// <param name="txttelefonoAs2">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
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

        /// <summary>
        /// Guardar datos de Asistente2 en la BD.
        /// </summary>
        /// <param name="asistente2">Objeto Asistente2.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        private int GuardarAsistente2BD(Asistente asistente2)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarAsistente2(asistente2);
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
        /// <param name="id">ID de un Asistente2.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaAsistente2 = datos.consultarAsistente2(id);
            foreach (Asistente datosAs2 in listaAsistente2) {
                dgvListarColegiados.Rows.Add("Asistente 2", datosAs2.Cedula, datosAs2.Nombre, datosAs2.Apellidos, datosAs2.Domicilio, datosAs2.Email, datosAs2.Telefono);
            }
        }

        /// <summary>
        /// Instancia de la clase Asistente.
        /// </summary>
        Asistente as2;

        /// <summary>
        /// Método recogerDatosEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            foreach (Asistente asistente in listaAsistente2) {
                if (asistente.Cedula == filaSeleccionada.Cells[1].Value.ToString() &&
                    asistente.Nombre == filaSeleccionada.Cells[2].Value.ToString() &&
                    asistente.Apellidos == filaSeleccionada.Cells[3].Value.ToString() &&
                    asistente.Domicilio == filaSeleccionada.Cells[4].Value.ToString() &&
                    asistente.Email == filaSeleccionada.Cells[5].Value.ToString() &&
                    asistente.Telefono == filaSeleccionada.Cells[6].Value.ToString()) {
                    as2 = asistente;
                }
            }
        }


        /// <summary>
        /// Método llenarDatosFormEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena los TexBox de Editar con los datos del Asistente2 seleccionado.
        /// </remarks>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            try {
                txtCedula.Text = as2.Cedula.ToString();
                txtNombre.Text = as2.Nombre.ToString();
                txtApellido.Text = as2.Apellidos.ToString();
                txtDomicilio.Text = as2.Domicilio.ToString();
                txtEmail.Text = as2.Email.ToString();
                txtTelefono.Text = as2.Telefono.ToString();
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
            asistente2 = new Asistente();
            asistente2.IdArbitro = idArbitro;
            asistente2.Cedula = cedula;
            asistente2.Nombre = nombre;
            asistente2.Apellidos = apellido;
            asistente2.Domicilio = domicilio;
            asistente2.Email = email;
            asistente2.Telefono = telefono;

            if (asistente2 != null) {
                editarAsistente2BD(asistente2);
            }
        }

        /// <summary>
        /// Modificar datos de Asistente1 en la BD.
        /// </summary>
        /// <param name="asistente2">Objeto Asistente2.</param>
        private void editarAsistente2BD (Asistente asistente2) {
            string mensaje = "";
            try {
                datos.editarAsistente2BD(asistente2);
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
            asistente2 = new Asistente();
            asistente2.IdArbitro = idArbitro;
            asistente2.Cedula = cedula;
            asistente2.Nombre = nombre;
            asistente2.Apellidos = apellido;
            asistente2.Domicilio = domicilio;
            asistente2.Email = email;
            asistente2.Telefono = telefono;
            asistente2.Banda = "Izquierda";
            int idNuevo = 0;

            if (asistente2 != null) {
                eliminarAsistente2BD(idArbitro);
                idNuevo = GuardarAsistente2BD(asistente2);
            }
            return idNuevo;
        }

        /// <summary>
        /// Eliminar "lógico" en la BD
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        private void eliminarAsistente2BD (int idArbitro) {
            string mensaje = "";
            try {
                datos.eliminarAsistente2BD(idArbitro);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
