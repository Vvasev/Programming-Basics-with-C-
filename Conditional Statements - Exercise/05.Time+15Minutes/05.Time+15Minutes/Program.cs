using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int minutePlusFifteen = minute + 15;

            if (minutePlusFifteen >=60)
            {
                minutePlusFifteen -= 60;
                hour++;
            }
            if (hour >= 24) 
            {
                hour -= 24;
            }
            if (minutePlusFifteen<10)
            {
                Console.WriteLine($"{hour}:0{minutePlusFifteen}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutePlusFifteen}");
            }
           
        }
    }
}
