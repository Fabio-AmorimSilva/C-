namespace shape
{
    public class Square : shape, area
    {
        public Square(double height, double width) : base(height, width)
        {
        }

        public double area(double lado, double altura)
        {
            return lado * altura;
        }
    }
}