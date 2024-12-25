using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Class1
    {
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }
        //количество
        public int K
        {
            get { return k; }
            set { k = n * m; }
        }

        private int k;


        //переменная для суммы
        public double sum;

        //строчки
        private int m;

        //ряды
        private int n;

        //матрица
        private double[,] a;

        //переменная для количества
        

        //переменная для сохранения данных
        protected double[] MaxEl;
        public void MeanElement() 
        {

            MaxEl = new double[m];
            for (int i = 0; i < m; i++)
            {
                MaxEl = new double[n];
                for (int j = 0; j < n; j++)
                { 
                    sum += a[i, j];
                }
            }
        }
    }
    public class ResSup : Class1
    {
        public void InputZ()
        {
            A = new double[M, N];
            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rand.Next(-30, 30);
                }
            }
        }
        public void Output(ListBox LB)
        {
            LB.Items.Clear();
            for(int i = 0; i < M; i++)
            {
                string s = "";
                for(int j = 0; j < N; j++)
                {
                    if (A[i, j] >= 10)
                        s += " " + A[i, j].ToString() + "  ";
                    else if (A[i, j] > 0 && A[i, j] < 10)
                        s += "   " + A[i, j].ToString() + "  ";
                    else if (A[i, j] <= 0 && A[i, j] > -10)
                        s += "  " + A[i, j].ToString() + "  ";
                    else
                        s += A[i, j].ToString() + "  ";
                }
                LB.Items.Add(s);
            }
        }
    }
}
