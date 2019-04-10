using System;

namespace _08.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();

            double roomForOnePerson = 18.0;
            double apartment = 25.0;
            double presidentApartment = 35.0;

            double discount = 0.0;

            if (room== "room for one person")
            {
                if (review == "positive")
                {
                    Console.WriteLine($"{((days-1) * roomForOnePerson)*1.25:f2}");
                }
                else
                {
                    Console.WriteLine($"{((days - 1) * roomForOnePerson) * 0.9:f2}");
                }
            }
            else if (room == "apartment")
            {
                if (days <10)
                {
                    discount = 0.70;    
                }
                else if (days>=10 && days<15)
                {
                    discount = 0.65;
                }
                else
                {
                    discount = 0.5;
                }
                if (review == "positive")
                {
                    Console.WriteLine($"{((days-1)*apartment *discount)*1.25:f2}");
                }
                else
                {
                    Console.WriteLine($"{((days - 1) * apartment * discount) * 0.9:F2}");
                }
            }

            else if (room == "president apartment")
            {
                if (days < 10)
                {
                    discount = 0.9;
                }
                else if (days >= 10 && days < 15)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.8;
                }
                if (review == "positive")
                {
                    Console.WriteLine($"{((days - 1) * presidentApartment * discount) * 1.25:f2}");
                }
                else
                {
                    Console.WriteLine($"{((days - 1) * presidentApartment * discount) * 0.9:f2}");
                }
            }
        }
    }
}
