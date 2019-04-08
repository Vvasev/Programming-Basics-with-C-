using System;

namespace _09.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;
            switch (figure)
            {
                case "square":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        area = sideA * sideA;
                        break;
                    }

                case "rectangle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        double sideB = double.Parse(Console.ReadLine());
                        area = sideA * sideB;
                        break;
                    }
                case "circle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        area = Math.PI * sideA*sideA;
                        break;
                    }
                case "triangle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        double sideB = double.Parse(Console.ReadLine());
                        area = sideA * sideB/2;
                        break;
                    }
            }
            Console.WriteLine($"{area:f3}");

        }
    }
}
