using System;
using static System.Math;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, x, s, s2=0, s3=0, s1=0, sim, i, n;
            Console.WriteLine("input нижний предел");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input n");
            n = Convert.ToDouble(Console.ReadLine());
            b = Exp(1.0 / 3);
            x = a;
            h = (b - a) / 2 / n;
            for (i = 2; i <= 2 * n - 2; i += 2)
            {
                s1 += Sqrt(Pow(4-x*x,3));
                x += 2 * h;
            }
            s1 *= 2;
            x = a;
            for (i = 1; i <= 2 * n - 1; i += 2) 
            {
                s2 += Sqrt(Pow(4 - x * x, 3));
                x += 2 *h;
            }
            s2 *= 4;
            s = s1 + s2 + Sqrt(Pow(4 - a * a, 3)) + Sqrt(Pow(4 - b * b, 3));
            sim = (b - a) * s / (6 * n);
            s = 0;
            h = (b - a) / n;
            x = a;
            for (i = 1; i <= n - 1; i++) 
            {
                s3 += Sqrt(Pow(4 - x * x, 3));
                x += h;
            }
            s3 += (Sqrt(Pow(4 - a * a, 3)) + Sqrt(Pow(4 - b * b, 3))) / 2;
            s3 *= h;
            Console.WriteLine($"симпмона = {sim}");
            Console.WriteLine($"трапеции = {s3}");

        }
    }
}
