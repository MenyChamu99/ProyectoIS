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
           const int calificacion1 = 80;
           const int calificacion2 = 80;
           const int calificacion3 = 80;
           const int calificacion4 = 80;
           const int calificacion5 = 80;
           const int sum = 5;
           const int resesperado = 80;

           var actual = InterfazJefeDpto.promedio(calificacion1, calificacion2, calificacion3, calificacion4, calificacion5, sum);

           Assert.AreEqual(resesperado, actual);




            //var calificacion = new InterfazJefeDpto();
            ////var aprobado = false;
            // int calif1 = 80;
            // int calif2 = 80;
            // int calif3 = 80;
            // int calif4 = 80;
            // int calif5 = 80;
            // int total = 80;
            //const int resesperado = 80;
            //var resultado = calificacion.promedio(calif1,calif2,calif3,calif4,calif5,total);
            //Assert.AreEqual(resesperado, resultado);
        }
    }
}
