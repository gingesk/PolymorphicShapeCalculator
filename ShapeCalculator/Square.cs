using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Square : EdgedShapes
    {
        Input input = new Input();
        Output output = new Output();
        Menu menu = new Menu();
        RangeValidation rangeValidation = new RangeValidation();

        //stated in the optimisation log, based on feedback
        //reduced code to only display the calculation of the formula not a variable
        private double CalculateArea()
        {
            return Math.Pow(Length, 2);
        }

        private double CalculatePerimeter()
        {
            return 4 * Length;
        }

        public override void Conductor()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter the length ");
                Length = input.GetInputAndTypeValidate(Length);
                isValid = rangeValidation.ValidateRange(Length, 0, 999999);
            } while (!isValid);

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
            output.OutputValue("Area", "Square", Math.Round(Area, 2));
            output.OutputValue("Perimeter", "Square", Math.Round(Perimeter, 2));
            menu.MenuOrQuit();
        }
    }
}
