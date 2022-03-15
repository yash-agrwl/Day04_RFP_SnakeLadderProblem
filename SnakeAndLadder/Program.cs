using System;

namespace SnakeAndLadder
{
    internal class Program
    {

        const int Start = 0, End = 100;
        const int P1 = 1, P2 = 2;
        const int NoPlay = 0, Ladder = 1, Snake = 2;
        int Position = Start;
        static int Chance = P1;   

        static void Main()
        {
            Console.WriteLine("Welcome To Computation Of Snake And Ladder Problem\n");

            Program Player1 = new();
            Program Player2 = new();
            int count = 1;

            while (Player1.Position < End && Player2.Position < End)
            {
                switch (Chance)
                {
                    case P1:
                        Player1.Play();
                        Console.WriteLine($"Player1 Position after Die{count} is: " + Player1.Position);
                        break;
                    case P2:
                        Player2.Play();
                        Console.WriteLine($"Player2 Position after Die{count} is: " + Player2.Position);
                        break;
                    default:
                        break;
                }
                count++;
            }

            if (Player1.Position == End)
                Console.WriteLine("\nThe game is won by Player1");
            else
                Console.WriteLine("\nThe game is won by Player2");

            Console.WriteLine("\nAlso, Total number of Die played to win is: " + (count - 1));
        }

        public static int RollDie()
        {
            Random rand = new();
            int die = rand.Next(1, 7);
            return die;
        }

        public static int CheckOption()
        {
            Random rand = new();
            int option = rand.Next(0,3);
            return option;
        }

        public void Play()
        {
            int die = RollDie();
            int option = CheckOption();
            switch (option)
            {
                case Ladder:
                    if ((Position + die) <= 100)
                        Position += die;
                    break;
                case Snake:
                    if ((Position - die) >= 0)
                        Position -= die;
                    break;
                default:
                    break;
            }
            ChangeMove(option);
        }

        public static void ChangeMove(int option)
        {
            switch (Chance)
            {
                case P1 :
                    if(option != Ladder)
                        Chance = P2;
                    break;
                case P2 :
                    if (option != Ladder)
                        Chance = P1;
                    break;
                default :
                    break;
            }
        }
    }
}
