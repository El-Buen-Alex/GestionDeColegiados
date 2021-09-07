using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase para la gestión de Asistente1.
    /// </summary>
    /// <remarks>
    /// Crea las listas, instancias y validaciones para obtener los datos de Asistente1.
    /// </remarks>
    public class AdmAsistente1 : IAdm
    {
        List<Asistente> listaAsistente1 = new List<Asistente>();
        Asistente asistente1 = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmAsistente1 admA1 = null;

        public List<Asistente> ListaAsistente1 { get => listaAsistente1; set => listaAsistente1 = value; }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo privado de la clase AdmAsistente1.
        /// </remarks>
        private AdmAsistente1 ()
        {
            listaAsistente1 = new List<Asistente>();
        }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo estático de la clase AdmAistente1.
        /// </remarks>
        /// <returns>Devuelve una instancia de AdmAsistente1.</returns>
        public static AdmAsistente1 getAdmA1()
        {
            if (admA1 == null)
                admA1 = new AdmAsistente1();
            return admA1;
        }

        /// <summary>
        /// Método guardar de la interface IAdm.
        /// </summary>
        /// <param name="txtcedulaAs1">Cedula recogida.</param>
        /// <param name="txtnombreAs1">Nombre recogido.</param>
        /// <param name="txtapellidoAs1">Apellido recogido.</param>
        /// <param name="txtdomicilioAs1">Domicilio recogido.</param>
        /// <param name="txtemailAs1">Email recogido.</param>
        /// <param name="txttelefonoAs1">Telefono recogido.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        public int guardar(TextBox txtcedulaAs1, TextBox txtnombreAs1, TextBox txtapellidoAs1,
            TextBox txtdomicilioAs1, TextBox txtemailAs1, TextBox txttelefonoAs1)
        {
            string cedula = txtcedulaAs1.Text,
                nombre = txtnombreAs1.Text,
                apellidos = txtapellidoAs1.Text,
                domicilio = txtdomicilioAs1.Text,
                email = txtemailAs1.Text,
                telefono = txttelefonoAs1.Text;
            int id = 0;

            asistente1 = new Asistente(0, cedula, nombre, apellidos, domicilio, email, telefono, "Derecha");

            if (asistente1 != null)
            {
                listaAsistente1.Add(asistente1);      //Añadir a la lista
                id = GuardarAsistente1BD(asistente1); //Guardar BD
            }
            return id;
        }

        /// <summary>
        /// Guardar datos de Asistente1 en la BD.
        /// </summary>
        /// <param name="asistente1">Objeto Asistente1.</param>
        /// <returns>Devuelve el último id registrado como entero.</returns>
        private int GuardarAsistente1BD(Asistente asistente1)
        {
            int id = 0;
            string mensaje = "";
            try {
                id = datos.InsertarAsistente1(asistente1);
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
        /// <param name="id">ID de un Asistente1.</param>
        /// <param name="dgvListarColegiados">DataGridView que va a ser llenado con datos.</param>
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaAsistente1 = datos.consultarAsistente1(id);
            foreach (Asistente datosAs1 in listaAsistente1) {
                dgvListarColegiados.Rows.Add("Asistente 1", datosAs1.Cedula, datosAs1.Nombre, datosAs1.Apellidos, datosAs1.Domicilio, datosAs1.Email, datosAs1.Telefono);
            }
        }
        
        /// <summary>
        /// Instancia de la clase Asistente.
        /// </summary>
        Asistente as1;

        /// <summary>
        /// Método recogerDatosEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Recoge los datos que son seleccionados para editar por el usuario.
        /// </remarks>
        /// <param name="filaSeleccionada">DataGridViewRow que contiene los datos seleccionado por el usuario.</param>
        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            foreach(Asistente asistente in listaAsistente1) {
                if (asistente.Cedula == filaSeleccionada.Cells[1].Value.ToString() &&
                    asistente.Nombre == filaSeleccionada.Cells[2].Value.ToString() &&
                    asistente.Apellidos == filaSeleccionada.Cells[3].Value.ToString() &&
                    asistente.Domicilio == filaSeleccionada.Cells[4].Value.ToString() &&
                    asistente.Email == filaSeleccionada.Cells[5].Value.ToString() &&
                    asistente.Telefono == filaSeleccionada.Cells[6].Value.ToString()) {
                    as1 = asistente;
                }
            }
        }

        /// <summary>
        /// Método llenarDatosFormEditar de la interface IAdm.
        /// </summary>
        /// <remarks>
        /// Llena los TexBox de Editar con los datos del Asistente1 seleccionado.
        /// </remarks>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            try {
                txtCedula.Text = as1.Cedula.ToString();
                txtNombre.Text = as1.Nombre.ToString();
                txtApellido.Text = as1.Apellidos.ToString();
                txtDomicilio.Text = as1.Domicilio.ToString();
                txtEmail.Text = as1.Email.ToString();
                txtTelefono.Text = as1.Telefono.ToString();
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
            asistente1 = new Asistente();
            asistente1.IdArbitro = idArbitro;
            asistente1.Cedula = cedula;
            asistente1.Nombre = nombre;
            asistente1.Apellidos = apellido;
            asistente1.Domicilio = domicilio;
            asistente1.Email = email;
            asistente1.Telefono = telefono;

            if (asistente1 != null) {
               editarAsistente1BD(asistente1);
            }
        }

        /// <summary>
        /// Modificar datos de Asistente1 en la BD.
        /// </summary>
        /// <param name="asistente1">Objeto Asistente1.</param>
        private void editarAsistente1BD (Asistente asistente1) {
            string mensaje = "";
            try {
                datos.editarAsistente1BD(asistente1);
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
            asistente1 = new Asistente();
            asistente1.IdArbitro = idArbitro;
            asistente1.Cedula = cedula;
            asistente1.Nombre = nombre;
            asistente1.Apellidos = apellido;
            asistente1.Domicilio = domicilio;
            asistente1.Email = email;
            asistente1.Telefono = telefono;
            asistente1.Banda = "Derecha";
            int idNuevo = 0;
            
            if (asistente1 != null){
                eliminarAsistente1BD(idArbitro);
                idNuevo = GuardarAsistente1BD(asistente1);
            }
            return idNuevo;
        }

        /// <summary>
        /// Eliminar "lógico" en la BD.
        /// </summary>
        /// <param name="idArbitro">ID recogido.</param>
        private void eliminarAsistente1BD (int idArbitro) {
            string mensaje = "";
            try {
                datos.eliminarAsistente1BD(idArbitro);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}