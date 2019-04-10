using System;

namespace _07.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1.0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 7;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 8;
                }
                else if (sales > 10000)
                {
                    commision = 12;
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 4.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 7.5;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 10;
                }
                else if (sales > 10000)
                {
                    commision = 13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 5.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 8;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 12;
                }
                else if (sales > 10000)
                {
                    commision = 14.5;
                }
            }
            if (commision < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                double result = commision * sales / 100;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
