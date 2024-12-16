using Classes.Exercise;

namespace Classes.Exercise
{
    public class Rectangle : Polygon, I2DShape // only one class can be inherited, but multiple interfaces
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }
        public override int Area()
        {
            return Length * Width;
        }
        public int Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }

}

