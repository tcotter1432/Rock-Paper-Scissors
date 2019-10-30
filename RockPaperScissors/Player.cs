using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }

        public Player(string name)
        {
            Name = name;
            Wins = 0;
        }

        public abstract int ThrowMove(int extra);
    }
}
