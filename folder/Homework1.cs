using System;

namespace Homework1
{
    class Homework1
    {
        static void Main(string[] args)
        {
            double e;
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double ElMax = Math.Pow(x, 3);
            double ElMin = x;
            if (x * y > 3)
            {
                if (ElMax < Math.Pow(Math.Log(x * y), c * d))
                {
                    ElMax = (Math.Pow(Math.Log(x * y), c * d));
                }
            }
            if (x * y <= 3 && 0 <= x * y)
            {
                if (3 * ElMin > y)
                {
                    ElMin = y;
                }
                if (3 * ElMin > ElMax)
                {
                    e = ElMax = ElMin;
                    Console.WriteLine(e);
                }
                if (ElMax > c * x)
                {
                    e = ElMax = c * x;
                    Console.WriteLine(e);
                }
            }
            if (x * y < 0)
            {
                e = Math.Pow(2, c * d) - x;
                Console.WriteLine(e);
            }
        }
    }
}
