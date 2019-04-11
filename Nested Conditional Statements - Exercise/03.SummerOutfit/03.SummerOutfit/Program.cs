using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string shoes = string.Empty;
            string outfit = string.Empty;

            if (degrees>=10 && degrees<=18)
            {
                if (dayTime == "Morning")
                {
                    shoes = "Sneakers";
                    outfit = "Sweatshirt";
                }
                else if (dayTime == "Afternoon")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
                else if (dayTime == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            else if (degrees >18 && degrees <=24)
            {
                if (dayTime == "Morning")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
                else if (dayTime == "Afternoon")
                {
                    shoes = "Sandals";
                    outfit = "T-Shirt";
                }
                else if (dayTime == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            else if (degrees >= 25)
            {
                if (dayTime == "Morning")
                {
                    shoes = "Sandals";
                    outfit = "T-Shirt";
                }
                else if (dayTime == "Afternoon")
                {
                    shoes = "Barefoot";
                    outfit = "Swim Suit";
                }
                else if (dayTime == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
