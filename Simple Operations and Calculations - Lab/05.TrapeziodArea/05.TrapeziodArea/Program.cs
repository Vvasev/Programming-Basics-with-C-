using System;

namespace _05.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
           var sideA = double.Parse(Console.ReadLine());
           var sideB = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var trapezoid = height * ((sideA + sideB) / 2);

            Console.WriteLine($"{trapezoid:f2}");
        }
    }
}
