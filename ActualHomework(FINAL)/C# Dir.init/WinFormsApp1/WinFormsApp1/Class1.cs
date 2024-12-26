using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Class1
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
            set { k = value; }
        }
        //ПЕРЕМЕННАЯ СЧЁТЧИКА
        public int counter = 0;

        // переменная для количества элементов в матрице
        private int k;

        // переменная чтобы сохранить данные о среднем арифметическом
        public double srt;

        // переменная чтобы сохранить макс число
        public double[,] MaxA;

        //строчки
        private int m;

        //ряды
        private int n;

        //матрица
        private double[,] a;
        public void MeanElement()
        {
            double sum = 0;
            k = n * m;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += A[i, j];
                }
            }
            srt = sum / K;
        }
        public void MaxElement(TextBox TX)
        {
            
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] >= srt)
                    {
                        counter++;
                    }
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
            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    A[i, j] = rand.Next(-30, 30);
                }
            }
        }
        public void Output(ListBox LB)
        {
            LB.Items.Clear();
            for (int i = 0; i < M; i++)
            {
                string s = " ";
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] >= 10)
                        s += " " + A[i, j].ToString() + " ";
                    else if (A[i, j] > 0 && A[i, j] < 10)
                        s += " " + A[i, j].ToString() + " ";
                    else if (A[i, j] <= 0 && A[i, j] > -10)
                        s += " " + A[i, j].ToString() + " ";
                    else
                        s += A[i, j].ToString() + " ";
                }
                LB.Items.Add(s);
            }
        }
    }
}

