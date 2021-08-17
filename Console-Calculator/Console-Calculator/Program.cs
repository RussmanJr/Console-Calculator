using System;

namespace Console_Calculator
{
    class Program
    {

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Console Calculator");
        }





        static int Addition(int x, int y)
        {
            int AddedNumbers = x + y;
            Console.WriteLine("The values equal " + AddedNumbers);
            return AddedNumbers;
        }
        static int Subtraction(int x, int y)
        {
            int SubtractedNumbers = x - y;
            Console.WriteLine("The values equal " + SubtractedNumbers);
            return SubtractedNumbers;
        }
        static int division(int x, int y) {
            int DividedNumbers = x / y;
            Console.WriteLine("The values equal " + DividedNumbers);
            return DividedNumbers;
        }
        static int multiplication(int x, int y)
        {
            int MultipiedNumbers = x * y;
            Console.WriteLine("The values equal " + MultipiedNumbers);
            return MultipiedNumbers;
        }

        static void Mathication()
        {
            Console.WriteLine("Select a math operation:");
            Console.WriteLine("1.  Addition");
            Console.WriteLine("2.  Subtration");
            Console.WriteLine("3.  Multiplication");
            Console.WriteLine("4.  Division");
            int UserSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (UserSelection) {
                case 1:
                    Addition(x, y);
                    break;
                case 2:
                    Console.WriteLine("Enter a value for X:");
                    Subtraction(x, y);
                    break;
                case 3:
                    Console.WriteLine("Enter a value for X:");
                    multiplication(x, y);
                    break;
                case 4:
                    Console.WriteLine("Enter a value for X:");
                    division(x, y);
                    break;
                default:
                    Console.WriteLine("Invalid entries for x and/or y or both.  Try again!");
                    break;

            }

        }

        static void Main(string[] args)
        {
            bool FunctionSwitch = true;

            do
            {
                Mathication();
                //end of program.  Program repeats.
            } while (FunctionSwitch == true);
        }
    }
}
