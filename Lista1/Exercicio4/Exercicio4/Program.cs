using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, r, s;
            float d;

            Console.WriteLine("Type the value of A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the value of B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the value of C: ");
            c = Convert.ToInt32(Console.ReadLine());

            r = (a + b) * (a + b);
            s = (b + c) * (b + c);

            d = (r + s) / 2;
            Console.WriteLine(d);

        }
    }
}
