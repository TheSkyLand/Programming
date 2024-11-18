using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented
{
    internal class Operation
    {
        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }
        public double[,] B
        {
            get { return b; }
            set { b = value; }
        }
        public double[,] M
        {
            get { return m; }
            set { m = value; }
        }
        public double[,] X
        {
            get { return x; }
            set { x = value; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }



        //
        private double[,] a;
        private double[,] b;
        private double[,] m;
        private double[,] x;
        //
        private int n;
        //
    }
     
    public class RandomMat : Operation
    {
        Random rnd = new Random();

        public double[,] ElRandom(ListBox LB)
        {
            double[,] array = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
                }
            }
            MatrixGap(array, LB);

            return array;
        }
        public void MatrixGap(double[,] array, ListBox LB)
        {
            LB.Items.Clear();
            for (int i = 0; i < N; i++)
            {
                string s = "";
                for (int j = 0; j < N; j++)
                {
                    s += array[i, j].ToString() + "  ";
                }
                LB.Items.Add(s);
            }
        }
    }
}