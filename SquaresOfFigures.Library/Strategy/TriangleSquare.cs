using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Helpers;
using System;

namespace SquaresOfFigures.Library.Strategy
{
    /// <summary>
    /// Реализация "стратегии" для вычисления площади произвольного треугольника
    /// </summary>
    public class TriangleSquare : ISquare
    {
        /// <summary>
        /// Метод вычисления площади треугольника с проверкой на треугольность получаемой параметром фигуры
        /// </summary>
        /// <param name="shape">Собственно фигура</param>
        /// <returns>Площадь треугольника или нуль, если фигура не является треугольником.</returns>
        public double GetSquare(Shape shape)
        {
            var triangle = shape as Triangle;

            double minNumber = MathHelper.GetMin(triangle.FirstSide, triangle.SecondSide);
            minNumber = MathHelper.GetMin(minNumber, triangle.ThirdSide);

            bool sidesAreNegative = IsNegativeNumber(minNumber);

            
            //Проверка данных на корректность
            //Длины сторон, и длины вообще, должны быть неотрицательными
            if (sidesAreNegative)
            {
                Console.WriteLine("Длины сторон не могут быть отрицательными!");
                return 0;
            }

            //Переменная- "индикатор треугольности" фигуры
            var triangularity = triangle.FirstSide + triangle.SecondSide - triangle.ThirdSide;
            
            //Проверка треугольности фигуры с помощью "индикатора треугольности"
            if (triangularity > 0) 
            {
                double halfPerimeter = MathHelper.GetTrianglePerimeter(triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide) / 2;
                double square = MathHelper.HeronsFormula(halfPerimeter, triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide);

                return MathHelper.GetRoundedValue(square, 2);
            }
            else
            {
                Console.WriteLine("Фигура не является треугольником!");
                return 0;
            }
            
        }

        /// <summary>
        /// Метод проверки позитивности наименьшей по величине стороны треугольника
        /// </summary>
        /// <param name="number">Минимальная по величине сторона</param>
        /// <returns>true, если наименьшая из сторон положительна и false если наименьшая из сторон отрицательна</returns>
        private bool IsNegativeNumber(double number)
        {
            if (number < 0) return true;
            return false;
        }
    }
}
