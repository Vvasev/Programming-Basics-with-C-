using System;

namespace _09.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double familyIncome = double.Parse(Console.ReadLine());
            double averageGarde = double.Parse(Console.ReadLine());
            double paygrade = double.Parse(Console.ReadLine());

            double scolarship = averageGarde * 25;
            double socialScolarship = paygrade * 0.35;

            if (averageGarde <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else  if (averageGarde>4.50 && averageGarde<5.50)
            {
                if (familyIncome>paygrade)
                {
                    Console.WriteLine("You cannot get a scholarship!"); 
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
                }
            }
            else if (averageGarde>=5.5)
            {
                if (familyIncome > paygrade)
                {
                    Console.WriteLine($" You get a scholarship for excellent results { Math.Floor(scolarship)} BGN ");
                }
                else if (familyIncome<=paygrade)
                {
                    if (scolarship>socialScolarship)
                    {
                        Console.WriteLine($" You get a scholarship for excellent results { Math.Floor(scolarship)} BGN ");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
                    }
                }
            }
        }
    }
}
