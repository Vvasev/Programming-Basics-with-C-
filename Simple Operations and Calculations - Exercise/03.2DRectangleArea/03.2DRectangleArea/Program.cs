using System;

namespace _03._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);

            double area = width * height * 1.00;
            double perimeter = (width + height) * 2* 1.00;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");

        }
    }
}
