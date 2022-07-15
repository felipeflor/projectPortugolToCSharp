using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds, minutes, hours;
            Console.WriteLine("Please, inform the seconds: ");
            seconds = (Convert.ToInt32(Console.ReadLine()));

            hours = seconds / 3600;
            minutes = (seconds % 3600) / 60;
            seconds = (seconds % 3600) % 60;

            Console.WriteLine("Duration the event will be " + hours +
                " hours " + minutes + " minutes " + "and " + seconds + " seconds");

        }
    }
}
