namespace shape
{
    public class Rectangle : shape, area
    {
        public Rectangle(double height, double width) : base(height, width)
        {
            
        }

        public double area(double medida1, double medida2)
        {
            return medida1 * medida2;
        }
    }
}