using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control.AdmEncuentros;

namespace GestionDeColegiados.FrmsArbitro
{
   public partial class FrmVerCompeticion : Form
    {
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();

        public FrmVerCompeticion()
        {
            InitializeComponent();
            admEncuentroFinalizado.LlenarDgv(dgvCompeticion);
        }
    }
}
