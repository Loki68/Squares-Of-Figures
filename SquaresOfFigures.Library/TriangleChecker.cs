using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Helpers;
using System;

namespace SquaresOfFigures.Library
{
    /// <summary>
    /// Класс для проверки треугольника на прямоугольность
    /// </summary>
    public class TriangleChecker
    {
        //Поле для хранения треугольника
        Triangle _triangle;

        /// <summary>
        /// Вспомогательные поля для предполагаемых катетов треугольника
        /// </summary>
        double _firstSide, _secondSide, _rectTriangleSquare;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="triangle">Треугольник, площадь которого уже вычислена</param>
        public TriangleChecker(Shape triangle)
        {
            _triangle = triangle as Triangle;

        }

        /// <summary>
        /// Метод проверки треугольника на прямоугольность через сравнение значения площади исходного треугольника
        /// И предполагаемого прямоугольного треугольника, построенного на элементах исходного
        /// </summary>
        public void TriangleIsRect()
        {
            //Метод получения возможных катетов
            GetCathethas();

            //Метод Вычисления площади прямоугольного треугольника
            GetRectTriangleSquare();

            //Проверка площадей на равенство
            if (_rectTriangleSquare == _triangle.ShapeSquare) Console.WriteLine("Треугольник прямоугольный!");
            else Console.WriteLine("Треугольник не прямоугольный!");

            Console.WriteLine();
        }

        /// <summary>
        /// Метод, вычислящий предполагаемые катеты предполагаемого прямоугольного треугольника, выбирая меньшие из сторон
        /// </summary>
        private void GetCathethas()
        {
            _firstSide = MathHelper.GetMin(_triangle.FirstSide, _triangle.SecondSide);
            _secondSide = MathHelper.GetMin(_triangle.SecondSide, _triangle.ThirdSide);
        }

        /// <summary>
        /// Метод, вычислящий площадь прямоугольного треугольника по полученным катетам
        /// </summary>
        private void GetRectTriangleSquare()
        {
            //Так как площадь прямоугольного треугольника равна половине площади прямоугольника, построенного на катетах этого трегольника,
            //нам достаточно посчитать площадь прямоугольника и поделить ее на 2.
            _rectTriangleSquare = MathHelper.GetRectangleSquare(_firstSide, _secondSide) / 2;
        }

    }
}
