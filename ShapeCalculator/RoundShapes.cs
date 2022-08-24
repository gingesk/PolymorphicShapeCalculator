using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    abstract class RoundShapes : Shapes2D
    {
        public double Area { get; set; }
        public double Radius { get; set; }
        public double Circumfrence { get; set; }

    }
}
