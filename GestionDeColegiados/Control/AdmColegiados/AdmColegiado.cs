using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class AdmColegiado {
        List<Colegiado> listaColegiado = new List<Colegiado>();
        Colegiado colegiado = null;
        ValidacionGUI v = new ValidacionGUI();
        Datos datos = new Datos();

        private static AdmColegiado admCol= null;

        public List<Colegiado> ListaColegiado { get => listaColegiado; set => listaColegiado = value; }

        private AdmColegiado () {
            listaColegiado = new List<Colegiado>();
        }

        public static AdmColegiado getAdmCol () {
            if (admCol == null)
                admCol = new AdmColegiado();
            return admCol;
        }

        public void Guardar (int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro) {
            colegiado = new Colegiado(0,idjuezcentral,idasistente1,idasistente2,idcuartoarbitro);

            if (colegiado != null) {
                listaColegiado.Add(colegiado);
                GuardarColegiadoBD(colegiado); //Guardar BD
            }
        }

        private void GuardarColegiadoBD (Colegiado colegiado) {
            bool mensaje = false;
            mensaje = datos.InsertarColegiado(colegiado);
            if (mensaje == false) {
                MessageBox.Show("No se ha podido comunicar con la BD");
            } else {
                MessageBox.Show("Se ha guardado correctamente");
            }
        }

        //Listar
        /*public int getLista () { //Método para devolver el numero de listas
            return ListaColegiado.Count;
        }

        private void llenar (DataGridView dgvListarColegiados) {
            dgvListarColegiados.Rows.Clear();
            foreach (Colegiado colegiado in listaColegiado) {
                dgvListarColegiados.Rows.Add();
            }
        }

        public void LlenarDatos (DataGridView dgvListarColegiados) {
            throw new NotImplementedException();
        }

        private void ConsultarColegiadoBD () {
            listaColegiado = datos.ConsultarColegiado();
            if (listaColegiado.Count == 0)
                MessageBox.Show("No hay elementos en la tabla");
        }*/
    }
}
