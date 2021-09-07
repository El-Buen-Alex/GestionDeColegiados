using System;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase contexto para aplicar patrón de diseño Strategy.
    /// </summary>
    public class Contexto
    {
        private IAdm adm;

        /// <summary>
        /// Constructor de la clase contexto.
        /// </summary>
        /// <param name="adm">Instacia de la clase adm.</param>
        public Contexto (IAdm adm)
        {
            this.adm = adm;
        }

        /// <summary>
        /// Obtener los datos de los arbitros a guardar
        /// </summary>
        /// <param name="txtcedula">Cedula recogida.</param>
        /// <param name="txtnombre">Nombre recogido.</param>
        /// <param name="txtapellido">Apellido recogido.</param>
        /// <param name="txtdomicilio">Domicilio recogido.</param>
        /// <param name="txtemail">Email recogido.</param>
        /// <param name="txttelefono">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        public int obtenerDatos(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono)
        {

            return this.adm.guardar(txtcedula, txtnombre, txtapellido,
            txtdomicilio, txtemail, txttelefono);
        }

        /// <summary>
        /// Método para obtener datos del colegiado seleccionado.
        /// </summary>
        /// <param name="id">ID de un árbitro.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        public void datos (int id, DataGridView dgvListarColegiados) {
            adm.obtenerDatos(id, dgvListarColegiados);
        }

        /// <summary>
        /// Método recoger datos para editar.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            adm.recogerDatosEditar(filaSeleccionada);
        }

        /// <summary>
        /// Método para llenar datos del FormEditar.
        /// </summary>
        /// <remarks>
        /// Llena los TexBox de Editar con los datos del árbitro seleccionado.
        /// </remarks>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, 
            TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            adm.llenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
        }

        /// <summary>
        /// Método para editar árbitro.
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
            adm.editarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
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
            return this.adm.eliminarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
        }
    }
}