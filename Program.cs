
using System;

class DiceRoll
{
    static void Main(string[] args)

    {
        Random random = new Random();
        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        Console.WriteLine("Dice 1: " + dice1);
        Console.WriteLine("Dice 2: " + dice2);

        if (dice1 > dice2)
        {
            Console.WriteLine("Dice 1 Wins");
        }
        else if (dice2 > dice1)
        {
            Console.WriteLine("dice 2 wins");

        }
        else
        {
            Console.WriteLine("draw");

        }

        Console.ReadLine();
    }
}


