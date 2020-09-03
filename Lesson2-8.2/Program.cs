using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер цвета которым выведется надпись: 1-Жолтый, 2-Красный, 3-Голубой, 4-Зеленый");
            int color = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите строку : ");
            string stroka = Console.ReadLine();
            StaticClass staticClass = new StaticClass();
            staticClass.Print(stroka, color);


            Console.ReadKey();
        }
    }
}
