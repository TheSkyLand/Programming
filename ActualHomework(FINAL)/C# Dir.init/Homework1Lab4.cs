using System;

namespace ConsoleApp //Определяем имя для программы
{
    class Programm //Объявляем класс программы
    {
        static void Main(string[] args) //Создаём статичный пустой метод без обращения
        {
            Console.WriteLine("Введите радиус, чтобы узнать стороны правильных 10 угольника, 50 угольника и 100 угольника И Н УГОЛЬНИКА");
            double r = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());

            //Вычисление стороны правильного 10-ти угольника
            double a1 = Radius(10, r);
            Console.WriteLine(" Вычисление стороны правильного 10 угольника = " + a1);

            //Вычисление стороны правильного 50-ти угольника
            double a2 = Radius(50, r);
            Console.WriteLine(" Вычисление стороны правильного 50 угольника  = " + a2);

            //Вычисление стороны правильного 100 угольника
            double a3 = Radius(100, r);
            Console.WriteLine(" Вычисление стороны правильного 100 угольника = " + a3);

            Console.WriteLine("Вычисление стороны правильного n угольника, и его периметра");
            double a4 = Radius(n, r);
            Console.WriteLine("Вычисление стороны правильного n угольника = ", + a4);
            double p1 = Perimeter(n, r);
            Console.WriteLine("Вычисление стороны правильного n угольника, и его периметра", + p1);
        }
        static double Radius(double n, double r) //Функция в  которой определяем сторону n угольника
        {
            double a = 2 * r * Math.Sin(180 / n);
            Console.WriteLine(" СТОРОНА ПРАВИЛЬНОГО Н УГОЛЬНИКА " + a);
            return a;
        }
        static double Perimeter(double n, double a) //Функция в которой определяем периметр
        {
            double p = n * a;
            Console.WriteLine(" Периметр = " + p);
            return p;
        }
    }
}
