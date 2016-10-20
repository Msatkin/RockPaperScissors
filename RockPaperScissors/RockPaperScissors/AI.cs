using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI : Player
    {
        MyMath math;
        public AI(string name)
        {
            this.name = name;
        }
        public override void GetChoice()
        {
            math = new MyMath();
            choice = math.GetRandomInt(0, 4);
        }
    }
}
