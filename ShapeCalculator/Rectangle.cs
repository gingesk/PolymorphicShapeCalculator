using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Rectangle : EdgedShapes
    {
        Input input = new Input();
        Output output = new Output();
        Menu menu = new Menu();
        RangeValidation rangeValidation = new RangeValidation();

        public double Width { get; set; }


        //stated in the optimisation log, based on feedback
        //reduced code to only display the calculation of the formula not a variable
        private double CalculateArea()
        {
            return Length * Width;
        }

        private double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        //executes all methods needed for the shape
        public override void Conductor()
        {
            bool isValid = false;
  
            do
            {
                Console.WriteLine("Please enter the length ");
                Length = input.GetInputAndTypeValidate(Length);
                isValid = rangeValidation.ValidateRange(Length, 0, 999999);
            } while (!isValid);
            do
            {
                Console.WriteLine("Please enter the width ");
                Width = input.GetInputAndTypeValidate(Width);
                isValid = rangeValidation.ValidateRange(Width, 0, 999999);
            } while (!isValid);

            Area = Math.Round(CalculateArea(), 2);
            Perimeter = Math.Round(CalculatePerimeter(), 2);
            output.OutputValue("Area", "Rectangle", Area);
            output.OutputValue("Perimeter", "Rectangle", Perimeter);
            menu.MenuOrQuit();
        }
    }
}
