using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double bgn = 1.85;
            double priceInUsd = 0;


            double cubikMetersTableCloth = (lenght + 2 * 0.30) * (width + 2 * 0.30) * tables;
            double secondPartOfTheTableCloth = (lenght / 2) * (lenght / 2)*tables;

            priceInUsd = cubikMetersTableCloth * 7 + secondPartOfTheTableCloth * 9;

            Console.WriteLine($"{priceInUsd:f2} USD");
            Console.WriteLine($"{priceInUsd*bgn:f2} BGN");
        }
    }
}
