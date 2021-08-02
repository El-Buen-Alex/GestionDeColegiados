using System;
using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestFederacion
    {
        [TestMethod]
        public void LoginPrueba()
        {
            var name = "preidente";
            var password = "1234presi5";
            var resultadoEsperado = "";

            GestionLogin controlLogin = new GestionLogin();

            var result = controlLogin.controlLogin(name, password);

            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
