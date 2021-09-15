using SquaresOfFigures.Library;
using SquaresOfFigures.Library.Context;
using SquaresOfFigures.Library.Strategy;
using System;

namespace SquaresOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            ISquare square;
            Shape shape;

                square = new TriangleSquare();
                shape = new Triangle(3, 4, 5, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);

                TriangleChecker checker = new TriangleChecker(shape);
                checker.TriangleIsRect();

                shape = new Triangle(6, 7, 8, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);

                checker = new TriangleChecker(shape);
                checker.TriangleIsRect();

                shape = new Triangle(4, 4, 5, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);

                checker = new TriangleChecker(shape);
                checker.TriangleIsRect();

                square = new CircleSquare();
                shape = new Circle(5, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);

                square = new CircleSquare();
                shape = new Circle(-2, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);

                square = new TriangleSquare();
                shape = new Triangle(1, 1, 15, square);
                shape.Execute();
                Console.WriteLine(shape.ShapeSquare);
            
        }
    }
}
