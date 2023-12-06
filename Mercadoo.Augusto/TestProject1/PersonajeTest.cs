using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial;

namespace TestProject1
{
    [TestClass]
    public class PersonajeTest
    {
        [TestMethod]
        public void VerificarGuerrerosIguales_true()
        {
            // Arrange
            Guerrero g1 = new Guerrero(10, 10, 50, "Guerrero1");
            Guerrero g2 = new Guerrero(40, 20, 10, "Guerrero1");

            // Act
            bool resultado = g1.Equals(g2);

            // Assert
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void VerificarGuerrerosIguales_false()
        {
            // Arrange
            Guerrero g1 = new Guerrero(10, 10, 50, "Guerrero1");
            Guerrero g2 = new Guerrero(40, 20, 10, "Guerrero2");

            // Act
            bool resultado = g1.Equals(g2);

            // Assert
            Assert.IsFalse(resultado);

        }
    }
}