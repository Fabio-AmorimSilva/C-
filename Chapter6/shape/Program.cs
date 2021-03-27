using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var reactangle = new Rectangle(3, 4.5);
            reactangle.areaValue = reactangle.area(reactangle.height, reactangle.width);
            Console.WriteLine("Reactangle values.");
            Console.WriteLine($"Height: {reactangle.height}, Width: {reactangle.width} and Area: {reactangle.areaValue}");

            var square = new Square(5, 5);
            Console.WriteLine("Square values");
            square.areaValue = square.area(square.height, square.width);
            Console.WriteLine($"Height: {square.height}, Width: {square.width} and Area: {square.areaValue}");

            var circle = new Circle(3.14, 2.5);
            Console.WriteLine("Circle values");
            circle.areaValue = circle.area(circle.height, circle.width);
            Console.WriteLine($"Height: {circle.height}, Width: {circle.width} and Area: {circle.areaValue}");



        }
    }
}
