using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Ing_Soft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ing_Soft.Tests
{
    [TestClass()]
    public class ConexionTests
    {
        [TestMethod()]
        public void insertarTest()
        {
            Conexion target = new Conexion();
            InterfazAdmin interfazAdmin = new InterfazAdmin();
          //  SqlConnection conexion = null;
            int expected;
            int actual;
          //  actual = target.insertar();
            //Assert.Fail();
        }
    }
}