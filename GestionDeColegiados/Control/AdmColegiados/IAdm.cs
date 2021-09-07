using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Interface para gestionar los Adm de todos los árbitros.
    /// </summary>
    public interface IAdm
    {
        /// <summary>
        /// Obtener los datos de los arbitros a guardar
        /// </summary>
        /// <param name="txtcedula">Cedula recogida.</param>
        /// <param name="txtnombre">Nombre recogido.</param>
        /// <param name="txtapellido">Apellido recogido.</param>
        /// <param name="txtdomicilio">Domicilio recogido.</param>
        /// <param name="txtemail">Email recogido.</param>
        /// <param name="txttelefono">Telefono recogido.</param>
        /// <returns>Devolverá el último id registrado como entero.</returns>
        int guardar (TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono);

        /// <summary>
        /// Método para obtener datos del colegiado seleccionado.
        /// </summary>
        /// <param name="id">ID de un árbitro.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        void obtenerDatos (int id, DataGridView dgvListarColegiados);

        /// <summary>
        /// Método recoger datos para editar.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
        void recogerDatosEditar (DataGridViewRow filaSeleccionada);

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
        void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido,
            TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono);

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
        void editarArbitro (int idArbitro, string cedula, string nombre, string apellido, 
            string domicilio, string email, string telefono);

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
        int eliminarArbitro (int idArbitro, string cedula, string nombre, string apellido, 
            string domicilio, string email, string telefono);
    }
}