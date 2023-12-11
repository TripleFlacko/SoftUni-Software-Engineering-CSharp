using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(1, 5);
            dummy = new Dummy(1, 10);
        }

        [Test]
        public void When_DummyIsAttacked_Should_LooseHealth()
        {
            axe.Attack(dummy);
            Assert.AreEqual(0, dummy.Health);
        }
        [Test]
        public void When_DeadDummyIsAttacked_Should_ThrowException()
        {
            axe.Attack(dummy);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
        [Test]
        public void When_DummyIsDead_Should_GiveExperience()
        {
            axe.Attack(dummy);
            Assert.AreEqual(10, dummy.GiveExperience());
        }
        [Test]
        public void When_DummyIsAlive_Should_Not_GiveExperience()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}