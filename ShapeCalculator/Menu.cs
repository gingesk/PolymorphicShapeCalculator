using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Menu 
    {
        Input input = new Input();
        RangeValidation rangeValidation = new RangeValidation();

        List<Shapes2D> Shapes2D = new List<Shapes2D>();

        public void MainMenu()
        {
            //used for polymorphism, method overriding
            Shapes2D.Add(new Rectangle());
            Shapes2D.Add(new Square());
            Shapes2D.Add(new Circle());
            int intChoice = 0;
            bool isValid = false;
            //menu menu loop which validates the shape choice input

            do
            {
                Console.WriteLine("Select Your Option: [1] - Rectangle   [2] - Square    [3] - Circle   [4] - Quit");
                intChoice = input.GetInputAndTypeValidate(intChoice);
                isValid = rangeValidation.ValidateRange(intChoice, 1, 4);
                
            } while (!isValid);


            //if statement uses choice value to choose which shape methods are chosen to run
            if (intChoice == 1) // Square
            {
                Shapes2D[0].Conductor();
            }
            else if (intChoice == 2) // Rectangle
            {
                Shapes2D[1].Conductor();
            }
            else if (intChoice == 3) // Circle
            {
                Shapes2D[2].Conductor();
            }
            else if (intChoice == 4) // Quit
            {
                Exit();
            }

        }

        public void MenuOrQuit()
        {
            bool isValid = false;
            int menuChoice = 0;
            do
            {
                //this section of code was out of loop, this was found due to questionnaire feedback.
                //It was listed in the optimisation log.
                Console.WriteLine("Press [1] - Menu     [2] - Quit");
                menuChoice = input.GetInputAndTypeValidate(menuChoice);
                rangeValidation.ValidateRange(menuChoice, 1, 2);

                if (menuChoice == 1)
                {
                    MainMenu();
                    isValid = true;
                }
                else if (menuChoice == 2)
                {
                    Exit();
                    isValid = true;
                }
            } while (!isValid);
        }
        //closes program when method is called
        public void Exit()
        {
            Console.WriteLine("Quiting Program, thank you...");
            //removed operation below to avoid bad habits
            Environment.Exit(0);
        }
    }
    
}
