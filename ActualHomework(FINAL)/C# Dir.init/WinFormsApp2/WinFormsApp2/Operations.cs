using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Operations

    {
        public double[] a;
        public double[] b;
        public double S;
        public int n;



        public class enter:Operations
        {
            public double[] Input(TextBox textBox)
            {
                this.n = textBox.Lines.Count();

                double[] array = new double[n];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = double.Parse(textBox.Lines[i]);
                }
                return array;
            }   
            public void Output(ListBox LB, double[] array)
            {
                LB.Items.Clear();
                for (int i = 0; i < array.Length; i++)
                {
                    LB.Items.Add(array[i]);
                }

            }
        }
    }
}
