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
            double ElMax = Math.Pow(x, 2);
            if ((z > 0) && (x > 0))
            {
                if (ElMin > z)
                {
                    ElMin = z;
                }
                u = Math.Log(x) * ElMin;
                Console.WriteLine(u);
            }
            if ((z < 0) && (x < 0))
            {
                if (ElMax > Math.Pow(z, 2))
                {
                    ElMax = Math.Pow(z, 2);
                    if (ElMax < Math.Pow(-a, 2))
                    {
                        ElMax = Math.Pow(-a, 2);
                        u = ElMax;
                        Console.WriteLine(u);
                    }
                    ElMin = x;
                    if (ElMin > z)
                    {
                        ElMin = z;
                        u = ElMin;
                        Console.WriteLine(u);
                    }
                    else u = x + z;
                    Console.WriteLine(u);
                }

            }
        }
    }
}
