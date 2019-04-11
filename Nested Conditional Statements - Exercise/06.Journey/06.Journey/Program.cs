using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string country = string.Empty;
            string place = string.Empty;
            double money = 0.0;

            if (budget > 1000)
            {
                country = "Europe";
                money = budget * 0.10;
                if (season == "summer")
                {
                    place = "Hotel";
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    money = budget * 0.60;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    money = budget * 0.20;
                    place = "Hotel";
                }
            }
            else 
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    money = budget * 0.70;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    money = budget * 0.30;
                }
            }
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{place} - {Math.Round(budget -money,2):f2}");
        }
    }
}
