using System;
using static System.Math;
namespace eph_tasks_91_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());

            double sum91 = 0;
            double x91 = 1;
            for (int i = 1; i <= n; i++)
            {
                sum91 += x91 * x91;
                x91 = 0.5 * x91 - 4;
            }

            double sum92 = 0;
            double x92 = 0.5;
            for (int i = 1; i <= n; i++)
            {
                sum92 += x92;
                x92 = Tan(x92 + 2);
            }

            double product93 = 1;
            double x93 = 0.5;
            for (int i = 5; i <= n; i++)
            {
                product93 *= (x93 * x93 + x93);
                x93 = Tan(x93 + 2);
            }

            double sum94 = 0;
            double x94 = -4.2;
            for (int i = 0; i <= n; i++)
            {
                sum94 += (x94 * x94 - 2 * x94);
                x94 = 1 / Tan(x94 + 1);
            }

            // Calculate 95
            double sum95 = 0;
            double x95 = 1;
            for (int i = 0; i <= n; i++)
            {
                sum95 += (x95 * x95 - x95);
                x95 = Sin(x95 + 1);
            }

            double sum96 = 0;
            double x96 = 22;
            for (int i = 0; i <= n; i++)
            {
                sum96 += x96 * x96;
                x96 = x96 - 3.4;
            }

            double sum97 = 0;
            double x97 = 1;
            for (int i = 0; i <= 3 * n; i++)
            {
                sum97 += x97;
                x97 = 0.5 * x97 + 7;
            }

            Console.WriteLine($"Result of 91: {sum91}");
            Console.WriteLine($"Result of 92: {sum92}");
            Console.WriteLine($"Result of 93: {product93}");
            Console.WriteLine($"Result of 94: {sum94}");
            Console.WriteLine($"Result of 95: {sum95}");
            Console.WriteLine($"Result of 96: {sum96}");
            Console.WriteLine($"Result of 97: {sum97}");
        }
    }
}
