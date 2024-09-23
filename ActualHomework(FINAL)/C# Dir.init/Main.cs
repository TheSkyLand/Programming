using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { -1.5, 0.1, 12, 0, -2.2, 0.5, -1, 0.3 };
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    double ElMin = x[i];
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    double ElMax = x[i];
                }
            }
        }
    }
}
