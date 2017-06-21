using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameJoiner.Tests
{
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("Wendy", "Lee");

            Assert.That(fullName,Is.EqualTo("Wendy Lee"));
        }
        [Test]
        public void ShouldJoinNames_CaseInsensitiveAssertDemo()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("wendy", "lee");

            Assert.That(fullName, Is.EqualTo("WENDY Lee").IgnoreCase);
        }
        [Test]
        public void ShouldJoinNames_NotEqualDemo()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("wendy", "lee");

            Assert.That(fullName, Is.Not.EqualTo("EENDY Lee").IgnoreCase);
        }

    }
}
