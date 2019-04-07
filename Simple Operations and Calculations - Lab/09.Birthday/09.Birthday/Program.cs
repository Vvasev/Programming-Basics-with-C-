using System;

namespace _09.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double litersAbleToHold = volume * 0.001;
            percent *= 0.01;

            double waterInTheTank = litersAbleToHold* (1 - percent);
            Console.WriteLine($"{waterInTheTank:f3}");

        }
    }
}
