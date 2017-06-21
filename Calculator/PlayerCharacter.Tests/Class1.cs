using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace PlayerCharacter.Tests
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new Player { Health = 100 };
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
            Assert.That(sut.Health, Is.InRange(101,200));
        }
        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new Player() ;
            
            Assert.That(sut.Name, Is.Not.Empty);

        }
        [Test]
        public void ShouldNotHaveANickName()
        {
            var sut = new Player();

            Assert.That(sut.NickName, Is.Null);

        }
        [Test]
        public void ShouldBeNewbie()
        {
            var sut = new Player();

            Assert.That(sut.IsNoob, Is.False);
        }

        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut= new Player();

            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveALongBow()
        {
            var sut = new Player();

            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }
        [Test]
        public void ShouldHaveAtLEastOneKindOfSword()
        {
            var sut = new Player();
            Assert.That(sut.Weapons, Has.Some.ContainsSubstring("Sword"));
        }

        [Test]
        public void ShouldHaveTwoBows()
        {
            var sut = new Player();
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }

        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
        {
            var sut = new Player();
            Assert.That(sut.Weapons, Is.Unique );
        }

        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new Player();

            Assert.That(sut.Weapons, Has.None.EqualTo("Staff Of Wonder"));
        }
        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new Player();
            var expectedWeapons = new[]
            {
                "Short Sword",
                "Long Bow",
                "Short Bow"
            };

            Assert.That(sut.Weapons, Is.EquivalentTo(expectedWeapons ));
        }
        [Test]
        public void ShouldHaveDefaultsWeaponsInAlphabeticalOrder()
        {
            var sut = new Player();

            Assert.That(sut.Weapons, Is.Ordered);
        }

        [Test]
        public void ReferenceEqulitydemo()
        {
            var player1 = new Player();
            var player2 = new Player();

            //Assert.That(player1, Is.SameAs(player2));
            var somePlayer = player1;
            Assert.That(somePlayer, Is.SameAs(player1));
            Assert.That(player1, Is.Not.SameAs(player2));
        }
    
    }
}
