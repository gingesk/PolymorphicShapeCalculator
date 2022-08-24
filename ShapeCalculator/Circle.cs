using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Circle : RoundShapes
    {
        Input input = new Input();
        Output output = new Output();
        Menu menu = new Menu();
        RangeValidation rangeValidation = new RangeValidation();

        //stated in the optimisation log, based on feedback
        //reduced code to only display the calculation of the formula not a variable
        private double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private double CalculateCircumfrence()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Conductor()
        {
            bool isValid = false;
            do
            {
                //In the writeline below, i asked for length rather than the radius.
                //This optimisation was stated in the optimisation log.
                Console.WriteLine("Please enter the radius ");
                Radius = input.GetInputAndTypeValidate(Radius);
                isValid = rangeValidation.ValidateRange(Radius, 0, 999999);
            } while (!isValid);

            Area = Math.Round(CalculateArea(), 2);
            Circumfrence = Math.Round(CalculateCircumfrence(), 2);
            output.OutputValue("Area", "Circle", Area);
            output.OutputValue("Circumfrence", "Circle", Circumfrence);
            menu.MenuOrQuit();
        }
    }
}
