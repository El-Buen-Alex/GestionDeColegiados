using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmColegiado
    {
        List<Colegiado> listaColegiado = new List<Colegiado>();
        Colegiado colegiado = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();
        private List<IntegrantesColegiados> listaintegColeg;
        private static AdmColegiado admCol = null;
        Contexto contexto = null;
        DataGridViewRow filaSeleccionada = null;

        public List<Colegiado> ListaColegiado { get => listaColegiado; set => listaColegiado = value; }
        public List<IntegrantesColegiados> ListaintegColeg { get => listaintegColeg; set => listaintegColeg = value; }

        //Paso para el uso de Singleton
        //Creando atributo privado y estático de la misma clase
        private AdmColegiado ()
        {
            listaColegiado = new List<Colegiado>();
        }

        public static AdmColegiado getAdmCol()
        {
            if (admCol == null)
                admCol = new AdmColegiado();
            return admCol;
        }

        //Llenar ComboBox con nombres de Juez Central
        public void LlenarColegiadosCmb(ComboBox cmbGrupoColegiado)
        {
            listaintegColeg = new List<IntegrantesColegiados>();
            listaintegColeg = datos.ConsultarColegiado();
            cmbGrupoColegiado.DisplayMember = "NombrejuezCentral";
            cmbGrupoColegiado.DataSource = listaintegColeg;

        }
        public void llenarListaColegiados()
        {
            listaintegColeg = datos.ConsultarColegiado();
        }
        //Guardar id de todos los arbitros
        public void Guardar(int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro)
        {
            colegiado = new Colegiado(0, idjuezcentral, idasistente1, idasistente2, idcuartoarbitro);

            if (colegiado != null)
            {
                listaColegiado.Add(colegiado);
                GuardarColegiadoBD(colegiado); //Guardar BD
            }
        }

        //Guardar colegiado en la BD
        private void GuardarColegiadoBD(Colegiado colegiado)
        {
            string mensaje = "";
            try {
                datos.InsertarColegiado(colegiado);
                MessageBox.Show("Se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("No se ha guardado el colegiado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Listar datos con los nombres de los colegiados
        public void llenarComboIdColegiado (ComboBox cmbIdArbitro) {
            List<int> listaIdArbitro = new List<int>();
            listaIdArbitro = datos.consultarIdColegiado();
            foreach (int datosId in listaIdArbitro) {
                cmbIdArbitro.Items.Add("Grupo " + datosId);
            }
        }

        public void llenarDatosGrivColegiado (DataGridView dgvListarColegiados, ComboBox cmbIdArbitro) {
            dgvListarColegiados.Rows.Clear();

            string colegiadoSeleccionado = cmbIdArbitro.Text;
            char delimitador = ' ';
            string[] cadena = colegiadoSeleccionado.Split(delimitador);
            int id = Convert.ToInt32(cadena[1]);

            contexto = new Contexto(AdmJuezCentral.getAdmJ());
            contexto.datos(id, dgvListarColegiados);

            contexto = new Contexto(AdmAsistente1.getAdmA1());
            contexto.datos(id, dgvListarColegiados);

            contexto = new Contexto(AdmAsistente2.getAdmA2());
            contexto.datos(id, dgvListarColegiados);

            contexto = new Contexto(AdmCuartoArbitro.getAdmCA());
            contexto.datos(id, dgvListarColegiados);
        }

        public string ObtenerNombreDeColegiadosIndex(int indexColegiados)
        {
            int id = listaintegColeg[indexColegiados].IdGrupoColegiado;
            return ObtenerNombreDeColegiados(id);
        }

        public string ObtenerNombreDeColegiados(int idColegiado)
        {
            string nombres = "0";
            nombres = datos.ObtenerNombreDeColegiados(idColegiado);
            return nombres;
        }

        //Obtener Cantidad de Colegiados
        public int obtenerCantidadColegiado()
        {
            listaintegColeg = datos.ConsultarColegiado();
            return listaintegColeg.Count;
        }

        //Consulta para validar si el arbitro ya está registrado
        public bool validarCedula (TextBox txtcedula) 
        {
            string cedula = txtcedula.Text;
            bool repetido = false;
            listaintegColeg = datos.ConsultarCedulaColegiado();
            foreach(IntegrantesColegiados integ in listaintegColeg) 
            {
                if(integ.NombrejuezCentral == cedula || integ.Nombreasistente1 == cedula || 
                    integ.Nombreasistente2 == cedula || integ.NombrecuartoArbitro == cedula) 
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }

        public void LlenarColegiadosCmb(ComboBox cmbGrupoColegiado, int idColegiados)
        {
            LlenarColegiadosCmb(cmbGrupoColegiado);
            int i = 0;
            foreach (IntegrantesColegiados item in listaintegColeg)
            {
                if (item.IdGrupoColegiado == idColegiados)
                {
                    cmbGrupoColegiado.SelectedIndex = i;
                }
                i++;
            }
        }

        //Editar
        private static Contexto escogerArbitro (DataGridViewRow filaSeleccionada) {
            Contexto contextoArbitro = null;
            string arbitro = filaSeleccionada.Cells[0].Value.ToString();
            if (arbitro == "Juez Central") {
                contextoArbitro = new Contexto(AdmJuezCentral.getAdmJ());
            }
            if (arbitro == "Asistente 1") {
                contextoArbitro = new Contexto(AdmAsistente1.getAdmA1());
            }
            if (arbitro == "Asistente 2") {
                contextoArbitro = new Contexto(AdmAsistente2.getAdmA2());
            }
            if (arbitro == "Cuarto Árbitro") {
                contextoArbitro = new Contexto(AdmCuartoArbitro.getAdmCA());
            }
            return contextoArbitro;
        }

        public void recogerDatosEditar (DataGridView dgvListarColegiados) {
            filaSeleccionada = dgvListarColegiados.CurrentRow;
            contexto = escogerArbitro(filaSeleccionada);
            contexto.recogerDatosEditar(filaSeleccionada);
        }

        public void LlenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            contexto = escogerArbitro(filaSeleccionada);
            contexto.llenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
        }

        private int obtenerIDArbitro (int idColegiado, DataGridViewRow filaSeleccionada) {
            int idArbitro = 0;
            listaColegiado = datos.obtenerTodosIdColegiado(idColegiado);
            string arbitro = filaSeleccionada.Cells[0].Value.ToString();
            if (arbitro == "Juez Central") {
                foreach (Colegiado col in listaColegiado) {
                    idArbitro = col.Idjuezcentral;
                }
            }
            if (arbitro == "Asistente 1") {
                foreach (Colegiado col in listaColegiado) {
                    idArbitro = col.Idasistente1;
                }
            }
            if (arbitro == "Asistente 2") {
                foreach (Colegiado col in listaColegiado) {
                    idArbitro = col.Idasistente2;
                }
            }
            if (arbitro == "Cuarto Árbitro") {
                foreach (Colegiado col in listaColegiado) {
                    idArbitro = col.Idcuartoarbitro;
                }
            }
            return idArbitro;
        }

        public void editarArbitro (string lblID, string cedula, string nombre, string apellido, string domicilio, string email, string telefono) {
            char delimitador = ' ';
            string[] cadena = lblID.Split(delimitador);
            int idColegiado = Convert.ToInt32(cadena[1]);
            int idArbitro = obtenerIDArbitro(idColegiado, filaSeleccionada);
            contexto = escogerArbitro(filaSeleccionada);
            contexto.editarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
        }

        //Eliminar
        public void recogerDatosEliminar (DataGridView dgvListarColegiados) {
            filaSeleccionada = dgvListarColegiados.CurrentRow;
        }
        
        public void eliminarArbitro (string lblID, string cedula, string nombre, string apellido, string domicilio, string email, string telefono) {
            char delimitador = ' ';
            string[] cadena = lblID.Split(delimitador);
            int idColegiado = Convert.ToInt32(cadena[1]);
            int idArbitro = obtenerIDArbitro(idColegiado, filaSeleccionada);
            int idNuevo = 0;
            contexto = escogerArbitro(filaSeleccionada);
            idNuevo = contexto.eliminarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
            if (idNuevo != 0) {
                string arbitro = filaSeleccionada.Cells[0].Value.ToString();
                actualizarColegiado(idColegiado,idNuevo,arbitro);
            }
        }

        private void actualizarColegiado (int idColegiado, int idNuevo, string arbitro) {
            string mensaje = "";
            try {
                datos.actualizarColegiado(idColegiado, idNuevo, arbitro);
                MessageBox.Show("Sus datos fueron agregados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
} 