using SquaresOfFigures.Library.Strategy;

namespace SquaresOfFigures.Library.Context
{
    /// <summary>
    /// Наследник контекста, реализующий фигуру - круг
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Константа Пи
        /// </summary>
        public const double PI = 3.14;

        /// <summary>
        /// Свойство для хранения радиуса окружности
        /// Инициализируется в конструкторе
        /// </summary>
        public double Radius { get; init; }

        /// <summary>
        /// Контруктор круга, принимает два параметра
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <param name="square">Экземпляр стратегии</param>
        public Circle(
            double radius,
            ISquare square)
            : base(square)
        {
            Radius = radius;
        }
    }
}
