using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class TheJet:Player
    {

        public TheJet(string name) : base(name) { }

        public override int ThrowMove(int extra)
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }
    }
}
