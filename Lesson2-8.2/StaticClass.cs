using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8._2
{
    enum MyEnum : int
    {
        Yellow = 1,
        Red,
        Blue,
        Green
    }
    class StaticClass
    {

        public void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)MyEnum.Yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                case (int)MyEnum.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case (int)MyEnum.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case (int)MyEnum.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                default:
                    Console.WriteLine("Такого цвета нет. ");
                    break;
            }
            Console.WriteLine(stroka);
        }
    }
}
