﻿using System;
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
            var name = "presidente";
            var password = "1234prxesi5";
            var resultadoEsperado = "";

            GestionLogin controlLogin = new GestionLogin();

            var result = controlLogin.controlLogin(name, password);

            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
