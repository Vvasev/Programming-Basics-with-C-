using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtInMerters = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());
            double dressingRoom = double.Parse(Console.ReadLine());

            double sizeInCentimeters = lenghtInMerters  * widthInMeters * 10000;
            double dressingRoomSize = dressingRoom * dressingRoom * 10000;
            double bench = sizeInCentimeters / 10;
            double availableSpace = sizeInCentimeters - dressingRoomSize - bench;
            double dancersThatFit = availableSpace / 7040;

            Console.WriteLine(Math.Floor(dancersThatFit));
        }
    }
}
