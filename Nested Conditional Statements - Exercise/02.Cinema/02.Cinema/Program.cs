using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double premiere = 12.0;
            double normal = 7.5;
            double discount = 5.0;

            if (ticket == "Premiere")
            {
                double income = premiere * rows * cols;
                Console.WriteLine($"{income:f2} leva");
            }
            if (ticket == "Normal")
            {
                double income = normal * rows * cols;
                Console.WriteLine($"{income:f2} leva");
            }
            if (ticket == "Discount")
            {
                double income = discount * rows * cols;
                Console.WriteLine($"{income:f2} leva");
            }
        }
    }
}
