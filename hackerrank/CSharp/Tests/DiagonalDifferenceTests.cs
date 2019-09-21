using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DiagonalDifference;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
    [TestFixture]
    public class DiagonalDifferenceTests
    {
        [Test]
        public void Test()
        {
            //Arrange
            var matrixOrder = 3;
            var matrix = new List<List<int>>
            {
                new List<int> {11, 2, 4},
                new List<int> {4, 5, 6},
                new List<int> {10, 8, -12}
            };

            //Act
            var sut = new DiagonalDifference();
            var result = sut.diagonalDifference(matrix);

            //Assert
            Assert.That(result, Is.EqualTo(15));

        }

        [Test]
        public void Test2()
        {
            //arrange
            var matrixOrder = 4;

            var matrix = new List<List<int>>
            {
                new List<int> {-1, 1, -7, -8},
                new List<int> {-10, -8, -5, -2},
                new List<int> {0, 9, 7, -1},
                new List<int> { 4, 4, -2, 1}
            };

            //act
            var sut = new DiagonalDifference();
            var result = sut.diagonalDifference(matrix);


            //assert
            Assert.That(result, Is.EqualTo(1));

        }
    }
}
