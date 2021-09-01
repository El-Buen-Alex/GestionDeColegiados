using System;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class Contexto
    {
        private IAdm adm;

        //Constructor
        public Contexto(IAdm adm)
        {
            this.adm = adm;
        }

        //Obtener los datos de los arbitros a guardar
        public int obtenerDatos(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono)
        {

            return this.adm.guardar(txtcedula, txtnombre, txtapellido,
            txtdomicilio, txtemail, txttelefono);
        }
        
        public void datos (int id, DataGridView dgvListarColegiados) {
            adm.obtenerDatos(id, dgvListarColegiados);
        }

        public void recogerDatosEditar (DataGridViewRow filaSeleccionada) {
            adm.recogerDatosEditar(filaSeleccionada);
        }

        public void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, 
            TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            adm.llenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
        }

        internal void editarArbitro (int idArbitro, string cedula, string nombre, string apellido, 
            string domicilio, string email, string telefono) {
            adm.editarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
        }
    }
}
