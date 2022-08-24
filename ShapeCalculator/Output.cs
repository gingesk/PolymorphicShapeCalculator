using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Output
    {
        public void OutputValue(string attribute, string shape, double value)
        {
            Console.WriteLine($"The {attribute} of the {shape} is equal to {value}");
        }
    }
}
