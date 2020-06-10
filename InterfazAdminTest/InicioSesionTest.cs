using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Ing_Soft;

namespace PruebaUnitariaInicio
{
    [TestClass]
    public class InicioSesionTest
    {
        [TestMethod]
        public void Validar()
        {
            var usuario =new InicioSesion();
            var usuariocontraseña = false;

            var resultado = usuario.CamposLlenos(usuariocontraseña);

            Assert.IsFalse(resultado);
        }
    }
}
