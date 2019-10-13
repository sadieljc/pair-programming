using Core;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ClosestNumbersTest
    {
        private ClosestNumbers sut = new ClosestNumbers();

        [Test]
        public void Test1()
        {
            // arrange
            var numbers = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };

            // act 
            Array.Sort<int>(numbers);
            var results = sut.Evaluate(numbers);

            // assert
            Assert.That(new int[] {-20, 30}, Is.EquivalentTo(results));
        }

        [Test]
        public void Test2()
        {
            // arrange
            var numbers = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };

            // act 
            Array.Sort<int>(numbers);
            var results = sut.Evaluate(numbers);

            // assert
            Assert.That(new int[] { -520, -470, -20, 30 }, Is.EquivalentTo(results));
        }

        [Test]
        public void Test3()
        {
            // arrange
            var numbers = new int[] { 5, 4, 3, 2 };

            // act 
            Array.Sort<int>(numbers);
            var results = sut.Evaluate(numbers);

            // assert
            Assert.That(new int[] { 2, 3, 3, 4, 4, 5 }, Is.EquivalentTo(results));
        }
    }
}
