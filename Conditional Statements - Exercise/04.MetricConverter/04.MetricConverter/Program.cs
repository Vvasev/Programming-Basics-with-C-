using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            if (from=="mm")
            {
                lenght /= 1000;
            }
            else if (from == "cm")
            {
                lenght /= 100;
            }

            if (to == "mm")
            {
                lenght *= 1000;
            }
            else if (to == "cm")
            {
                lenght *= 100;
            }

            Console.WriteLine("{0:f3}",lenght);
        }
    }
}
