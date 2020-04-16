using System;

namespace rownania
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Wprowadź a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź c");
            c = Double.Parse(Console.ReadLine());

            double delta = Math.Sqrt(b * b - 4 * a * c);

            double x1 = (-b - delta) / 2 * a;
            double x2 = (-b + delta) / 2 * a;

            Console.WriteLine(x1);
            Console.WriteLine(x2);


        }
    }
}
