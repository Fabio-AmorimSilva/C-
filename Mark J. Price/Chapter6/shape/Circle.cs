using System;

namespace shape
{
    public class Circle : shape, area
    {
        public Circle(double height, double width) : base(height, width)
        {
        }

        public double area(double pi, double raio){
            return pi * Math.Pow(raio, 2);
        }
    }
}