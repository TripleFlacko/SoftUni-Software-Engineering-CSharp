using Microsoft.VisualBasic;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(10, 1);
            dummy = new Dummy(11, 10);
        }
        [Test]
        public void When_WeaponAttacks_It_Should_LoseDurability()
        {
            axe.Attack(dummy);
            Assert.AreEqual(0, axe.DurabilityPoints);
        }
        [Test]
        public void When_AttackWithBrokenWeapon_Should_ThrowException()
        {
            axe.Attack(dummy);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}