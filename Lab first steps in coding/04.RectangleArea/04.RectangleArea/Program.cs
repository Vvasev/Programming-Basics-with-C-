﻿using System;

namespace _04.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double area = sideA * sideB;
            Console.WriteLine(area  );
        }
    }
}
