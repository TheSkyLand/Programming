using System;

namespace ConsoleApp //Определяем имя для программы
{
    class Programm //Объявляем класс программы
    {
        static void Main(string[] args) //Создаём статичный пустой метод без обращения
        {
            double n;
            double p;
            double a;
            Console.WriteLine("Введите радиус, чтобы узнать стороны правильных 10 угольника, 50 угольника и 100 угольника И Н УГОЛЬНИКА");

            double r = Convert.ToDouble(Console.ReadLine());
            //Вычисление стороны правильного 10-ти угольника
            double a1 = 2 * r * Math.Sin(180 / 10);
            Console.WriteLine(" Вычисление стороны правильного 10 угольника = " + a1);
            //Вычисление стороны правильного 50-ти угольника
            double a2 = 2 * r * Math.Sin(180 / 50);
            Console.WriteLine(" Вычисление стороны правильного 50 угольника  = " + a2);
            //Вычисление стороны правильного 100 угольника
            double a3 = 2 * r * Math.Sin(180 / 100);
            Console.WriteLine(" Вычисление стороны правильного 100 угольника = " + a3);
            Radius(); //вызов функции радиус
            Perimeter(); //вызов функции периметр

            double Radius() //Функция в  которой определяем сторону n угольника
            {
                Console.WriteLine(" КОЛ-ВО СТОРОН Н УГОЛЬНИКА");
                n = Convert.ToInt32(Console.ReadLine());
                a = 2 * r * Math.Sin(180 / n);
                Console.WriteLine(" СТОРОНА ПРАВИЛЬНОГО Н УГОЛЬНИКА "+ a);
                return a;
            }

            double Perimeter() //Функция в которой определяем периметр
            {
                Console.WriteLine("ВВЕДИТЕ КОЛ-ВО СТОРОН Н УГОЛЬНИКА");
                n = Convert.ToInt32(Console.ReadLine());
                p = n * a;
                Console.WriteLine(" Периметр = "+ p);
                return p;
            }
        }
    }
}