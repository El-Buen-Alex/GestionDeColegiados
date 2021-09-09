using Control;
using Control.AdmColegiados;
using System;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    /// <summary>
    /// Formulario para agregar Áribtros.
    /// </summary>
    public partial class frmNuevoGrupoColegiado : Form
    {
        ValidacionGUI validacionGUI = new ValidacionGUI();
        Contexto contexto = null;
        AdmColegiado admColegiado = AdmColegiado.getAdmCol();

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmNuevoGrupoColegiado ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para validar que solo ingrese números.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void validarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento para validar que solo ingrese letras.
        /// </summary>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void validarLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Envento click para el primer botón siguiente.
        /// </summary>
        /// <remarks>
        /// Valida si los campos están, si hay cedulas repetidas y oculta TexBox de ingreso.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            bool cedulaRepetida = admColegiado.validarCedula(txtcedulaJC);
            bool txtcedulaRepetida = (txtcedulaJC.Text == txtcedulaAs1.Text) || (txtcedulaJC.Text == txtcedulaAs2.Text) || (txtcedulaJC.Text == txtcedulaCA.Text);
            if (vacio != true) {
                if (cedulaRepetida != true && txtcedulaRepetida != true) {
                    camposJuezCentral(false);
                    camposAsistente1(true);
                } else {
                    mensajeCedulaRepetida();
                }
            } else {
                camposIncompletos();
            }
        }

        /// <summary>
        /// Envento click para el segundo botón siguiente.
        /// </summary>
        /// <remarks>
        /// Valida si los campos están, si hay cedulas repetidas y oculta TexBox de ingreso.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            bool cedulaRepetida = admColegiado.validarCedula(txtcedulaAs1);
            bool txtcedulaRepetida = (txtcedulaAs1.Text == txtcedulaJC.Text) || (txtcedulaAs1.Text == txtcedulaAs2.Text) || (txtcedulaAs1.Text == txtcedulaCA.Text);
            if (vacio != true) {
                if (cedulaRepetida != true && txtcedulaRepetida != true) {
                    camposAsistente1(false);
                    camposAsistente2(true);
                } else {
                    mensajeCedulaRepetida();
                }
            } else {
                camposIncompletos();
            }
        }

        /// <summary>
        /// Evento click para el botón regresar.
        /// </summary>
        /// <remarks>
        /// Aparece junto al segundo botón siguiente.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnRegresar2_Click (object sender, EventArgs e) {
            camposAsistente1(false);
            camposJuezCentral(true);
        }

        /// <summary>
        /// Envento click para el tercer botón siguiente.
        /// </summary>
        /// <remarks>
        /// Valida si los campos están, si hay cedulas repetidas y oculta TexBox de ingreso.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnsiguiente3_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            bool cedulaRepetida = admColegiado.validarCedula(txtcedulaAs2);
            bool txtcedulaRepetida = (txtcedulaAs2.Text==txtcedulaJC.Text) || (txtcedulaAs2.Text==txtcedulaAs1.Text) || (txtcedulaAs2.Text==txtcedulaCA.Text);
            if (vacio != true) {
                if (cedulaRepetida != true && txtcedulaRepetida != true) {
                    camposAsistente2(false);
                    camposCuartoArbitro(true);
                } else {
                    mensajeCedulaRepetida();
                }
            } else {
                camposIncompletos();
            }
        }

        /// <summary>
        /// Evento click para el botón regresar.
        /// </summary>
        /// <remarks>
        /// Aparece junto al tercer botón siguiente.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnRegresar3_Click (object sender, EventArgs e) {
            camposAsistente2(false);
            camposAsistente1(true);
        }

        /// <summary>
        /// Envento click para el botón registrar.
        /// </summary>
        /// <remarks>
        /// Valida si los campos están, si hay cedulas repetidas, oculta TexBox de ingreso y registra Colegiado.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool vacio = validacionGUI.validarVacios(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            bool cedulaRepetida = admColegiado.validarCedula(txtcedulaCA);
            bool txtcedulaRepetida = (txtcedulaCA.Text == txtcedulaJC.Text) || (txtcedulaCA.Text == txtcedulaAs1.Text) || (txtcedulaCA.Text == txtcedulaAs2.Text);
            if (vacio != true) {
                if (cedulaRepetida != true && txtcedulaRepetida != true) {
                    registrarColegiado();
                    limpiarCamposJuezCentral();
                    limpiarCamposAsistente1();
                    limpiarCamposAsistente2();
                    limpiarCamposArbitroCentral();
                    camposCuartoArbitro(false);
                    camposJuezCentral(true);
                } else {
                    mensajeCedulaRepetida();
                }
            } else {
                camposIncompletos();
            }
        }

        /// <summary>
        /// Evento click para el botón regresar.
        /// </summary>
        /// <remarks>
        /// Aparece junto al botón Regresar.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnRegresar4_Click (object sender, EventArgs e) {
            camposCuartoArbitro(false);
            camposAsistente2(true);
        }

        /// <summary>
        /// Evento click para el botón cancelar.
        /// </summary>
        /// <remarks>
        /// Limpia todos los campos y vuelve al regitro del primer árbitro.
        /// </remarks>
        /// <param name="sender">Objeto.</param>
        /// <param name="e">Evento.</param>
        private void btnCancelar_Click (object sender, EventArgs e) 
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Está seguro que desea cancelar?\nSi lo hace, los datos ingresados se borrarán.", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) {
                limpiarCamposJuezCentral();
                limpiarCamposAsistente1();
                limpiarCamposAsistente2();
                limpiarCamposArbitroCentral();
                camposAsistente1(false);
                camposAsistente2(false);
                camposCuartoArbitro(false);
                camposJuezCentral(true);
            }
        }

        /// <summary>
        /// Método para registrar el grupo de colegiados.
        /// </summary>
        /// <remarks>
        /// Recoge todos los id de los árbitros y los guarda.
        /// </remarks>
        private void registrarColegiado()
        {
            int idJuezCentral = obtenerIdJuezCentral(),
                idAsistente1 = obtenerIdAsistente1(),
                idAsistente2 = obtenerIdAsistente2(),
                idCuartoArbitro = obtenerIdCuartoArbitro();
            bool vacio = validacionGUI.validarnum(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            if (vacio != true)
            {
                admColegiado.Guardar(idJuezCentral, idAsistente1, idAsistente2, idCuartoArbitro);
            }
            else
            {
                MessageBox.Show("No se pudo agregar colegiados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Muestra mensaje de campos vacios.
        /// </summary>
        private void camposIncompletos ()
        {
            MessageBox.Show("Hay ciertos campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Muestra mensaje si existe algún árbitro registrado.
        /// </summary>
        private void mensajeCedulaRepetida () 
        {
            MessageBox.Show("El árbitro que ingresó ya se encuentra registrado!!\nIngrese uno nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Envia los datos para guardar Juez Central.
        /// </summary>
        /// <remarks>
        /// Usa la clase contexto para asignarle el árbitro.
        /// </remarks>
        /// <returns>Devuelve el id del último Juez Central ingresado como entero.</returns>
        private int obtenerIdJuezCentral()
        {
            int id = 0;
            contexto = new Contexto(AdmJuezCentral.getAdmJ());
            id = contexto.obtenerDatos(txtcedulaJC, txtnombreJC, txtapellidoJC, txtdomicilioJC, txtemailJC, txttelefonoJC);
            return id;
        }

        /// <summary>
        /// Envia los datos para guardar Asistente 1.
        /// </summary>
        /// <remarks>
        /// Usa la clase contexto para asignarle el árbitro.
        /// </remarks>
        /// <returns>Devuelve el id del último Asistente 1 ingresado como entero.</returns>
        private int obtenerIdAsistente1()
        {
            int id = 0;
            contexto = new Contexto(AdmAsistente1.getAdmA1());
            id = contexto.obtenerDatos(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            return id;
        }

        /// <summary>
        /// Envia los datos para guardar Asistente 2.
        /// </summary>
        /// <remarks>
        /// Usa la clase contexto para asignarle el árbitro.
        /// </remarks>
        /// <returns>Devuelve el id del último Asistente 2 ingresado como entero.</returns>
        private int obtenerIdAsistente2()
        {
            int id = 0;
            contexto = new Contexto(AdmAsistente2.getAdmA2());
            id = contexto.obtenerDatos(txtcedulaAs2, txtnombreAs2, txtapellidoAs2, txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            return id;
        }

        /// <summary>
        /// Envia los datos para guardar Cuarto Árbitro.
        /// </summary>
        /// <remarks>
        /// Usa la clase contexto para asignarle el árbitro.
        /// </remarks>
        /// <returns>Devuelve el id del último Cuarto Árbitro ingresado como entero.</returns>
        private int obtenerIdCuartoArbitro()
        {
            int id = 0;
            contexto = new Contexto(AdmCuartoArbitro.getAdmCA());
            id = contexto.obtenerDatos(txtcedulaCA, txtnombreCA, txtapellidoCA, txtdomicilioCA, txtemailCA, txttelefonoCA);
            return id;
        }

        /// <summary>
        /// Método para cambiar la propiedad de "Visible" para Juez Central.
        /// </summary>
        /// <param name="valor">Parámetro con valor booleano.</param>
        private void camposJuezCentral(bool valor)
        {
            labJuezCentral.Visible = valor;
            txtcedulaJC.Visible = valor;
            txtnombreJC.Visible = valor;
            txtapellidoJC.Visible = valor;
            txtdomicilioJC.Visible = valor;
            txtemailJC.Visible = valor;
            txttelefonoJC.Visible = valor;
            btnsiguiente1.Visible = valor;
        }

        /// <summary>
        /// Método para cambiar la propiedad de "Visible" para Asistente 1.
        /// </summary>
        /// <param name="valor">Parámetro con valor booleano.</param>
        private void camposAsistente1(bool valor)
        {
            labAsist1.Visible = valor;
            txtcedulaAs1.Visible = valor;
            txtnombreAs1.Visible = valor;
            txtapellidoAs1.Visible = valor;
            txtdomicilioAs1.Visible = valor;
            txtemailAs1.Visible = valor;
            txttelefonoAs1.Visible = valor;
            btnRegresar2.Visible = valor;
            btnsiguiente2.Visible = valor;
        }

        /// <summary>
        /// Método para cambiar la propiedad de "Visible" para Asistente 2.
        /// </summary>
        /// <param name="valor">Parámetro con valor booleano.</param>
        private void camposAsistente2(bool valor)
        {
            labAsist2.Visible = valor;
            txtcedulaAs2.Visible = valor;
            txtnombreAs2.Visible = valor;
            txtapellidoAs2.Visible = valor;
            txtdomicilioAs2.Visible = valor;
            txtemailAs2.Visible = valor;
            txttelefonoAs2.Visible = valor;
            btnRegresar3.Visible = valor;
            btnsiguiente3.Visible = valor;
        }

        /// <summary>
        /// Método para cambiar la propiedad de "Visible" para Cuarto Árbitro.
        /// </summary>
        /// <param name="valor">Parámetro con valor booleano.</param>
        private void camposCuartoArbitro(bool valor)
        {
            labCuartoArb.Visible = valor;
            txtcedulaCA.Visible = valor;
            txtnombreCA.Visible = valor;
            txtapellidoCA.Visible = valor;
            txtdomicilioCA.Visible = valor;
            txtemailCA.Visible = valor;
            txttelefonoCA.Visible = valor;
            btnRegresar4.Visible = valor;
            btnRegistrar.Visible = valor;
        }

        /// <summary>
        /// Método para limpiar los campos de Juez central.
        /// </summary>
        private void limpiarCamposJuezCentral()
        {
            txtcedulaJC.Text = "";
            txtnombreJC.Text = "";
            txtapellidoJC.Text = "";
            txtdomicilioJC.Text = "";
            txtemailJC.Text = "";
            txttelefonoJC.Text = "";
        }

        /// <summary>
        /// Método para limpiar los campos de Asistente 1.
        /// </summary>
        private void limpiarCamposAsistente1()
        {
            txtcedulaAs1.Text = "";
            txtnombreAs1.Text = "";
            txtapellidoAs1.Text = "";
            txtdomicilioAs1.Text = "";
            txtemailAs1.Text = "";
            txttelefonoAs1.Text = "";
        }

        /// <summary>
        /// Método para limpiar los campos de Asistente 2.
        /// </summary>
        private void limpiarCamposAsistente2()
        {
            txtcedulaAs2.Text = "";
            txtnombreAs2.Text = "";
            txtapellidoAs2.Text = "";
            txtdomicilioAs2.Text = "";
            txtemailAs2.Text = "";
            txttelefonoAs2.Text = "";
        }

        /// <summary>
        /// Método para limpiar los campos de Cuarto Árbitro.
        /// </summary>
        private void limpiarCamposArbitroCentral()
        {
            txtcedulaCA.Text = "";
            txtnombreCA.Text = "";
            txtapellidoCA.Text = "";
            txtdomicilioCA.Text = "";
            txtemailCA.Text = "";
            txttelefonoCA.Text = "";
        }
    }
}