using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Spring")
            {
                rent = 3000;
            }
            else
            {
                rent = 2600;
            }

            if (fisherMen>0 && fisherMen <=6)
            {
                rent *= 0.9;
            }
            else if (fisherMen>6 && fisherMen<=11)
            {
                rent *= 0.85;
            }
            else
            {
                rent *= 0.75;
            }

            if (fisherMen%2 == 0 && season !="Autumn")
            {
                rent *= 0.95;
            }


            if (budget>=rent)
            {
                Console.WriteLine($"Yes! You have {budget-rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget-rent):f2} leva.");
            }
        }
    }
}
