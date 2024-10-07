using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork1Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            for (double p = -4; p <= 4; p += 0.5)
            {
                if (Math.Pow(p, 2) - 1 <= 0)
                {
                    y = Math.Pow(p, 2) - 1;
                    Console.WriteLine(y);
                }
                if (0 < p && p <= 1.5)
                {
                    y = Math.Cos(p);
                    Console.WriteLine(y);
                }
                if (p > 1.5)
                {
                    y = Math.Sin(p - 1);
                    Console.WriteLine(y);
                }

            }
            Console.WriteLine("--------------------------");
            double x = -4;
            while (x <= 4)
            {
                if (Math.Pow(x, 2) - 1 <= 0)
                {
                    y = Math.Pow(x, 2) - 1;
                    Console.WriteLine(y);
                }

                x += 0.5;

                if (0 < x && x <= 1.5)
                {
                    y = Math.Cos(x);
                    Console.WriteLine(y);
                }

                x += 0.5;

                if (x > 1.5)
                {
                    y = Math.Sin(x - 1);
                    Console.WriteLine(y);
                }

                x += 0.5;
            }
            Console.WriteLine("--------------------------");



            do
            {
                if (Math.Pow(x, 2) - 1 <= 0)
                {
                    y = Math.Pow(x, 2) - 1;
                    Console.WriteLine(y);
                }

                x += 0.5;

                if (0 < x && x <= 1.5)
                {
                    y = Math.Cos(x);
                    Console.WriteLine(y);
                }

                x += 0.5;

                if (x > 1.5)
                {
                    y = Math.Sin(x - 1);
                    Console.WriteLine(y);
                }

                x += 0.5;

            } while (x <= 4);
        }
    }
}
