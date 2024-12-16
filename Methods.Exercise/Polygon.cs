using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Exercise
{
    public abstract class Polygon
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public abstract double Area();
    }

}

