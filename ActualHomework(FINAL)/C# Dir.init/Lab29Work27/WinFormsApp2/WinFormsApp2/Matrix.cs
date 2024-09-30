using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Подключение для работы с Forms
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class Matrix
    {
        public double[] a;
        public double[] b;
        public double S;
        public int n;
        
        public double[] Input(TextBox TxBx)
        {
            this.n = TxBx.Lines.Count();
            a = new double[n];
            for (int i = 0; i < a.Length; i++) 
            { 
                a[i] = double.Parse(TxBx.Lines[i]); 
            }
            return b;

        }

        public void Output(ListBox LB, double[] array)
        {
            LB.Items.Clear();
            for(int i=0;i < array.Length; i++)
                LB.Items.Add(array[i]);
        }
    }
}
