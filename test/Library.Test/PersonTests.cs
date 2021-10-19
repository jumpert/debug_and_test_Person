using NUnit.Framework;
//using System.Program;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person p = new Person("Juan", "4.673.899-0","30-07-1992");
            string expected = "Juan";
            Assert.AreEqual(expected, p.Name);
        }
        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            // El digito verificador esta mal es 0
            Person p = new Person("Juan", "4.673.899-1","30-07-1992");
            string expected = null;
            Assert.AreEqual(expected, p.ID);
        }
        [Test]
        public void TestFecha() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person p = new Person("Juan", "4.673.899-0", "30-07-1992");
            string expected = "30-07-1992";
            Assert.AreEqual(expected, p.FechaNacimiento);
        }
    }
}