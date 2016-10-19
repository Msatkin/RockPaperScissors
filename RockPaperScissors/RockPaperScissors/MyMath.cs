using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class MyMath
    {
        public int GetRandomInt(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }
    }
}
