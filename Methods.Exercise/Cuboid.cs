using Methods.Exercise;

namespace Classes.Exercise
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public override double Area()
        {
            return 2 * (Width * Length) + (Length * Height) + (Height * Width);
        }

        public double Perimeter()
        {
            return 4 * (Width + Length + Height);
        }

        public double Volume()
        {
            return (Length * Width * Height);
        }
   
    }
}
