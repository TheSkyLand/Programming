using System;
using System.Reflection.Metadata.Ecma335;

namespace HomeWork17
{
    class HomeWork17
    {
        static void Main(string[] args)
        {
            double u;
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double ElMin = x;
            double ElMin1 = x;
            double ElMax = Math.Pow(x, 2);
            if (z > 0 && x > 0)
            {
                if (Math.Log(x) * ElMin > z)
                {
                   u = ElMin = z;
                   Console.WriteLine(u);
                }
            }
            if (z < 0 && x < 0)
            {
                if (ElMax < Math.Pow(z, 2))
                {
                    ElMax = Math.Pow(z, 2);
                    u = ElMax;
                    Console.WriteLine(u);
                }
                if (ElMax < Math.Pow(-a, 2))
                {
                    ElMax = Math.Pow(-a, 2);
                    u = ElMax;
                    Console.WriteLine(u);
                }
                if (ElMin1 > z)
                {
                    ElMin1 = z;
                    u = ElMin1;
                    Console.WriteLine(u);
                }
                u = ElMin;
                Console.WriteLine(u);
            }
            else
            {
                u = x + z;
                Console.WriteLine(u);
            }
        }

    }
}
