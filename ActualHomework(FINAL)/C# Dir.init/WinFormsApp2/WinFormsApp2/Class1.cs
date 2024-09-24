using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Class1
    {
        public double[] a;
        public double[] b;
        public double S;
        public int n;
        
        // функция вычисляющая количество четных элементов 
        protected double SumElement()
        {
            this.S = 0;
            for (int i = 0; i < this.a.Length; i++)
            {
                if (i % 2 == 1)
                {
                    S += a[i];
                }    
            }
            return this.S;
        }

        // функция вычисляющая количество пол. элементов
        private int NumberEl()
        {
            this.n = 0;
            for(int i = 0; i < this.a.Length;i++)
            {
                if (a[i] >= 0)
                    n++;
            }
            return this.n;                                                          
        }


        public double[] Input(TextBox textBox)
        // обращаемся к функции input которая берёт из бокса в котором мы вводим числа
        {
            // берём ранее созданную переменную n, теперь она отвечает за счёт строк в боксе
            this.n = textBox.Lines.Count();
            // создаём временную переменную array и взаимодействие с пер. n
            double[] array = new double[n];
            //переходим к дефолтному циклу для массива чтобы спарсить строки находящиеся в текстбоксе
            for (int i = 0; i < array.Length; i++)
            {
                // здесь берутся строки текстбокса
                array[i] = double.Parse(textBox.Lines[i]);
            }
            // возвращение переменной array, потом она удаляется
            return array;
        }
        // переходим к публичному методу output, который обращается к классу у которого теперь есть связь к LB и к массиву array, которая сохранена сейчас как obj.a
        public void Output(ListBox LB, double[] array) // 
        {
            // берётся листбокс, у которого присвоено LB, и очищается его содержимое
            LB.Items.Clear();
            // создали цикл который берёт каждый элемент массива отдельно, добавляет их построчно
            for (int i = 0; i < array.Length; i++)
            {
                LB.Items.Add(array[i]);
            }
        }
    }
}
