using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8.add2
{
    interface IDateProvider
    {
        int GetMonth();
    }
    class DateProvider : IDateProvider
    {
        public int GetMonth()
        {
            int month = DateTime.UtcNow.Month;
            return month;
        }
    }
}
