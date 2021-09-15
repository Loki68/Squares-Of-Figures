using SquaresOfFigures.Library.Strategy;

namespace SquaresOfFigures.Library.Context
{
    /// <summary>
    /// Базовый класс иерархии фигур.
    /// Он представляет собой контекст стратегии
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// Свойство для хранения экземпляра интерфейса - самой стратегии.
        /// Инициализируется в конструкторе
        /// </summary>
        public ISquare Square { get; init; }

        /// <summary>
        /// публичная переменная для хранения площади фигуры
        /// </summary>
        public double ShapeSquare;

        /// <summary>
        /// Конструктор класса контекста
        /// В этой программе "стратегия" реализована в виде интерфейса ISquare
        /// </summary>
        /// <param name="square">Экземпляр "стратегии"</param>
        public Shape(ISquare square)
        {
            Square = square;
        }

        /// <summary>
        /// Собственно метод контекста
        /// Запрашивает вычисление площади фигуры
        /// </summary>
        public void Execute()
        {
            ShapeSquare = Square.GetSquare(this);
        }
    }
}
