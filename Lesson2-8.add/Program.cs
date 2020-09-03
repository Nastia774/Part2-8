using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8.add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату своего рождения в виде : дд/мм/гг");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day, 0, 0, 0);
            TimeSpan time = nextBirthday - today;

            Console.WriteLine($"До дня рождения осталось { time.Days } дней");

            Console.ReadKey();
        }
    }
}
