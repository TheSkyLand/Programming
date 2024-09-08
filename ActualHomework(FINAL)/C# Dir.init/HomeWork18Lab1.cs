using System;
using System.Reflection.Metadata.Ecma335;

namespace HomeWork18
{
    class HomeWork18
    {
        static void Main(string[] args)
        {
            double f;
            Console.WriteLine("y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            f = Math.PI / 3 + (Math.Log(Math.Pow(x, 3) / 3 * y) - x) + x * Math.Sin(Math.Pow(y, 2));
            Console.WriteLine("Result: " + f);
        }
    }
}