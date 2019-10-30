using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class TheRock:Player
    {

        public TheRock(string name):base(name) { }

        public override int ThrowMove(int extra)
        {
            return (int)Roshambo.Rock;
        }
    }
}
