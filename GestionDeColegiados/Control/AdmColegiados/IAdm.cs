using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public interface IAdm
    {
        int guardar(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono);
    }
}
