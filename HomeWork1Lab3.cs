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
            for (double p = -4; p <= 4; p += 0.5) // p - ШАГ, ОТРЕЗОК(??)
            {
                if (Math.Pow(p, 2) <= 0) // ошибочка??
                {
                    Math.Pow(p, 2);
                    y = p - 1;
                    Console.WriteLine(y);
                }
                if ((p > 0) && p <= 5)
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
            Console.WriteLine("--------------------------"); // выводится не так
            double x = 0;
            while (x >= 4)
            {
                if (Math.Pow(x, 2) <= 0) // ошибочка??
                {
                    y = Math.Pow(x, 2);
                    Console.WriteLine(y);
                }
                if ((x > 0) && x >= 5)
                {
                    y = Math.Cos(x);
                    Console.WriteLine(y);
                }
                if (x > 1.5)
                {
                    y = Math.Sin(x - 1);
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine("--------------------------"); // выводится не так

            do
            {
                if (Math.Pow(x, 2) <= 0) // ошибочка
                {
                    y = Math.Pow(x, 2);
                    Console.WriteLine(y);
                }
                if ((x > 0) && x >= 5)
                {
                    y = Math.Cos(x);
                    Console.WriteLine(y);
                }
                if (x > 1.5)
                {
                    y = Math.Sin(x - 1);
                    Console.WriteLine(y);
                }
            } while (x >= 4);
        }
    }
}