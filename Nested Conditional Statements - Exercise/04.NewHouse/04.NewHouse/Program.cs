using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerAmout = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double moneySpent = 0.0;

            double rose = 5.0*flowerAmout;
            double dalia = 3.80 * flowerAmout;
            double lale = 2.80 * flowerAmout;
            double narcis = 3.0 * flowerAmout;
            double gladiol = 2.50 * flowerAmout;

                
            if (flower =="Roses")
            {
                if (flowerAmout>80)
                {
                    moneySpent= rose * 0.90;
                }
                else if (flowerAmout<=80)
                {
                    moneySpent = rose;
                }
            }
            if (flower == "Tulips")
            {
                if (flowerAmout > 80)
                {
                    moneySpent=lale* 0.85;
                }
                else if (flowerAmout <= 80)
                {
                    moneySpent = lale;
                }
            }
            if (flower == "Dahlias")
            {
                if (flowerAmout > 90)
                {
                    moneySpent = dalia * 0.85;
                }
                else if (flowerAmout <= 90)
                {
                    moneySpent = dalia;
                }
            }
            if (flower == "Narcissus")
            {
                if (flowerAmout < 120)
                {
                    moneySpent = narcis * 1.15;
                }
                else if (flowerAmout >= 120)
                {
                    moneySpent = narcis;
                }
            }
             if (flower == "Gladiolus")
            {
                if (flowerAmout < 80)
                {
                    moneySpent =gladiol* 1.20;
                }
                         else if (flowerAmout >= 80)
                {
                    moneySpent = gladiol;
                }
            }
            if (budget>=moneySpent)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerAmout} {flower} and {budget - moneySpent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget-moneySpent):f2} leva more.");
            }
        }
    }
}
