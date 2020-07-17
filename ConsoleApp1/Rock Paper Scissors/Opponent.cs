using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Advanced machine AI
    /// </summary>
    public class Opponent
    {
        public Move OpponentMove { get; set; }

        public Move GenerateMove()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);

            switch (choice)
            {
                case 1:
                    OpponentMove = Move.Rock;
                    return OpponentMove;
                case 2:
                    OpponentMove = Move.Paper;
                    return OpponentMove;
                case 3:
                    OpponentMove = Move.Scissors;
                    return OpponentMove;
                default:
                    throw new Exception("Uh oh!");
            }
        }
    }
}
