using System;
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
        public void ShouldAddDoubles()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01));

        }

        [Test]
        public void ShouldAddDoubles_withPercentTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(50, 50);

            Assert.That(result, Is.EqualTo(100).Within(1));

        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 6);

            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void ShouldErrorWhenDividedByZero()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(99, 0), Throws.Exception );
        }

        [Test]
        public void ShouldErrorWhenDivideByZero_ExplicitExceptionType()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(99, 0), Throws.TypeOf<DivideByZeroException>());

        }

        [Test]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(200, 0), Throws.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void ShouldErrorWhenNumberTooBig_MoreExplicit()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(200, 0), Throws.TypeOf<ArgumentOutOfRangeException>().With.Matches<ArgumentOutOfRangeException>(x=>x.ParamName == "value"));

        }


    }
}
