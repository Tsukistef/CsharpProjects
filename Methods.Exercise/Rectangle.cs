﻿using Classes.Exercise;

namespace Methods.Exercise
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
            throw new NotImplementedException();
        }
    }

}
