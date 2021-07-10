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
    }
}
