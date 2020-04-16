using System;

namespace rownania
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 0, c = -25;
            double delta = Math.Sqrt(b * b - 4 * a * c);

            double x1 = (-b - delta) / 2 * a;
            double x2 = (-b + delta) / 2 * a;

            Console.WriteLine(x1);
            Console.WriteLine(x2);


        }
    }
}
