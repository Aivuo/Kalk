using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;


            while (runningProgram == true)
            {
                runningProgram = StartMenu();
            }
        }

        static bool StartMenu()
        {
            string choice;
            int intChoice = 0;

            Console.Clear();
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("Choose your function: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. End");
            choice = Console.ReadLine();

            int.TryParse(choice, out intChoice);

            switch (intChoice)
            {
                case 1:
                    Addition();
                    break;

                case 2:
                    Subtraction();
                    break;
                case 3:

                    break;

                case 4:

                    break;

                case 5:
                    return false;
                    break;

                default:
                    Console.WriteLine(choice + " is not a valid option!");
                    break;
            }

            return true;
        }

        static void Addition()
        {
            float answer = 0;

            String parameterString;
            float firstParameter = 0;
            float secondParameter = 0;

            Console.Clear();
            Console.WriteLine("Give me the first number: ");

            parameterString = Console.ReadLine();
            float.TryParse(parameterString, out firstParameter);

            Console.WriteLine("Now give me a second number: ");

            parameterString = Console.ReadLine();
            float.TryParse(parameterString, out secondParameter);

            answer = firstParameter + secondParameter;
            Console.WriteLine("The answer is: " + answer);
            Console.WriteLine("Return to menu y/n");
            if (Console.ReadLine() == "y")
                StartMenu();
            else
                Addition();
        }

        static void Subtraction()
        {
            float answer = 0;
        }
    }
}
