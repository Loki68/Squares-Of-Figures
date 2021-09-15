using System;

namespace SquaresOfFigures.Library.Helpers
{
    /// <summary>
    /// Класс "обертка" над Math.
    /// В нем собраны заготовки для типовых операций для вычисления площади
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Метод осуществляет возведение числа в квадрат
        /// </summary>
        /// <param name="number">Число,которое нужно возвести во вторую степень</param>
        /// <returns>Квадрат числа</returns>
        public static double GetSqr(double number)
        {
            return Math.Pow(number, 2);
        }

        /// <summary>
        /// Метод возвращает результат округления числа.
        /// </summary>
        /// <param name="number">Число, которое предстоит округлить</param>
        /// <param name="roundedPositions">Можно расширить, но в коде выставляются стандартные два знака после запятой</param>
        /// <returns>Округленное число</returns>
        public static double GetRoundedValue(
            double number,
            int roundedPositions)
        {
            return Math.Round(number, roundedPositions);
        }

        /// <summary>
        /// Метод подсчета периметра треугольника
        /// Принимает параметрами стороны треугольника
        /// </summary>
        /// <param name="firstNumber">Первая сторона</param>
        /// <param name="secondNumber">Вторая сторона</param>
        /// <param name="thirdNumber">Третья сторона</param>
        /// <returns>Периметр треугольника</returns>
        public static double GetTrianglePerimeter(
            double firstNumber,
            double secondNumber,
            double thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        /// <summary>
        /// Метод подсчета площади произвольного треугольника по формуле Герона
        /// Метод принимает 4 параметра:
        /// полупериметр треугольника,
        /// первую сторону треугольника,
        /// вторую сторону треугольника,
        /// третью сторону треугольника.
        /// </summary>
        /// <param name="halfPerimeter">Полупериметр треугольника</param>
        /// <param name="firstNumber">Первая сторона треугольника</param>
        /// <param name="secondNumber">Вторая сторона треугольника</param>
        /// <param name="thirdNumber">Третья сторона треугольника</param>
        /// <returns>Площадь произвольного треугольника</returns>
        public static double HeronsFormula(
            double halfPerimeter,
            double firstNumber,
            double secondNumber,
            double thirdNumber)
        {
            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstNumber) * (halfPerimeter - secondNumber) * (halfPerimeter - thirdNumber));
        }

        /// <summary>
        /// Метод,возвращающий минимум из двух чисел
        /// </summary>
        /// <param name="firstNumber">Первое число</param>
        /// <param name="secondNumber">Второе число</param>
        /// <returns>Минимум из двух чисел</returns>
        public static double GetMin(
            double firstNumber,
            double secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        } 

        /// <summary>
        /// Метод для подсчета площади прямоугольника по двум заданным сторонам
        /// </summary>
        /// <param name="firstNumber">Первая из сторон</param>
        /// <param name="secondNumber">Вторая из сторон</param>
        /// <returns>Площадь прямоугольника</returns>
        public static double GetRectangleSquare(
            double firstNumber,
            double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
