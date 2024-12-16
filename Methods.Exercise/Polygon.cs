using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercise
{
    public abstract class Polygon
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public abstract double Area();
    }

}

