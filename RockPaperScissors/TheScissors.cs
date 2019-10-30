using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class TheScissors : Player
    {
        public TheScissors(string name) : base(name) { }
        public override int ThrowMove(int extra)
        {
            return (int)Roshambo.Scissors;
        }
    }
}
