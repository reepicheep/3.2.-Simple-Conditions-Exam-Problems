using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Harvest
{
    internal class Program
    {
        static void Main()
        {
            using System;


public class Program
        {
            public static void Main()
            {
                var vineyardArea = double.Parse(Console.ReadLine());
                var grapePerSquare = double.Parse(Console.ReadLine());
                var neededLiters = double.Parse(Console.ReadLine());
                var workers = int.Parse(Console.ReadLine());

                var harvestPerVine = (vineyardArea * grapePerSquare) * 0.4;
                var vine = harvestPerVine / 2.5;

                if (vine >= neededLiters)
                {
                    var vineLeft = vine - neededLiters;
                    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                    Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vineLeft), Math.Ceiling(vineLeft / workers));
                }
                else
                {
                    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededLiters - vine));
                }
            }
        }
    }
    }
}
