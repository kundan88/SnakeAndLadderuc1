using System;

namespace Snake_A_Ladder
{
    class SnakeALadder
    {
        public const int player_position = 0;
        public const int snake = 2;
        public const int ladder = 1;
        public const int NoPlay = 0;
        static void Main(string[] args)
        {
            int Position = 0;
            Random random = new Random();
            int RollDice=random.Next(1,7);
            Random check = new Random();
            int NoPlaySnakeLadder=check.Next(0,2);
            switch(NoPlaySnakeLadder)
            {
                case NoPlay:
                    break;
                case  snake:
                    Position =- RollDice;
                    break;
                case ladder:
                    Position =+ RollDice;
                    break;
            }
            Console.WriteLine("welcome to SAL game");
            Console.WriteLine(player_position);
            Console.WriteLine(RollDice);
            Console.WriteLine(Position);
        }
    }
}