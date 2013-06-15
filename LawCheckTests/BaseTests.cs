using System;
using NUnit.Framework;
using LawCheck;

namespace LawCheckTests
{
    [TestFixture]
    public class BaseTests
    {
        [Test]
        public void TestCorporationCantCastToPerson()
        {
            var corporation = new Corporation();
            Assert.That(() => (Corporation)(corporation as IEntity), Throws.Nothing);
            Assert.That(() => (Person)(corporation as IEntity), Throws.Exception.TypeOf<InvalidCastException>());
        }

        [Test]
        public void TestCorporationCantVote()
        {
            var corporation = new Corporation();
            Assert.That(corporation.Rights.Keys, !Contains.Item("Vote"));
        }
    }
}
