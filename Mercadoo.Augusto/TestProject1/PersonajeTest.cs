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
        [TestMethod]
        public void VerificarArquerosIguales_true()
        {
            // Arrange
            Arquero a1 = new Arquero(14, 10, 15, "Arquero1");
            Arquero a2 = new Arquero(14, 10, 15, "Arquero1");

            // Act
            bool resultado = a1.Equals(a2);

            // Assert
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void VerificarArquerosIguales_false()
        {
            // Arrange
            Arquero a1 = new Arquero(14, 10, 15, "Arquero1");
            Arquero a2 = new Arquero(14, 10, 15, "Arquero2");

            // Act
            bool resultado = a1.Equals(a2);

            // Assert
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void VerificarMagoIguales_true()
        {
            // Arrange
            Mago m1 = new Mago(Emagia.Hielo, 45, 20, "Mago1");
            Mago m2 = new Mago(Emagia.Hielo, 45, 20, "Mago1");

            // Act
            bool resultado = m1.Equals(m2);

            // Assert
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void VerificarMagoIguales_false()
        {
            // Arrange
            Mago m1 = new Mago(Emagia.Hielo, 45, 20, "Mago1");
            Mago m2 = new Mago(Emagia.Fuego, 45, 20, "Mago2");

            // Act
            bool resultado = m1.Equals(m2);

            // Assert
            Assert.IsFalse(resultado);

        }

    }
}