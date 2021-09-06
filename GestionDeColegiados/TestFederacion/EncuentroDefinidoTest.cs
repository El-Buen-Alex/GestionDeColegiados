using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeColegiados;
using Control.AdmEncuentrosGenerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace TestFederacion
{
    [TestClass]
    public class EncuentroDefinidoTest
    {
        [TestMethod]
        public void pruebaCP008()
        {
            var admEcuentroDefinido = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
            var resultadoEsperado = true;
            var resultadoObtenido = admEcuentroDefinido.GuardarEncuentroDefinido(1, Convert.ToDateTime("16/07/2021"), Convert.ToDateTime("20:00"), 1,0);
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
        [TestMethod]
        public void pruebaCP009()
        {
            var idxEstadio = 1;//como parametro la posicion del estadio disponible
            var admEcuentroDefinido = AdmEncuentrosDefinidos.GetAdmGenerarEncuentrosDefinidos();
            var auxiliar = admEcuentroDefinido.ListaEncuentrosDefinidos[1]; ;//como parametro la posicion del encuentro a cambiar 
            var resultadoEsperado = true;
            var frmCambiarEstadioPartido = new frmCambiarEstadioPartido();
            admEcuentroDefinido.LlenarPartidosCmb(frmCambiarEstadioPartido.CmbEncuentros);
            var resultadoObtenido = admEcuentroDefinido.ActualizarEstadio(auxiliar, idxEstadio);
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

    }
}
