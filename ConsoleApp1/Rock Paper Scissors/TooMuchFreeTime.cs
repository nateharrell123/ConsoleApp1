using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Self explanatory  ¯\_(ツ)_/¯
    /// </summary>
    public class TooMuchFreeTime
    {
        public void PrintMove(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    PrintRock();
                    break;
                case Move.Scissors:
                    PrintScissors();
                    break;
                case Move.Paper:
                    PrintPaper();
                    break;
            }
        }
        public void PrintRock() => Console.WriteLine(@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");

        public void PrintPaper() => Console.WriteLine(@"    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)");

        public void PrintScissors() => Console.WriteLine(@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
    }
}
