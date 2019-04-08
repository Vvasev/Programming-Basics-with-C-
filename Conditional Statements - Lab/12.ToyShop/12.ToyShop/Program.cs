using System;

namespace _12.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int talkingDoll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int allToysOrderd = puzzle + talkingDoll + teddyBear + minion + truck;

            double puzzlePrice = 2.60 * puzzle ;
            double dollPrice = 3.00 * talkingDoll;
            double bearPrice = 4.10 * teddyBear;
            double minionPrice = 8.20 * minion;
            double truckPrice = 2.00 * truck;

            double sumOfIncome = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;

            if (allToysOrderd >= 50) 
            {
                sumOfIncome *= 0.75;
            }

            sumOfIncome *= 0.90;

            if (sumOfIncome>=priceOfHoliday)
            {
                Console.WriteLine($"Yes! {sumOfIncome-priceOfHoliday:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfHoliday-sumOfIncome:f2} lv needed.");
            }
        }
    }
}
