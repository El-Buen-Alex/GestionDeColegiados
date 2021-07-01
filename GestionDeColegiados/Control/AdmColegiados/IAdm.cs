using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public interface IAdm {
        int guardar (TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono);
    }
}
