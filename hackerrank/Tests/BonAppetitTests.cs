using System.Collections.Generic;
using Core;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BonAppetitTests
    {
        private readonly BonAppetit _bonAppetit = new BonAppetit();

        [Test]
        public void ReturnAmountToRefund_When_NotEvenlySplitted()
        {
            //Arrange
            var bill = new List<int> {3, 10, 2, 9};
            var anaDidntLike = 1;
            var amountCharged = 12;

            //Act
            var result = _bonAppetit.Evaluate(bill, anaDidntLike, amountCharged);

            //Assert
            Assert.That(result, Is.EqualTo("5"));
        }

        [Test]
        public void ReturnBonAppetit_When_EvenlySplitted()
        {
            //Arrange
            var bill = new List<int> { 3, 10, 2, 9 };
            var anaDidntLike = 1;
            var amountCharged = 7;

            //Act
            var result = _bonAppetit.Evaluate(bill, anaDidntLike, amountCharged);

            //Assert
            Assert.That(result, Is.EqualTo("Bon Appetit"));
        }
    }
}
