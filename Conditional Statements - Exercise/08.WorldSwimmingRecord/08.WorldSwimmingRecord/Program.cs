using System;

namespace _08.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double meterPerSec = double.Parse(Console.ReadLine());

            double timeToSwim = distanceInMeters * meterPerSec;
            double swimmer = Math.Floor(distanceInMeters / 15) * 12.5;
            double swimmersTime = timeToSwim + swimmer;

            if (swimmersTime <recordInSeconds )
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimmersTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordInSeconds-swimmersTime):f2} seconds slower.");
            }
        }
    }
}
