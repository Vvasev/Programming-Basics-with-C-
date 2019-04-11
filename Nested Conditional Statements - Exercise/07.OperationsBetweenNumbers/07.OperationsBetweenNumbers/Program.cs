using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            string evenOrOdd = string.Empty;
            double result = 0.0;

            if (operation == "+")
            {
                result = numberA + numberB;
            }
            else if (operation == "-")
            {
                result = numberA - numberB;
            }
            else if (operation == "*")
            {
                result = numberA * numberB;
            }
            else if (operation == "/")
            {
                result = numberA / numberB;
            }
            else if (operation == "%")
            {
                result = numberA % numberB;
            }

            if (operation =="+"||operation =="-"||operation == "*")
            {
                if (result%2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{numberA} {operation} {numberB} = {Math.Round(result)} - {evenOrOdd}");
                return;
            }
            else
            {
                if (numberA == 0 )
                {
                    Console.WriteLine($"Cannot divide {numberB} by zero");
                }
                else if (numberB == 0)
                {
                    Console.WriteLine($"Cannot divide {numberA} by zero");
                }

                else if (operation == "/" )
                {
                    Console.WriteLine($"{numberA} {operation} {numberB} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"{numberA} {operation} {numberB} = {result}");
                }
            }
        }
    }
}
