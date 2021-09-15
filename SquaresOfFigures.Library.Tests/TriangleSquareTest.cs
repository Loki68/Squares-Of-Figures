using NUnit.Framework;
using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Strategy;

namespace SquaresOfFigures.Library.Tests
{
    [TestFixture]
    class TriangleSquareTest
    {
        [TestCase(13,14,15,84)]
        [TestCase(6, 5, 2.2, 5.28)]
        [TestCase(5, 5, 8, 12)]
        [TestCase(1, 2, 3, 0)]
        [TestCase(5, -5, 8, 0)]
        [TestCase(5, -5, -8, 0)]
        public static void SquareTest(
            double first, 
            double second, 
            double third, 
            double expectedResult)
        {
            var triangleSquare = new TriangleSquare();
            Assert.AreEqual(expectedResult, triangleSquare.GetSquare(
                new Triangle(
                    first, 
                    second, 
                    third, 
                    triangleSquare)));
        }
    }
}
