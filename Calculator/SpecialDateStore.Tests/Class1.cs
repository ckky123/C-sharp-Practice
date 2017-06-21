using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDateStore.Tests
{
    [TestFixture]
    public class SpecialDateStoreTest
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SpecialDate();

            var result = sut.DateOf(SpecialDates.NewMillennium);

            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)));
        }
        [Test]
        public void ShouldHaveCorrectMillenioumDate_()
        {
            var sut = new SpecialDate();

            var result = sut.DateOf(SpecialDates.NewMillennium);

            //Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)));

            Assert.That(result,Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)).Within( TimeSpan.FromMilliseconds(1)));
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)).Within(1).Milliseconds);

        }

    }
}
