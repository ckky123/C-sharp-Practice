using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculaterTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
            

        }
        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 6);

            Assert.That(result, Is.EqualTo(12));


        }
    }
}
