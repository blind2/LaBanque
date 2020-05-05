using NUnit.Framework;

namespace BanqueLibrairieTests
{
    public class BanqueTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DeposerTest()
        {
            //Arrange
            long expected = 500;
            long montantDeposer = 100;
            
            var banque = new BanqueLibrairie.Banque("test", "815");

            //Acte
            long solde =banque.Deposer(montantDeposer);

            //assert
            Assert.AreEqual(expected,solde);
           
        }
       
    }
}