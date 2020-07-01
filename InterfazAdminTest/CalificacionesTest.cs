using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Ing_Soft;

namespace PruebaUnitariaInicio
{
    [TestClass]
    public class CalificacionesTest
    {
        [TestMethod]
        public void SumaCalificaciones()
        {
            const int calificacion1 = 80;
            const int calificacion2 = 80;
            const int calificacion3 = 80;
            const int calificacion4 = 80;
            const int calificacion5 = 80;

            const int resesperado = 400;

          var actual = InterfazJefeDpto.SumaCalif(calificacion1, calificacion2, calificacion3, calificacion4, calificacion5);

            Assert.AreEqual(resesperado, actual);
        }
    }
}
