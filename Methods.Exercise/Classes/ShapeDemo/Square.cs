namespace Classes.Exercise
{
    public class Square : Polygon
    {
        public Square(int width)    // Costructor
        {
            Width = width;  // Property = parameter
        }
        public override double Area() // Override the base class method to be a valid polygon
        {
            return Width * Width;
        }
    }

}

