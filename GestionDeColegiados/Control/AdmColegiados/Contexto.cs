using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class Contexto {
        private IAdm adm;

        public Contexto (IAdm adm) {
            this.adm = adm;
        }

        public int obtenerDatos (TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono) {

            return this.adm.guardar(txtcedula, txtnombre, txtapellido,
            txtdomicilio, txtemail, txttelefono);
        }
    }
}
