using System;

namespace _03.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSide = int.Parse(Console.ReadLine());

            int area = squareSide * squareSide;

            Console.WriteLine(area);
        }
    }
}
