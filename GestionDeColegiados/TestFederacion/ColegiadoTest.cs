using Control.AdmColegiados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace TestFederacion {
    /// <summary>
    /// Clase para realizar pruebas unitarias de colegiado.
    /// </summary>
    [TestClass]
    public class ColegiadoTest {

        /// <summary>
        /// Prueba <c>pruebaCP002</c> para el guardado de Asistente 1.
        /// </summary>
        [TestMethod]
        public void pruebaCP002 () {
            var admAsistente1 = AdmAsistente1.getAdmA1();
            TextBox txtcedulaAs1 = new TextBox();
            TextBox txtnombreAs1 = new TextBox();
            TextBox txtapellidoAs1 = new TextBox();
            TextBox txtdomicilioAs1 = new TextBox();
            TextBox txtemailAs1 = new TextBox();
            TextBox txttelefonoAs1 = new TextBox();
            TextBox txtbandaAs1 = new TextBox();
            txtcedulaAs1.Text = "0923465765";
            txtnombreAs1.Text = "Luis";
            txtapellidoAs1.Text = "Álvarez";
            txtdomicilioAs1.Text = "Guayaquil";
            txtemailAs1.Text = "luis@hotmail.com";
            txttelefonoAs1.Text = "0923452354";
            txtbandaAs1.Text = "Derecha";
            var resultadoNoEsperado = 0;
            var resultadoCodigo = admAsistente1.guardar(txtcedulaAs1, txtnombreAs1, txtapellidoAs1, 
                txtdomicilioAs1, txtemailAs1, txttelefonoAs1);
            Assert.AreNotEqual(resultadoNoEsperado, resultadoCodigo);
        }

        /// <summary>
        /// Prueba <c>pruebaCP003</c> para el guardado de Asistente 2.
        /// </summary>
        [TestMethod]
        public void pruebaCP003 () {
            var admAsistente2 = AdmAsistente2.getAdmA2();
            TextBox txtcedulaAs2 = new TextBox();
            TextBox txtnombreAs2 = new TextBox();
            TextBox txtapellidoAs2 = new TextBox();
            TextBox txtdomicilioAs2 = new TextBox();
            TextBox txtemailAs2 = new TextBox();
            TextBox txttelefonoAs2 = new TextBox();
            TextBox txtbandaAs2 = new TextBox();
            txtcedulaAs2.Text = "0945667657";
            txtnombreAs2.Text = "Juan";
            txtapellidoAs2.Text = "Soto";
            txtdomicilioAs2.Text = "Guayaquil";
            txtemailAs2.Text = "juan@hotmail.com";
            txttelefonoAs2.Text = "0912435634";
            txtbandaAs2.Text = "Izquierda";
            var resultadoNoEsperado = 0;
            var resultadoCodigo = admAsistente2.guardar(txtcedulaAs2, txtnombreAs2, txtapellidoAs2,
                txtdomicilioAs2, txtemailAs2, txttelefonoAs2);
            Assert.AreNotEqual(resultadoNoEsperado, resultadoCodigo);
        }

        /// <summary>
        /// Prueba <c>pruebaCP004</c> para el guardado de Cuarto Arbitro.
        /// </summary>
        [TestMethod]
        public void pruebaCP004 () {
            var admCuartoArbitro = AdmCuartoArbitro.getAdmCA();
            TextBox txtcedulaCA = new TextBox();
            TextBox txtnombreCA = new TextBox();
            TextBox txtapellidoCA = new TextBox();
            TextBox txtdomicilioCA = new TextBox();
            TextBox txtemailCA = new TextBox();
            TextBox txttelefonoCA = new TextBox();
            txtcedulaCA.Text = "0987654356";
            txtnombreCA.Text = "José";
            txtapellidoCA.Text = "Jaramillo";
            txtdomicilioCA.Text = "Guayaquil";
            txtemailCA.Text = "jose@hotmail.com";
            txttelefonoCA.Text = "0987654546";
            var resultadoNoEsperado = 0;
            var resultadoCodigo = admCuartoArbitro.guardar(txtcedulaCA, txtnombreCA, txtapellidoCA,
                txtdomicilioCA, txtemailCA, txttelefonoCA);
            Assert.AreNotEqual(resultadoNoEsperado, resultadoCodigo);
        }

        /// <summary>
        /// Prueba <c>pruebaCP005</c> para el guardado de Juez Central.
        /// </summary>
        [TestMethod]
        public void pruebaCP005 () {
            var admJuezCentral = AdmJuezCentral.getAdmJ();
            TextBox txtcedulaJC = new TextBox();
            TextBox txtnombreJC = new TextBox();
            TextBox txtapellidoJC = new TextBox();
            TextBox txtdomicilioJC = new TextBox();
            TextBox txtemailJC = new TextBox();
            TextBox txttelefonoJC = new TextBox();
            txtcedulaJC.Text = "0923456789";
            txtnombreJC.Text = "Eduardo";
            txtapellidoJC.Text = "Cruz";
            txtdomicilioJC.Text = "Guayaquil";
            txtemailJC.Text = "eduardo@hotmail.com";
            txttelefonoJC.Text = "0923422354";
            var resultadoNoEsperado = 0;
            var resultadoCodigo = admJuezCentral.guardar(txtcedulaJC, txtnombreJC, txtapellidoJC,
                txtdomicilioJC, txtemailJC, txttelefonoJC);
            Assert.AreNotEqual(resultadoNoEsperado, resultadoCodigo);
        }
    }
}