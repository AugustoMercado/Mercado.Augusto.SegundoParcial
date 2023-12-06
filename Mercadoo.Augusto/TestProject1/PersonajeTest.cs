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

        public void VerificarSiElEjercitoEstaLleno_true()
        {
            // Arrange
            Ejercito ejercito1 = new Ejercito(2, "Iran");
            Guerrero guerrero1 = new Guerrero(10, 10, 50, "Guerrero1");
            Guerrero guerrero2 = new Guerrero(40, 20, 10, "Guerrero2");
            Guerrero guerrero3 = new Guerrero(40, 20, 10, "Guerrero3");

            // Act
            ejercito1 += guerrero1;
            ejercito1 += guerrero2;
            ejercito1 += guerrero3;

            // Assert
            Assert.AreEqual(ejercito1.Miembros.Count, 2);

        }
        [TestMethod]
        public void VerificarSiElEjercitoEstaLleno_false()
        {
            // Arrange
            Ejercito ejercito1 = new Ejercito(3, "Iran");
            Guerrero guerrero1 = new Guerrero(10, 10, 50, "Guerrero1");
            Guerrero guerrero2 = new Guerrero(40, 20, 10, "Guerrero2");
            Guerrero guerrero3 = new Guerrero(40, 20, 10, "Guerrero3");

            // Act
            ejercito1 += guerrero1;
            ejercito1 += guerrero2;
            ejercito1 += guerrero3;

            // Assert
            Assert.AreEqual(ejercito1.Miembros.Count, 3);

        }

        [TestMethod]
        public void VerificarSiYaEsta_True()
        {
            // Arrange
            Ejercito ejercito = new Ejercito(2, "Iran");
            Guerrero guerrero1 = new Guerrero(10, 10, 50, "Guerrero1");

            // Act
            ejercito += guerrero1;
            ejercito += guerrero1; // Intentar agregar el mismo personaje nuevamente

            // Assert
            Assert.AreEqual(ejercito.Miembros.Count, 2);
        }

        [TestMethod]
        public void VerificarSiYaEsta_False()
        {
            // Arrange
            Ejercito ejercito = new Ejercito(2, "Iran");
            Guerrero guerrero1 = new Guerrero(10, 10, 50, "Guerrero1");
            Guerrero guerrero3 = new Guerrero(40, 20, 10, "Guerrero2");
            // Act
            ejercito += guerrero1;
            ejercito += guerrero3; // Intentar agregar el mismo personaje nuevamente

            // Assert
            Assert.AreEqual(ejercito.Miembros.Count, 2);
        }


    }
}