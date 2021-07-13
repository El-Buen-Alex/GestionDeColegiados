using Control.AdmEncuentrosGenerados;
using GestionDeColegiados;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestFederacion
{
    [TestClass]
    public class GenerarEncuentroTests
    {
        [TestMethod]
        public void pruebaCP010()
        {
            var resultadoNoEsperado = -1;
            var generarEncuentro = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();
            var resultadoCodigo = generarEncuentro.obtnerNumeroEncuentrosGeneradosPendientes();
            Assert.AreNotEqual(resultadoNoEsperado, resultadoCodigo);
        }
        [TestMethod]
        public void pruebaCP007()
        {
            var formPrueba = new frmGenerarEncuentros(false);
            var resultadoEsperado = true;//se generaronEncuentros
            var generarEncuentro = AdmGenerarEncuentros.getAdmadmGenerarEncuentros();//probando si genera
            var resultadoObtenido = generarEncuentro.generarEncuentrosAleatorios(formPrueba.ListaContenedoresLocal, formPrueba.ListaContenedoresVisitante);
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);//comparando resultados
        }

    }
}
