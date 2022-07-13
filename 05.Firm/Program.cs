using System;

namespace _05.Firm
{
    internal class


    {
        static void Main()
    {
        ushort hoursNeeded = ushort.Parse(Console.ReadLine());
        ushort amountOfDaysNeeded = ushort.Parse(Console.ReadLine());
        // byte employeesTotal = byte.Parse(Console.ReadLine());

        byte overtimeEmployees = byte.Parse(Console.ReadLine());

        double hours = (amountOfDaysNeeded - (amountOfDaysNeeded * 0.1)) * 8;
        double overTimeHours = overTimeEmployees * (2 * amountOfDaysNeeded);
        double sumHours = hours + overTimeHours;
        double hoursLeft = sumHours - hoursNeeded;

        if (sumHours >= hoursNeeded)
        {
            Console.WriteLine("Yes!{0} hours left.", Math.Floor(hoursLeft));
        }
        else if (sumHours < hoursNeeded)
        {
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(hoursNeeded - sumHours));
        }
    }
}
}
