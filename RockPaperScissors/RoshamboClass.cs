using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RoshamboClass
    {
        static List<Player> thePlayers = new List<Player> { new TheJet("The Jet"), new TheRock("The Geologist"), new ThePaper("The Writer"), new TheScissors("The Tailor"), new TheGod("The Master") };
        static Player theAdversary;
        static List<int> playerWins = new List<int>();
        static int position;
        public static string PlayerName { get; set; }

        public RoshamboClass(string playerName)
        {
            PlayerName = playerName;
        }

        public void Game()
        {
            SetupScore();

            while (true)
            {
                SelectAdversary();

                while (true)
                {
                    Shoot();
                    Console.WriteLine("Do you wish to compete again? (y/n)");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        break;
                    }
                }
                Console.WriteLine("Do you wish to compete against another Advesary?");
                if (Console.ReadLine().ToLower() == "n")
                {
                    Console.WriteLine("Until the next time...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Very well...");
                }
            }
        }

        private static void Fight(int playerMove, int aiMove)
        {
            //Rock(0) -> Scissors(2) -> Paper(1) -> Rock(0)
            Console.WriteLine($"You have selected {Enum.GetName(typeof(Roshambo), playerMove)}, and your Adversary, {theAdversary.Name}, has selected {Enum.GetName(typeof(Roshambo), aiMove)}.");

            if (playerMove == aiMove)
            {
                Console.WriteLine("It is a draw. How boring.");
            }
            else if (playerMove == 0)
            {
                if (aiMove == 1)
                {
                    Console.WriteLine("YOU HAVE BEEN DEFEATED! MOST EXCELLENT!!!");
                    theAdversary.Wins++;
                }
                else if (aiMove == 2)
                {
                    Console.WriteLine("I guess you win. THIS TIME...");
                    playerWins[position]++;
                }
                else
                {
                    Console.WriteLine("This should never appear");
                }
            }
            else if (playerMove == 1)
            {
                if (aiMove == 0)
                {
                    Console.WriteLine("I guess you win. THIS TIME...");
                    playerWins[position]++;

                }
                else if (aiMove == 2)
                {
                    Console.WriteLine("YOU HAVE BEEN DEFEATED! MOST EXCELLENT!!!");
                    theAdversary.Wins++;
                }
                else
                {
                    Console.WriteLine("This should never appear");
                }
            }
            else if (playerMove == 2)
            {
                if (aiMove == 0)
                {
                    Console.WriteLine("Yout have been DEFEATED! MOST EXCELLENT!!!");
                    theAdversary.Wins++;
                }
                else if (aiMove == 1)
                {
                    Console.WriteLine("I guess you win. THIS TIME...");
                    playerWins[position]++;
                }
                else
                {
                    Console.WriteLine("This should never appear");
                }
            }
        }

        private static void PrintScore()
        {
            Console.WriteLine("Adversary:\tTheir Wins:\tYour Wins:");
            for (int i = 0; i < playerWins.Count; i++)
            {
                Console.WriteLine($"{thePlayers[i].Name}\t\t{thePlayers[i].Wins}\t\t{playerWins[i]}");
            }
            Console.WriteLine("For all the good it will do you...");
        }
        private static void SetupScore()
        {
            for (int i = 0; i < thePlayers.Count; i++)
            {
                playerWins.Add(0);
            }
        }
        private static void SelectAdversary()
        {
            PrintAdversaries();
            try
            {
                position = int.Parse(Console.ReadLine()) - 1;
                theAdversary = thePlayers[position];
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Blundering imbecile! There is no adversary with that identification! Try again!");
                    SelectAdversary();
                }
            }
        }
        private static void PrintAdversaries()
        {
            Console.WriteLine("Who... shall be your Adversary???");
            for (int i = 0; i < thePlayers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {thePlayers[i].Name}");
            }
        }

        private static void Shoot()
        {
            Console.Write("What... is your choice? Enter (r/p/s) or \"score\" to see the score. ");
            switch (Console.ReadLine().ToLower())
            {
                case "r":
                    Fight((int)Roshambo.Rock, theAdversary.ThrowMove((int)Roshambo.Rock));
                    break;
                case "p":
                    Fight((int)Roshambo.Paper, theAdversary.ThrowMove((int)Roshambo.Paper));
                    break;
                case "s":
                    Fight((int)Roshambo.Scissors, theAdversary.ThrowMove((int)Roshambo.Scissors));
                    break;
                case "score":
                    Console.WriteLine("You want to see the score? You care about seeing the...");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("*sigh* Very well, here's the score....");
                    PrintScore();
                    break;
                default:
                    Console.WriteLine($"You call that an input?! Try again, {PlayerName}, you incompetant nin-com-poop!");
                break;
            }
        }
    }
} 