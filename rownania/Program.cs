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

            double delta = (b * b - 4 * a * c);

            if (delta >= 0)
            {
                delta = Math.Sqrt(delta);

                double x1 = (-b - delta) / 2 * a;
                double x2 = (-b + delta) / 2 * a;

                Console.WriteLine(x1);
                Console.WriteLine(x2);
            } else
            {
                Console.WriteLine("brak rozwiązań rzeczywistych");
            }


        }
    }
}
