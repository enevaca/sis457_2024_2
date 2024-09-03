using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables --> Arrage
            int numero1 = 5;
            int numero2 = 7;

            // Ejecutamos la prueba --> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos resultados --> Assert
            int resultadoEsperado = 12;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.restar(numero1, numero2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.multiplicar(numero1, numero2);
            Assert.AreEqual(60, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            int numero1 = 10, numero2 = 5;
            int resultado = Calculadora.dividir(numero1, numero2);
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void TestDivisionPorCero()
        {
            int numero1 = 10, numero2 = 0;
            Assert.ThrowsException<DivideByZeroException>(() => Calculadora.dividir(numero1, numero2));
        }

        [TestMethod]
        public void TestModulo()
        {
            int numero1 = 10, numero2 = 5;
            int resultado = Calculadora.modulo(numero1, numero2);
            Assert.AreEqual(0, resultado);
        }
    }
}