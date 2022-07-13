using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main()
        {
            int breakDays = int.Parse(Console.ReadLine());

            int norma = 30000;
            int workDays = 365 - breakDays;
            int timeIgra = workDays * 63 + breakDays * 127;
            int mins = Math.Abs(norma - timeIgra) % 60;
            int hours = Math.Abs(norma - timeIgra) / 60;

            if (timeIgra >= norma)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
            }
        }
    }
}
