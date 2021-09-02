using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmAsistente1 : IAdm
    {
        List<Asistente> listaAsistente1 = new List<Asistente>();
        Asistente asistente1 = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmAsistente1 admA1 = null;

        public List<Asistente> ListaAsistente1 { get => listaAsistente1; set => listaAsistente1 = value; }
        
        //Paso para el uso de Singleton
        //Creando atributo privado y estático de la misma clase
        private AdmAsistente1 ()
        {
            listaAsistente1 = new List<Asistente>();
        }

        public static AdmAsistente1 getAdmA1()
        {
            if (admA1 == null)
                admA1 = new AdmAsistente1();
            return admA1;
        }

        //Método guardar de la interface IAdm
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
        
        //Guardar datos a la BD
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

        //Método obtenerDatos de la interface IAdm
        public void obtenerDatos (int id, DataGridView dgvListarColegiados) {
            listaAsistente1 = datos.consultarAsistente1(id);
            foreach (Asistente datosAs1 in listaAsistente1) {
                dgvListarColegiados.Rows.Add("Asistente 1", datosAs1.Cedula, datosAs1.Nombre, datosAs1.Apellidos, datosAs1.Domicilio, datosAs1.Email, datosAs1.Telefono);
            }
        }

        //Editar
        //Método recogerDatosEditar de la interface IAdm
        Asistente as1;
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

        //Método llenarDatosFormEditar de la interface IAdm
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

        //Método editarArbitro de la interface IAdm
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

        //Modificar datos en la BD
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
    }
}
