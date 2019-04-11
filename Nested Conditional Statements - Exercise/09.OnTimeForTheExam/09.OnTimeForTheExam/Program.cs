using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArival = int.Parse(Console.ReadLine());
            int minuteAfArival = int.Parse(Console.ReadLine());

            int examInMinutes = 0;
            int ariavalInMinutes = 0;
            int hour = 0;
            int minute = 0;

            if (hourOfExam>0)
            {
                examInMinutes = hourOfExam * 60 +minuteOfExam;
            }
            if (hourOfArival > 0)
            {
                ariavalInMinutes = hourOfArival * 60 + minuteAfArival; 
            }
            if (hourOfArival==0 && hourOfExam == 0)
            {
                examInMinutes = minuteOfExam;
                ariavalInMinutes = minuteAfArival;
            }
            if (examInMinutes-ariavalInMinutes<=30 && examInMinutes-ariavalInMinutes >=0)
            {
                if (examInMinutes==ariavalInMinutes)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{examInMinutes-ariavalInMinutes} minutes before the start");
                }
            }
            else if (examInMinutes-ariavalInMinutes>30)
            {
                hour = (examInMinutes - ariavalInMinutes)/60;
                minute = (examInMinutes - ariavalInMinutes) % 60;
                Console.WriteLine("Early");
                if (minute>=0 && minute <=9 && hour>0)
                {
                    Console.WriteLine($"{hour}:0{minute} hours before the start");
                }
                else if (minute >= 0 && minute <= 9 && hour<1)
                {
                    Console.WriteLine($"0{minute} minutes before the start");
                }
                else if (hour<1 && minute>=10)
                {
                    Console.WriteLine($"{minute} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute} hours before the start");
                }
            }
            else
            {
                hour = (ariavalInMinutes - examInMinutes) / 60;
                minute = (ariavalInMinutes - examInMinutes) % 60;
                Console.WriteLine("Late");
                if (minute>0 && hour<1)
                {
                    Console.WriteLine($"{minute} minutes after the start");
                }
                else if (minute >= 0 && minute <= 9 && hour > 0)
                {
                    Console.WriteLine($"{hour}:0{minute} hours after the start");
                }
                else if (minute >= 0 && minute <= 9 && hour <1)
                {
                    Console.WriteLine($"0{minute} minutes after the start");
                }
                else if (hour < 1 && minute >= 10)
                {
                    Console.WriteLine($"{minute} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute} hours after the start");
                }
            }
        }
    }
}
