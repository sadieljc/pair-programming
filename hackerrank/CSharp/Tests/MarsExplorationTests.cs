using NUnit.Framework;
using System;
using System.Collections.Generic;
using Core;

namespace Tests
{
    [TestFixture]
    class MarsExplorationTests
    {
        private readonly MarsExploration _marsExploration = new MarsExploration();

        [Test]
        public void test1()
        {
            // Arrange
            var message = "SOSSPSSQSSOR";

            // Act
            var result = _marsExploration.Evaluate(message);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void test2()
        {
            // Arrange
            var message = "SOSSOT";

            // Act
            var result = _marsExploration.Evaluate(message);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void test3()
        {
            // Arrange
            var message = "SOSSOSSOS";

            // Act
            var result = _marsExploration.Evaluate(message);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
