using System;

namespace _02.Pipes_In_Pool
{
    internal class Program
    {
        static void Main()
        {
            int volumePool = int.Parse(Console.ReadLine());
            int flowRateFirstTube = int.Parse(Console.ReadLine());
            int flowRateSecondTube = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());// double

            double volumeFirstTube = flowRateFirstTube * hoursMissing; // double
            double volumeSecondTube = flowRateSecondTube * hoursMissing; // double
            double howFullPool = volumeFirstTube + volumeSecondTube; // double

            double howFullPoolPer = Math.Truncate(howFullPool / volumePool * 100);

            double volumeFirstTubePer = Math.Truncate(volumeFirstTube / howFullPool * 100);
            double volumeSecondTubePer = Math.Truncate(volumeSecondTube / howFullPool * 100);

            if (volumePool >= howFullPool)
            {
                Console.WriteLine($"The pool is {howFullPoolPer}% full. Pipe 1: {volumeFirstTubePer}%. Pipe 2: {volumeSecondTubePer}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {Math.Abs(volumePool - howFullPool)} liters.");
            }
        }
    }
}
