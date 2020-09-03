using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8.add2
{
    interface ISeasonFinder
    {
        string Find(IDateProvider dateProvider);
    }
    class SeasonFinder : ISeasonFinder
    {
        public string Find(IDateProvider dateProvider)
        {
            string season;
            int month = dateProvider.GetMonth();
            if (month >= 3 && month <= 5)
            {
                season = Season.Spring.ToString();
                return season;
            }
            else if (month >= 6 && month <= 8)
            {
                season = Season.Summer.ToString();
                return season;
            }
            else if (month >= 9 && month <= 11)
            {
                season = Season.Autumn.ToString();
                return season;
            }
            else
            {
                season = Season.Winter.ToString();
                return season;
            }
        }
    }
}
