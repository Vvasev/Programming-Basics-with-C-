using System;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string maleOrFemale = Console.ReadLine();

            if (age<16)
            {
                if (maleOrFemale =="m")
                {
                    Console.WriteLine("Master");
                }
                else if (maleOrFemale == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (maleOrFemale =="m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (maleOrFemale == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
