using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8.add2
{
    enum Season
    {
        Winter = 1,
        Spring,
        Summer,
        Autumn
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDateProvider dateProvider = new DateProvider();
            ISeasonFinder seasonFinder = new SeasonFinder();

            var season = seasonFinder.Find(dateProvider);

            Console.WriteLine(season);
            Console.ReadKey();
        }
    }
}
