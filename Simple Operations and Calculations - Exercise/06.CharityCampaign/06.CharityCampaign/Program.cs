using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfCampaign = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesIncomePerOneBaker = cakes * 45;
            double wafflesIncomePerOneBaker = waffles * 5.80;
            double pancakesIncomePerOneBaker = pancakes * 3.20;

            double incomePerDay = (cakesIncomePerOneBaker + wafflesIncomePerOneBaker + pancakesIncomePerOneBaker) * bakers;
            double incomeForTheCampaign = incomePerDay * daysOfCampaign;
            double products = incomeForTheCampaign * 0.125;

            double revenue = incomeForTheCampaign - products;

            Console.WriteLine($"{revenue:f2}");
        }
    }
}
