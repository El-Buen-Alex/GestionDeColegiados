using Data;
using Model;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    /// <summary>
    /// Clase para la gestión de Colegiados.
    /// </summary>
    /// <remarks>
    /// Crea las listas, instancias y validaciones para obtener los datos de Colegiados.
    /// </remarks>
    public class AdmColegiado
    {
        List<Colegiado> listaColegiado = new List<Colegiado>();
        Colegiado colegiado = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();
        DatosEncuentroDefinido datosEncuentroDefinido = null;
        private List<IntegrantesColegiados> listaintegColeg;
        private static AdmColegiado admCol = null;
        Contexto contexto = null;
        DataGridViewRow filaSeleccionada = null;

        public List<Colegiado> ListaColegiado { get => listaColegiado; set => listaColegiado = value; }
        public List<IntegrantesColegiados> ListaintegColeg { get => listaintegColeg; set => listaintegColeg = value; }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo privado de la clase AdmColegiado.
        /// </remarks>
        private AdmColegiado ()
        {
            listaColegiado = new List<Colegiado>();
        }

        /// <summary>
        /// Paso para el uso de Singleton.
        /// </summary>
        /// <remarks>
        /// Creando atributo estático de la clase AdmColegiado.
        /// </remarks>
        /// <returns>Devuelve una instancia de AdmColegiado.</returns>
        public static AdmColegiado getAdmCol()
        {
            if (admCol == null)
                admCol = new AdmColegiado();
            return admCol;
        }

        /// <summary>
        /// Llenar ComboBox con nombres de Juez Central.
        /// </summary>
        /// <param name="cmbGrupoColegiado"> ComboBox recogido.</param>
        public void LlenarColegiadosCmb(ComboBox cmbGrupoColegiado)
        {
            listaintegColeg = new List<IntegrantesColegiados>();
            listaintegColeg = datos.ConsultarColegiado();
            cmbGrupoColegiado.DisplayMember = "NombrejuezCentral";
            cmbGrupoColegiado.DataSource = listaintegColeg;

        }

        /// <summary>
        /// LLenar lista de integrantes de colegiados.
        /// </summary>
        public void llenarListaColegiados()
        {
            listaintegColeg = datos.ConsultarColegiado();
        }

        /// <summary>
        /// Guardar id de todos los arbitros.
        /// </summary>
        /// <param name="idjuezcentral">ID del juez central.</param>
        /// <param name="idasistente1">ID del asistente 1.</param>
        /// <param name="idasistente2">ID del asistente 2.</param>
        /// <param name="idcuartoarbitro">ID del cuarto arbitro.</param>
        public void Guardar(int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro)
        {
            colegiado = new Colegiado(0, idjuezcentral, idasistente1, idasistente2, idcuartoarbitro);

            if (colegiado != null)
            {
                listaColegiado.Add(colegiado);
                GuardarColegiadoBD(colegiado); //Guardar BD
            }
        }

        /// <summary>
        /// Guardar datos de colegiado en la BD.
        /// </summary>
        /// <param name="colegiado">Objeto colegiado.</param>
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

        /// <summary>
        /// Listar datos con los nombres de los colegiados.
        /// </summary>
        /// <param name="cmbIdArbitro">ComboBox seleccionado de colegiado.</param>
        public void llenarComboIdColegiado (ComboBox cmbIdArbitro) {
            cmbIdArbitro.DataSource = null;
            cmbIdArbitro.Items.Clear();

            List<int> listaIdArbitro = new List<int>();
            listaIdArbitro = datos.consultarIdColegiado();
            foreach (int datosId in listaIdArbitro) {
                cmbIdArbitro.Items.Add("Grupo " + datosId);
            }
        }

        /// <summary>
        /// Llenar el DataGridView con los datos de los árbitros.
        /// </summary>
        /// <remarks>
        /// Se llena el DataGridView de acuerdo a un contexto de árbitros determinado.
        /// </remarks>
        /// <param name="dgvListarColegiados">DataGridView que se va a llenar con los datos de los árbitros.</param>
        /// <param name="cmbIdArbitro">Combobox o grupo de colegiado seleccionado.</param>
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

        /// <summary>
        /// Obtener nombres indexados de colegiados.
        /// </summary>
        /// <param name="indexColegiados">Numero index de colegiado.</param>
        /// <returns>Devuelve el id del colegiado consultado como entero.</returns>
        public string ObtenerNombreDeColegiadosIndex(int indexColegiados)
        {
            int id = listaintegColeg[indexColegiados].IdGrupoColegiado;
            return ObtenerNombreDeColegiados(id);
        }

        /// <summary>
        /// Obtener nombres de colegiado consultado.
        /// </summary>
        /// <param name="idColegiado">ID del colegiado que se va a buscar.</param>
        /// <returns>Delvuelve el nombre del colegiado consultado como string.</returns>
        public string ObtenerNombreDeColegiados(int idColegiado)
        {
            string nombres = "0";
            nombres = datos.ObtenerNombreDeColegiados(idColegiado);
            return nombres;
        }

        /// <summary>
        /// Obtener Cantidad de Colegiados.
        /// </summary>
        /// <returns>Devuelve la cantidad de colegiados registrados.</returns>
        public int obtenerCantidadColegiado()
        {
            listaintegColeg = datos.ConsultarColegiado();
            return listaintegColeg.Count;
        }

        /// <summary>
        /// Consulta para validar si el arbitro ya está registrado.
        /// </summary>
        /// <param name="txtcedula">Cedula que se va a validar.</param>
        /// <returns>Devuelve true si la cedula está repetida o false si es una nueva.</returns>
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

        /// <summary>
        /// Llenar ComboBox con los nombres de arbitros registrados como colegiado.
        /// </summary>
        /// <param name="cmbGrupoColegiado"></param>
        /// <param name="idColegiados"></param>
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

        /// <summary>
        /// Método estático para obtener la implementación de un contexto.
        /// </summary>
        /// <remarks>
        /// La implementación se obtiene de acuerdo a una fila seleccionada de un DataGridView.
        /// </remarks>
        /// <param name="filaSeleccionada">Fila seleccionada del DataGridview</param>
        /// <returns>Devuelve la implementación de un contexto de árbitro.</returns>
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

        /// <summary>
        /// Método para recoger los datos del colegiado seleccionado.
        /// </summary>
        /// <param name="dgvListarColegiados">Datos obtenidos del DataGridView de colegiados.</param>
        public void recogerDatosEditar (DataGridView dgvListarColegiados) {
            filaSeleccionada = dgvListarColegiados.CurrentRow;
            contexto = escogerArbitro(filaSeleccionada);
            contexto.recogerDatosEditar(filaSeleccionada);
        }

        /// <summary>
        /// Llenar FrmEditar con datos.
        /// </summary>
        /// <param name="txtCedula">Cedula.</param>
        /// <param name="txtNombre">Nombre.</param>
        /// <param name="txtApellido">Apellido.</param>
        /// <param name="txtDomicilio">Domicilio.</param>
        /// <param name="txtEmail">Email.</param>
        /// <param name="txtTelefono">Telefono.</param>
        public void LlenarDatosFormEditar (TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDomicilio, TextBox txtEmail, TextBox txtTelefono) {
            contexto = escogerArbitro(filaSeleccionada);
            contexto.llenarDatosFormEditar(txtCedula, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono);
        }

        /// <summary>
        /// Método para obtener el id del algun arbitro seleccionado.
        /// </summary>
        /// <param name="idColegiado">ID del grupo del colegiado al que pertenece el arbitro.</param>
        /// <param name="filaSeleccionada">Datos del arbitro seleccionado en el DataGridView.</param>
        /// <returns>Devuelve el id del arbitro seleccionado como entero.</returns>
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

        /// <summary>
        /// Método para editar el árbitro seleccionado.
        /// </summary>
        /// <param name="lblID">ID del colegiado al que pertenece el árbitro.</param>
        /// <param name="cedula">Cedula.</param>
        /// <param name="nombre">Nombre.</param>
        /// <param name="apellido">Apellido.</param>
        /// <param name="domicilio">Domicilio.</param>
        /// <param name="email">Email.</param>
        /// <param name="telefono">Teléfono.</param>
        public void editarArbitro (string lblID, string cedula, string nombre, string apellido, string domicilio, string email, string telefono) {
            char delimitador = ' ';
            string[] cadena = lblID.Split(delimitador);
            int idColegiado = Convert.ToInt32(cadena[1]);
            int idArbitro = obtenerIDArbitro(idColegiado, filaSeleccionada);
            contexto = escogerArbitro(filaSeleccionada);
            contexto.editarArbitro(idArbitro, cedula, nombre, apellido, domicilio, email, telefono);
        }

        /// <summary>
        /// Recoger datos para eliminar el árbitro seleccionado.
        /// </summary>
        /// <param name="dgvListarColegiados">Datos del DataGridView.</param>
        public void recogerDatosEliminar (DataGridView dgvListarColegiados) {
            filaSeleccionada = dgvListarColegiados.CurrentRow;
        }

        /// <summary>
        /// Método eliminar árbitro 
        /// </summary>
        /// <param name="lblID">ID del colegiado al que pertenece el árbitro.</param>
        /// <param name="cedula">Cedula.</param>
        /// <param name="nombre">Nombre.</param>
        /// <param name="apellido">Apellido.</param>
        /// <param name="domicilio">Domicilio.</param>
        /// <param name="email">Email.</param>
        /// <param name="telefono">Teléfono.</param>
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
                actualizarColegiadoBD(idColegiado,idNuevo,arbitro);
            }
        }

        /// <summary>
        /// Actualizar el id del nuevo colegiado agregado después de eliminar.
        /// </summary>
        /// <param name="idColegiado">ID del colegiado.</param>
        /// <param name="idNuevo">El nuevo ID generado después de insertar.</param>
        /// <param name="arbitro">Tipo de árbitro.</param>
        private void actualizarColegiadoBD (int idColegiado, int idNuevo, string arbitro) {
            string mensaje = "";
            try {
                datos.actualizarColegiadoBD(idColegiado, idNuevo, arbitro);
                MessageBox.Show("Sus datos fueron agregados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Método para eliminar colegiado completo.
        /// </summary>
        /// <param name="colegiadoSeleccionado">Obtener el colegiado seleccionado.</param>
        /// <returns>Devuelve true si fue eliminado o false si ocurrió algún error.</returns>
        public bool eliminarColegiado (string colegiadoSeleccionado) {
            bool eliminado = false;
            char delimitador = ' ';
            string[] cadena = colegiadoSeleccionado.Split(delimitador);
            int idColegiado = Convert.ToInt32(cadena[1]);
            bool arbitroAsignado = validarArbitroAsignado(idColegiado);
            if (arbitroAsignado != true) {
                eliminarColegiadoBD(idColegiado);
                eliminado = true;
            } else {
                MessageBox.Show("El "+colegiadoSeleccionado+" no se puede eliminar porque\nya se encuentra asignado en un encuentro!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return eliminado;
        }

        /// <summary>
        /// Validar si el árbitro ya está asignado.
        /// </summary>
        /// <param name="idColegiado">ID del colegiado al cual pertenece el árbitro.</param>
        /// <returns>Devueleve true si el árbitro fue asignado o false si no está asignado.</returns>
        private bool validarArbitroAsignado (int idColegiado) {
            List<EncuentroDefinido> listaEncuentro = new List<EncuentroDefinido>();
            datosEncuentroDefinido = new DatosEncuentroDefinido();
            listaEncuentro = datosEncuentroDefinido.ObtenerEncuentros();
            foreach (EncuentroDefinido encuentroDefinido in listaEncuentro) {
                if(encuentroDefinido.IdColegiado == idColegiado) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Eliminar "lógico" en la BD de colegiado.
        /// </summary>
        /// <param name="idColegiado">ID del colegiado a eliminar.</param>
        private void eliminarColegiadoBD (int idColegiado) {
            string mensaje = "";
            try {
                datos.eliminarColegiado(idColegiado);
                MessageBox.Show("Se eliminó el colegiado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (falloBDException ex) {
                mensaje = ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
} 