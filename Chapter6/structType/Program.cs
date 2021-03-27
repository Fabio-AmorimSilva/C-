using System;

namespace structType
{
    class Program
    {
        static void Main(string[] args)
        {
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;

            Console.WriteLine($"({dv1.x}, {dv1.y}) + ({dv2.x}, {dv2.y}) = ({dv3.x}, {dv3.y})");
        }
    }
}
