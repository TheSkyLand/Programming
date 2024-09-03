using System;

namespace Homework1
{
    class Homework2
    {
        static void Main(string[] args)
        {
            double z;
            double a = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double ElMin = (a * x);
            double ElMax = Math.Pow(x, 3);
            if (x * y < 0)
            {
                z = Math.Pow(1 - e, x * y + a * b);
            }
            if (x * y == 0)
            {
                z = b - ElMin;
                if (ElMin > y)
                {
                    z = ElMin = y;
                }
            }
            if (x * y < 0)
            {
                if (ElMax < Math.Pow(e, y))
                {
                    z = ElMax = Math.Pow(e, y);
                }
                if (ElMax < Math.Sqrt(Math.Log(Math.Pow(y, 2))))
                {
                    z = ElMax = Math.Sqrt(Math.Log(Math.Pow(y, 2)));
                }
            }
            Console.WriteLine("ГОЙДА");

        }
    }
}
