using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What... is your name??");
            string thePlayer = Console.ReadLine();
            RoshamboClass OurGame = new RoshamboClass(thePlayer);
            OurGame.Game();
        }
    }
}
