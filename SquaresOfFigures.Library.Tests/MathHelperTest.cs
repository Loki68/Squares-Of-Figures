using NUnit.Framework;
using SquaresOfFigures.Library.Helpers;

namespace SquaresOfFigures.Library.Tests
{
    [TestFixture]
    class MathHelperTest
    {
        [TestCase(1,1)]
        [TestCase(2,4)]
        [TestCase(3,9)]
        [TestCase(4,16)]
        public static void SqrTest(
            double first, 
            double expectedResult)
        {
            var sqrResult = MathHelper.GetSqr(first);
            Assert.AreEqual(expectedResult,sqrResult);
        }

        [TestCase(32.7885643, 2, 32.79)]
        [TestCase(-32.7885643, 2, -32.79)]
        [TestCase(12.7885643, 3, 12.789)]
        [TestCase(12.345678, 5, 12.34568)]
        public static void RoundingTest(
            double first, 
            int second, 
            double expectedResult)
        {
            var roundedNumber = MathHelper.GetRoundedValue(first, second);
            Assert.AreEqual(expectedResult,roundedNumber);
        }

        [TestCase(1, 2, 3, 6)]
        [TestCase(4, 3, 4, 11)]
        [TestCase(1, 2, 4, 7)]
        [TestCase(37, 33, 50, 120)]
        public static void TrianglePerimeterTest(
            double first, 
            double second, 
            double third, 
            double expectedResult)
        {
            var trianglePerimeter = MathHelper.GetTrianglePerimeter(first, second, third);
            Assert.AreEqual(expectedResult, trianglePerimeter);
        }

        [TestCase(6, 3, 4, 5, 6)]
        [TestCase(21, 13, 14, 15, 84)]
        public static void HeronsFormulaTest(
            double first, 
            double second, 
            double third, 
            double fourth, 
            double expectedResult)
        {
            var triangleSquare = MathHelper.HeronsFormula(first, second, third, fourth);
            Assert.AreEqual(expectedResult, triangleSquare);
        }


        [TestCase(1, 2, 1)]
        [TestCase(1, -2, -2)]
        [TestCase(3, 2, 2)]
        [TestCase(-4, -2, -4)]
        public static void GetMinTest(
            double first,
            double second,
            double expectedResult)
        {
            var minNumber = MathHelper.GetMin(first, second);
            Assert.AreEqual(expectedResult, minNumber);
        }

        [TestCase(1, 2, 2)]
        [TestCase(3, 4, 12)]
        [TestCase(3, 2, 6)]
        [TestCase(4, 2, 8)]
        public static void RectangleSquareTest(
            double first, 
            double second, 
            double expectedResult)
        {
            var minNumber = MathHelper.GetRectangleSquare(first, second);
            Assert.AreEqual(expectedResult, minNumber);
        }
    }
}
