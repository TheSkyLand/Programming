namespace LaboratoryWork5Var27
{
    class branching
    {
        public double c, y, x, z, l;

        public double systemSolution(double c, double y, double x, double z) //public - значит можно обращаться из любой точки
        {
            double l = 15;

            if (y * z > 0 && x > 0)
            {
                double max = Math.Sqrt(x);

                if (max < x * y)
                {
                    max = c * y;
                }

                double min = y;

                if (min > max)
                {
                    min = max;
                }
                if (min > z)
                {
                    min = z;
                }

                l = min;
            }
            else if (y * z < 0 && x > 0)
            {
                double min = Math.Tan(x);

                if (min > Math.Pow(z, 3))
                {
                    min = Math.Pow(z, 3);
                }

                l = min;
            }
            return l;
        }
    }
}