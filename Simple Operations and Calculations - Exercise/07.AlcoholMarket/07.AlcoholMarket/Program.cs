using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerInLiters = double.Parse(Console.ReadLine());
            double wineInLiters = double.Parse(Console.ReadLine());
            double rakiaInLiters = double.Parse(Console.ReadLine());
            double whiskeyInLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.60;
            double beerPrice = rakiaPrice * 0.20;

            double bill = (whiskeyPrice * whiskeyInLiters) + (beerPrice * beerInLiters) + (wineInLiters * winePrice) + (rakiaPrice * rakiaInLiters);

            Console.WriteLine($"{bill:f2}");


        }
    }
}
