using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class SherlockAndArrayTests
    {
        private SherlockAndArray sut = new SherlockAndArray();

        [Test]
        public void Test1()
        {
            // arrange
            var arr = new List<int> { 1, 2, 3 };

            // act
            var result = sut.BalancedSum(arr);

            // assert
            Assert.That("NO", Is.EqualTo(result));
        }

        [Test]
        public void Test2()
        {
            // arrange
            var arr = new List<int> { 1, 2, 3, 3 };

            // act
            var result = sut.BalancedSum(arr);

            // assert
            Assert.That("YES", Is.EqualTo(result));
        }
    }
}
