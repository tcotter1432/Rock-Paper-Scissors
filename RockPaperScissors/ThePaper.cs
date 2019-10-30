using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class ThePaper : Player
    {
        public ThePaper(string name) : base(name) { }

        public override int ThrowMove(int extra)
        {
            return (int)Roshambo.Paper;
        }
    }
}
