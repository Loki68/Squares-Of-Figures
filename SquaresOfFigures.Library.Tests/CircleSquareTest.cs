using NUnit.Framework;
using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Strategy;

namespace SquaresOfFigures.Library.Tests
{
    [TestFixture]
    class CircleSquareTest
    {
        [TestCase(1, Circle.PI)]
        [TestCase(2, 12.56)]
        [TestCase(-10, 0)]
        [TestCase(-1.5, 0)]
        public static void SquareTest(double first, double expectedResult)
        {
            var circleSquare = new CircleSquare();
            Assert.AreEqual(expectedResult, circleSquare.GetSquare(
                new Circle(
                    first, 
                    circleSquare)));
        }
    }
}
