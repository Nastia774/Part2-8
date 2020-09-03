using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_8._3
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((uint)worker < hours)
            {
                return true;
            }
            return false;
        }
    }
}
