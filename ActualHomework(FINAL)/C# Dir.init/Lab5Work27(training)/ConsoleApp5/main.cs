using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork5Var27
{
    internal class program
    {
        static void Main(string[] args)
        {
            // подключение класса branching (branching() - конструктор)
            // Obj - переменная обращения к классу branching
            // с помощью неё происходит запрос к public данным
            branching Obj = new branching();

            Console.WriteLine("введите с: ");
            Obj.c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y: ");
            Obj.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите x: ");
            Obj.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите z: ");
            Obj.z = Convert.ToDouble(Console.ReadLine());


            Obj.l = Obj.systemSolution(Obj.c, Obj.y, Obj.x, Obj.z);

            Console.Clear();

            Console.WriteLine("При c = " + Obj.c + " при y = " + Obj.y + " при x = " + Obj.x + "при z = " + Obj.z);
            Console.WriteLine("Система принимает результат: " + Obj.l);

            Console.ReadLine();
        }
    }
}
