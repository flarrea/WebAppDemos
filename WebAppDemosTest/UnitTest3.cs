using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppDemos.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using WebAppDemos.Data.Interfaces;

namespace WebAppDemosTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void EcuentraEmpleadoPorIdTest()
        {
            // Arrange
            var mock = new Mock<IGetDataRepository>();
            mock.Setup(p => p.GetNameById(1)).Returns("Laura");
            EmpleadoController empleado = new EmpleadoController(mock.Object);

            // Act
            string actual = empleado.GetNameById(1);
            string esperado = "Laura";

            // Assert
            Assert.AreEqual(actual, esperado);
        }

    }
}
