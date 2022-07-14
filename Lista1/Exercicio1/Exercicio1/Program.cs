using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years, months, days, result; 
            
            Console.WriteLine("Please, type your age:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type months: ");
            months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type days: ");
            days = Convert.ToInt32(Console.ReadLine());

            result = ((365 * years) + (months * 30) + days);

            Console.WriteLine("Your age in days are: " + result);
        }
    }
}
