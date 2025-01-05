using Classes.Exercise.Interfaces;

namespace Classes.Exercise
{
    public class Rectangle : Polygon, I2DShape // only one class can be inherited, but multiple interfaces
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }
        public double Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }

}

