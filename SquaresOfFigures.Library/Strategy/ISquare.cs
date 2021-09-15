using SquaresOfFigures.Library.Context;

namespace SquaresOfFigures.Library.Strategy
{
    /// <summary>
    /// Стратегия, в данной библиотеке представлена интерфейсом
    /// </summary>
    public interface ISquare
    {
        /// <summary>
        /// Шаблон для вычисления площади некоторой фигуры
        /// </summary>
        /// <param name="shape">Абстрактная фигура</param>
        /// <returns>Площадь фигуры</returns>
        double GetSquare(Shape shape);
        
    }
}
