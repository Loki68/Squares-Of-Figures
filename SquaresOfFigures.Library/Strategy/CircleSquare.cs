using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Helpers;
using System;

namespace SquaresOfFigures.Library.Strategy
{
    /// <summary>
    /// Реализация "стратегии" для вычисления площади круга
    /// </summary>
    public class CircleSquare : ISquare
    {
        /// <summary>
        /// Реализация метода из "стратегии
        /// </summary>
        /// <param name="shape">Собственно фигура</param>
        /// <returns>Площадь круга или нуль, если радиус отрицательный</returns>
        public double GetSquare(Shape shape)
        {
            var circle = shape as Circle;

            //Проверка радиуса на отрицательное значение
            if (circle.Radius > 0)
            {
                //Вычисление площади круга
                var square = Circle.PI * MathHelper.GetSqr(circle.Radius);

                return MathHelper.GetRoundedValue(square, 2);
            }
            else
            {
                Console.WriteLine("Ошибка! Радиус окружности должен быть положительным!");
                return 0;
            }

        }
    }
}
