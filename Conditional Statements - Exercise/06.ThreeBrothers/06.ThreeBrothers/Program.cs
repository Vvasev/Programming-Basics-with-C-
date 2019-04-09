using System;

namespace _06.ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double brotherA = double.Parse(Console.ReadLine());
            double brotherB = double.Parse(Console.ReadLine());
            double brotherC = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double timeCleanning = 1/(1/brotherA + 1/brotherB + 1/brotherC);
            double breakTime = timeCleanning * 0.15;
            double timeToClean = timeCleanning + breakTime;

            Console.WriteLine($"Cleaning time: {timeToClean:f2}");
            if (timeToClean <= father)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(father - timeToClean)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeToClean - father)} hours.");
            }
        }
    }
}
