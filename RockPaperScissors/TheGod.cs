using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class TheGod:Player
    {
        public TheGod(string name) : base(name) { }
        public override int ThrowMove(int extra)
        {
            //Rock(0) -> Scissors(2) -> Paper(1) -> Rock(0)
            if (extra + 1 == 3)
            {
                return 0;
            }
            return extra + 1;
        }
    }
}
