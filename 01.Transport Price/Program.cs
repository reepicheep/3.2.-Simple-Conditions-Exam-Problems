using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double tariff = 0;
            double total = 0;

            if (n >= 100)
            {
                tariff = 0.06;
                total = n * tariff;
            }
            else if (n >= 20)
            {
                tariff = 0.09;
                total = n * tariff;
            }
            else
            {
                if (dayOrNight == "day")
                {
                    tariff = 0.79;
                    total = n * tariff + 0.7;
                }
                else
                {
                    tariff = 0.9;
                    total = n * tariff + 0.7;
                }
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}
