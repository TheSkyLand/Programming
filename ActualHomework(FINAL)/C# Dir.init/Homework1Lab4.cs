using System;

namespace ConsoleApp //Определяем имя для программы
{
    class Programm //Объявляем класс программы
    {
        static void Main(string[] args) //Создаём статичный пустой метод без обращения
        {
            Console.WriteLine("Введите радиус, чтобы узнать стороны правильных 10 угольника, 50 угольника и 100 угольника И Н УГОЛЬНИКА");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество углов для вычисления периметра N угольника");
            double n = Convert.ToDouble(Console.ReadLine());

            //Вычисление стороны правильного 10-ти угольника
            double a1 = Perimeter(10, r);
            Console.WriteLine(" Вычисление стороны правильного 10 угольника = " + a1);

            //Вычисление стороны правильного 50-ти угольника
            double a2 = Perimeter(50, r);
            Console.WriteLine(" Вычисление стороны правильного 50 угольника  = " + a2);

            //Вычисление стороны правильного 100 угольника
            double a3 = Perimeter(100, r);
            Console.WriteLine(" Вычисление стороны правильного 100 угольника = " + a3);


            double p = Perimeter(n, r);
            Console.WriteLine("Perimetr = " +p);
        }
        static double Perimeter(double n, double r) //Функция в которой определяем периметр
        {
            double a = 2 * r * Math.Sin(180 / n); // нахождение правильной стороны
            double p = n * a; // Вычисление периметра
            return p;
        }
    }
}
