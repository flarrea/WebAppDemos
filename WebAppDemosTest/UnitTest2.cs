using WebAppDemos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDemos.Controllers;
using System;

namespace WebAppDemosTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetNombreEmpleadoPorNombreTest()
        {
            // Arrange
            HomeController home = new HomeController();

            // Act
            string actual = home.GetNombreEmpleado(1);
            string esperado = "Laura";

            // Assert
            Assert.AreEqual(actual, esperado);
        }

    }
}
