using System;

namespace SnakeAndLadder
{
    internal class Program
    {

        static int Start = 0;
        int Position = Start;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Computation Of Snake And Ladder Problem\n");
            Program Player1 = new Program();
            int die = Player1.RollDie();
        }

        public int RollDie()
        {
            Random rand = new Random();
            int die = rand.Next(1, 7);
            return die;
        }
    }
}
