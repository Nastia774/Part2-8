using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8._3
{
    enum Post : uint
    {
        Director = 174,
        Security = 175,
        Manager = 176
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            bool bonus = accauntant.AskForBonus(Post.Security, 176);
            if (bonus == true)
                Console.WriteLine("Сотрудник заслуживает премию");
            else
                Console.WriteLine("Сотрудник не заслуживает премию");

            Console.ReadKey();
        }
    }
}
