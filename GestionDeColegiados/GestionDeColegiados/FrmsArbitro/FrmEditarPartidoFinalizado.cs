using Control.AdmEncuentros;
using Control.AdmEncuentrosGenerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados.FrmsArbitro
{
    public partial class FrmEditarPartidoFinalizado : Form
    {
        private AdmEncuentrosDefinidos admEncuentrosDefinidos = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
        private AdmEncuentroFinalizado admEncuentroFinalizado = AdmEncuentroFinalizado.GetAdmEncuentrosFinalizados();
        public FrmEditarPartidoFinalizado()
        {
            InitializeComponent();
            bool lleno = admEncuentrosDefinidos.LlenarCmbEncuentrosDefinidosFinalizados(cmbEncuentros);
            cambiarDisponibilidadControladoresUi(false);

        }
        private void cambiarDisponibilidadControladoresUi(bool estado)
        {
            lblEquipoLocal.Enabled = estado;
            lblEquipoVisitante.Enabled = estado;
            txtGolesLocal.Enabled = estado;
            txtGolesVisitante.Enabled = estado;
            lblPuntosLocal1.Enabled = estado;
            lblPuntosVisitante.Enabled = estado;
            lblPuntosLocalResultado.Visible = estado;
            lblPuntosVisitanteResultado.Visible = estado;     
        }

        private void refrezcarComponentes()
        {
            int index = cmbEncuentros.SelectedIndex;
            admEncuentrosDefinidos.LlenarMatchDefinidosFinalizados(index, lblEquipoLocal, lblEquipoVisitante);
            admEncuentroFinalizado.LlenarInformacionPartido(index, txtGolesLocal, txtGolesVisitante, lblPuntosLocalResultado, lblPuntosVisitanteResultado);
        }

        private void cmbEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrezcarComponentes();
            cambiarDisponibilidadControladoresUi(true);
            btnGuardarCambios.Enabled = false;
        }

        private void Actualizado(bool respuesta)
        {
            btnGuardarCambios.Enabled = !respuesta;
        }
        private void Actualizar()
        {
            string golesLocal = txtGolesLocal.Text;
            string golesVisitante = txtGolesVisitante.Text;
            if (String.IsNullOrEmpty(golesLocal) || String.IsNullOrEmpty(golesVisitante))
            {
                MessageBox.Show("Ingrese la cantidad de Goles realizado por los equipos correctamente");
            }
            else
            {
                int index = cmbEncuentros.SelectedIndex;
                bool actualizo = admEncuentroFinalizado.UpdateEncuentroFinalizado(index, golesLocal, golesVisitante);
                Actualizado(actualizo);
            }
            
        }
        private void ActualizarPuntos()
        {
            string golLocal = txtGolesLocal.Text;
            string golVisitante = txtGolesVisitante.Text;
            admEncuentroFinalizado.CalcularPuntos(lblPuntosLocalResultado, golLocal, golVisitante);
            admEncuentroFinalizado.CalcularPuntos(lblPuntosVisitanteResultado, golVisitante, golLocal);

        }

        private void txtGoles_TextChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = true;
            ActualizarPuntos();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
