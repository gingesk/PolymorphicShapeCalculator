using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    abstract class EdgedShapes : Shapes2D
    {
        public double Length { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
    }
}
