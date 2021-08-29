using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public interface IAdm
    {
        int guardar(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono);
        void obtenerDatos (int id, DataGridView dgvListarColegiados);
        void recogerDatosEditar (DataGridViewRow filaSeleccionada);
        void llenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido,
            TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono);
    }
}