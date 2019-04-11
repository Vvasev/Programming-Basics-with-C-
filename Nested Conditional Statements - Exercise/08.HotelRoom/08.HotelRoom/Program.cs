using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double priceApartment = 0.0;
            double priceStudio = 0.0;

            if (month == "May" || month == "October")
            {
                priceApartment = 65.0;
                priceStudio = 50.0;
                if (nights>7 && nights<=14)
                {
                    priceStudio *= 0.95;
                }
                else if (nights > 14 )
                {
                    priceStudio *= 0.7;
                    priceApartment *= 0.9;
                }     
            }
            else if (month == "June" || month == "September")
            {
                priceApartment = 68.70;
                priceStudio = 75.20;
                if (nights>14)
                {
                    priceApartment *= 0.9;
                    priceStudio = 0.8;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceApartment = 77.0;
                priceStudio = 76.0;
                if (nights > 14)
                {
                    priceApartment *= 0.90;
                }
            }
            priceApartment *= nights;
            priceStudio *= nights;
            Console.WriteLine($"Apartment: {(priceApartment):f2} lv.");
            Console.WriteLine($"Studio: {(priceStudio):f2} lv.");
        }
    }
}
