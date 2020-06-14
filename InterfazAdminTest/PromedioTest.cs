using System;
using InterfazDocente;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Ing_Soft;

namespace PruebaUnitariaInicio
{
    [TestClass]
    public class PromedioTest
    {
        [TestMethod]
        public void promapro()
        {
            var calificacion = new Calif();
            var aprobado = false;

            var resultado = calificacion.Promedio(aprobado);

            Assert.IsFalse(resultado);
        }
    }
}
