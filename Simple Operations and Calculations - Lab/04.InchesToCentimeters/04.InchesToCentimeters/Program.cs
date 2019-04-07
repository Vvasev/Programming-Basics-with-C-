using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());

            var centimeters = inches * 2.54;

            Console.WriteLine("{0:f2}",centimeters);
        }
    }
}
