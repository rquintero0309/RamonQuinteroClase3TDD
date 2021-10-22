using NUnit.Framework;

using RamonQuinteroClase3TDD;

namespace RamonQuinteroClase3TDD.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void sumar()
        {
            Class1 c = new Class1();

            Assert.AreEqual(5, c.sumar(3, 2));
        }

        [Test]
        public void restar()
        {
            Class1 c = new Class1();

            Assert.AreEqual(1, c.restar(3, 2));
        }

        [Test]
        public void orden_primero_mayor()
        {
            Class1 c = new Class1();

            Assert.AreEqual("primero es mayor", c.mayorPrimero(3, 2));
        }

        [Test]
        public void orden_segundo_mayor()
        {
            Class1 c = new Class1();

            Assert.AreEqual("segundo es mayor", c.mayorSegundo(2, 3));
        }
    }
}