using WebAppDemos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDemos.Controllers;
using System;

namespace WebAppDemosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EcuentraEmpleadoPorIdTest()
        {
            // Arrange
            HomeController home = new HomeController();

            // Act
            string actual = home.GetNombreEmpleado(1);
            string esperado = "Laura";

            // Assert
            Assert.AreEqual(actual, esperado);
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            HomeController home = new HomeController();

            // Act
            var actual = home.Add(2, 5);
            var esperado = 5 + 2;

            // Assert
            Assert.AreEqual(actual, esperado);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void AddTest2(int value)
        {
            // Arrange
            HomeController home = new HomeController();

            // Act
            Console.WriteLine("Testing {0} + {0}", value);
            var actual = home.Add(value, value);
            var esperado = value + value;

            // Assert
            Assert.AreEqual(actual, esperado);
        }

        [DataTestMethod]
        [DataRow(1, "Laura")]
        [DataRow(2, "Miguel")]
        [DataRow(3, "No Encontrado")]

        public void EcuentraEmpleadoPorIdTest2(int emplId, string nombre)
        {
            // Arrange
            HomeController home = new HomeController();

            // Act
            string actual = home.GetNombreEmpleado(emplId);
            string esperado = nombre;

            // Assert
            Assert.AreEqual(actual, esperado);
        }
    }
}
