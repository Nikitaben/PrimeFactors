using NUnit.Framework;
using PrimeFactors;
namespace ProgramPrimeFactorsUT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Prime_factors_of_4()
        {
            string actualResult = Program.primeFactors(4);
            string er = "2 x 2";
            Assert.AreEqual(er, actualResult);
        }
        [Test]
        public void Prime_factors_of_7()
        {
            string actualResult = Program.primeFactors(7);
            string er = "7";
            Assert.AreEqual(er, actualResult);
        }
        [Test]
        public void Prime_factors_of_30()
        {
            string actualResult = Program.primeFactors(30);
            string er = "2 x 3 x 5";
            Assert.AreEqual(er, actualResult);
        }
        [Test]
        public void Prime_factors_of_40()
        {
            string actualResult = Program.primeFactors(40);
            string er = "2 x 2 x 2 x 5";
            Assert.AreEqual(er, actualResult);
        }
        [Test]
        public void Prime_factors_of_50()
        {
            string actualResult = Program.primeFactors(50);
            string er = "2 x 5 x 5";
            Assert.AreEqual(er, actualResult);
        }
    }
}