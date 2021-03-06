﻿using System;
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
            Console.WriteLine("Welcome to the Calculator" + "\n"
                            + "Choose your function:" + "\n"
                            + "1. Addition" + "\n"
                            + "2. Subtraction" + "\n"
                            + "3. Multiplication" + "\n"
                            + "4. Division" + "\n"
                            + "5. Multiple Addition" + "\n"
                            + "6. Multiple Subtraction" + "\n"
                            + "7. End" + "\n"
                );
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
                    Multiplication();
                    break;

                case 4:
                    Division();
                    break;

                case 5:
                    MultipleAddition();
                    break;

                case 6:
                    MultipleSubtraction();
                    break;

                case 7:
                    return false;

                default:
                    Console.WriteLine("\n" + choice + " is not a valid option!");
                    Console.ReadKey();
                    break;
            }

            return true;

        }

        private static void Multiplication()
        {
            float answer = 0;

            String parameterString;
            float firstParameter = 0;
            float secondParameter = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Multiplication!");
                Console.WriteLine("Give me the first number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out firstParameter);

                Console.WriteLine("Now give me a second number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out secondParameter);

                answer = firstParameter * secondParameter;
                Console.WriteLine("The answer is: " + answer);
                Console.WriteLine("Return to menu y/n");
                if (Console.ReadLine() == "y")
                    return;
            }
        }

        private static void Subtraction()
        {
            float answer = 0;

            String parameterString;
            float firstParameter = 0;
            float secondParameter = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Subtraction!");
                Console.WriteLine("Give me the first number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out firstParameter);

                Console.WriteLine("Now give me a second number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out secondParameter);

                answer = firstParameter - secondParameter;
                Console.WriteLine("The answer is: " + answer);
                Console.WriteLine("Return to menu y/n");
                if (Console.ReadLine() == "y")
                    return;
            }
        }


        private static void Addition()
        {
            float answer = 0;

            String parameterString;
            float firstParameter = 0;
            float secondParameter = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Addition!");
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
                    return;
            }
        }

        private static void Division()
        {
            float answer = 0;

            String parameterString;
            float firstParameter = 0;
            float secondParameter = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Division!");
                Console.WriteLine("Give me the first number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out firstParameter);

                Console.WriteLine("Now give me a second number: ");

                parameterString = Console.ReadLine();
                float.TryParse(parameterString, out secondParameter);

                if (secondParameter == 0)
                {
                    Console.WriteLine("0 is not an acceptable second parameter!");
                    Console.ReadKey();
                    Division();
                }

                answer = firstParameter / secondParameter;
                Console.WriteLine("The answer is: " + answer);
                Console.WriteLine("Return to menu y/n");
                if (Console.ReadLine() == "y")
                    return;
            }
        }

        private static void MultipleSubtraction()
        {
            string input;
            int inputNumber = 0;
            float value = 0;
            float answer = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("How many numbers would you like to subtract with?");
                input = Console.ReadLine();

                int.TryParse(input, out inputNumber);

                for (int i = 0; i < inputNumber; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Input a number: ");
                        input = Console.ReadLine();
                        float.TryParse(input, out value);
                        answer += value;
                    }
                    else
                    {
                        value = 0;

                        Console.WriteLine("Input a number: ");
                        input = Console.ReadLine();
                        float.TryParse(input, out value);
                        answer -= value;
                    }
                }
                Console.WriteLine("The answer is: " + answer);
                Console.WriteLine("Return to menu y/n");
                if (Console.ReadLine() == "y")
                    return;
            }
        }

        private static void MultipleAddition()
        {
            string input;
            int inputNumber = 0;
            float value = 0;
            float answer = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("How many numbers would you like to add together?");
                input = Console.ReadLine();

                int.TryParse(input, out inputNumber);

                for (int i = 0; i < inputNumber; i++)
                {
                    Console.WriteLine("Input a number: ");
                    input = Console.ReadLine();

                    float.TryParse(input, out value);
                    answer += value;
                }
                Console.WriteLine("The answer is: " + answer);
                Console.WriteLine("Return to menu y/n");

                if (Console.ReadLine() == "y")
                    return;
            }
        }
    }
}
