using System;

namespace SnakeAndLadder
{
    internal class Program
    {

        const int Start = 0, End = 100;
        int Position = Start;
        const int NoPlay = 0, Ladder = 1, Snake = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Computation Of Snake And Ladder Problem\n");
            Program Player1 = new Program();
            int count = 1;
            while (Player1.Position < End)
            {
                int die = Player1.RollDie();
                int option = Player1.CheckOption();
                switch (option)
                {
                    case Ladder:
                        if((Player1.Position + die) <= 100)
                            Player1.Position += die;
                        break;
                    case Snake:                    
                        if((Player1.Position - die) >= 0)
                            Player1.Position -= die;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Position after Die{count} is: " + Player1.Position);
                count++;
            }
            Console.WriteLine("\nTotal number of Die played to win is: " + (count - 1));
        }

        public int RollDie()
        {
            Random rand = new Random();
            int die = rand.Next(1, 7);
            return die;
        }

        public int CheckOption()
        {
            Random rand = new Random();
            int option = rand.Next(0,3);
            return option;
        }
    }
}
