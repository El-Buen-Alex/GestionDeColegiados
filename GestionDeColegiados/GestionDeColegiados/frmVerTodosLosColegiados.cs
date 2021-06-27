using Control.AdmColegiados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmVerTodosLosColegiados : Form {
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        public frmVerTodosLosColegiados() {
            InitializeComponent();
            //admColegiado.LlenarDatos(dgvListarColegiados);
        }
    }
}
