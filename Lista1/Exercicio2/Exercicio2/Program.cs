using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days, months, years;
            Console.WriteLine("Please, inform your age in days: ");
            days = Convert.ToInt32(Console.ReadLine());

            years = days / 365;
            months = (days % 365) / 30;
            days = (days % 365) % 30;

            Console.WriteLine("You have " + years + " years, " + months + " months and " + days + " days!");
        }
    }
}
