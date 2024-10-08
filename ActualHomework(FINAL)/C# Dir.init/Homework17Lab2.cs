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
           
            

            if (z > 0 && x > 0)
            {
                double ElMin = x;
                if (ElMin > z)
                {
                   ElMin = z;
                }
                u = Math.Log(x) * ElMin;
            } else if (z < 0 && x < 0)
            {
                double ElMin = x;
                if (ElMin > z)
                {
                    ElMin = z;
                }

                double ElMax = Math.Pow(z, 2) - Math.Pow(a, 2);

                if (ElMax < Math.Pow(x, 2))
                {
                    ElMax = Math.Pow(x, 2);

                }
                u = ElMin;

            }
            else
            {
                u = x + z;
            }


            Console.WriteLine(u);
        }

    }
}
