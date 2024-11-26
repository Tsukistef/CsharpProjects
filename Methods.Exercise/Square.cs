namespace Methods.Exercise
{
    public class Square : Polygon
    {
        public Square(int width)    // Costructor
        {
            Width = width;  // Property = parameter
        }
        public override int Area() // Override the base class method to be a valid polygon
        {
            return Width * Width;
        }
    }

}

