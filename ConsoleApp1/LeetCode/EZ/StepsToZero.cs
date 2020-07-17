using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Given a non-negative integer num, return the number of steps to reduce it to zero. 
    /// If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
    /// </summary>
    public class StepsToZero
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;

            while(num != 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even;");
                    num /= 2;
                    Console.WriteLine($"divide by 2 and you get: {num} ");
                    steps++;
                }
                else
                {
                    Console.WriteLine($"{num} is odd;");
                    num -= 1;
                    Console.WriteLine($"subtract 1 and you get: {num}");
                    steps++;
                }
            }
            Console.WriteLine($"That took {steps} steps to get to zero.");
            return steps;
        }
    }
}
