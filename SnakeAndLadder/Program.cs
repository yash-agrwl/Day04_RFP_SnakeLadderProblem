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
            while(Player1.Position < End)
            {
                int die = Player1.RollDie();
                int option = Player1.CheckOption();
                switch (option)
                {
                    case Ladder:
                        Player1.Position += die;
                        break;
                    case Snake:
                        Player1.Position -= die;
                        if(Player1.Position < 0)
                            Player1.Position = 0;
                        break;
                    default:
                        break;
                }
            }
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
