using SquaresOfFigures.Library.Strategy;

namespace SquaresOfFigures.Library.Context
{
    /// <summary>
    /// Наследник контекста, реализующий фигуру - треугольник
    /// </summary>
    public class Triangle : Shape
    {
        // Следующие три свойства нициализируется в конструкторе:
        // Свойства для хранения трех сторон треугольника
        
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double FirstSide { get; init; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double SecondSide { get; init; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double ThirdSide { get; init; }

        /// <summary>
        /// Конструктор треугольника, принимает 4 параметра:
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <param name="square">Экземпляр "стратегии"</param>
        public Triangle(
            double firstSide,
            double secondSide,
            double thirdSide,
            ISquare square)
            : base(square)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }
}
