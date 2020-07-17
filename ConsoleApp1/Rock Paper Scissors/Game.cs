using NPOI.HSSF.Record;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class Game
    {
        /// <summary>
        /// Our move
        /// </summary>
        private Move Move { get; set; }      
        
        /// <summary>
        /// Does the stuff
        /// </summary>
        public void Play()
        {
            while (PlayGame())
            {
                Move UserMove = GetMove();
                DukeItOut(UserMove);
            }
        }

        /// <summary>
        /// Rock, Paper, or Scissors?
        /// </summary>
        /// <returns></returns>
        private Move GetMove()
        {
            while (true)
            {
                PrintEmptyChar();
                Console.WriteLine("Rock, Paper, or Scissors?");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "rock":
                        Move = Move.Rock;
                        return Move;
                    case "paper":
                        Move = Move.Paper;
                        return Move;
                    case "scissors":
                        Move = Move.Scissors;
                        return Move;
                    default:
                        Console.WriteLine("Please enter 'rock', 'paper', or 'scissors'");
                        continue;
                }
            }
        }

        /// <summary>
        /// Finding out if they want to play (why wouldn't they?)
        /// </summary>
        /// <returns></returns>
        private bool PlayGame()
        {
            while (true)
            {
                Console.WriteLine("Wanna play?");
                string ans = Console.ReadLine();
                if (ans == "yes") return true;
                else if (ans == "no") return false;
                else Console.WriteLine("Please type 'yes' or 'no'");
            }
        }

        /// <summary>
        /// Get out the boxing gloves
        /// </summary>
        /// <param name="UserMove"></param>
        private void DukeItOut(Move UserMove)
        {
            Opponent op = new Opponent();
            TooMuchFreeTime bored = new TooMuchFreeTime();
            Move OpponentMove = op.GenerateMove();

            PrintEmptyChar();

            Console.WriteLine($"You chose {Move}");
            bored.PrintMove(Move);
            Console.WriteLine($"Opponent chose {OpponentMove}");
            bored.PrintMove(OpponentMove);

            switch (Move)
            {
                case Move.Rock:
                    if (OpponentMove == Move.Rock) Console.WriteLine("It's a tie!");
                    else if (OpponentMove == Move.Scissors) Console.WriteLine("You win! Give yourself a pat on the back.");
                    else if (OpponentMove == Move.Paper) Console.Write("You lose :-( better luck next time.");
                    PrintEmptyChar();
                    break;
                case Move.Paper:
                    if (OpponentMove == Move.Paper) Console.WriteLine("It's a tie!");
                    else if (OpponentMove == Move.Rock) Console.WriteLine("You win! Great work.");
                    else if (OpponentMove == Move.Scissors) Console.WriteLine("Uh oh!! You got beat by an IF statement!!");
                    PrintEmptyChar();
                    break;
                case Move.Scissors:
                    if (OpponentMove == Move.Scissors) Console.WriteLine("You both chose the same thing! What are the odds!! They're one in three. The odds are one in three.");
                    else if (OpponentMove == Move.Paper) Console.WriteLine("Incredible display of skill!");
                    else if (OpponentMove == Move.Rock) Console.WriteLine(@"You win some you lose some!  ¯\_(ツ)_/¯");
                    PrintEmptyChar();
                    break;
            }
        }

        /// <summary>
        /// Formatting
        /// </summary>
        void PrintEmptyChar() => Console.WriteLine(string.Empty);
    }
}
