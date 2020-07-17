using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    public class EvenDigits
    {
        int[] tester = new int[5]
        {
            10,23,3423,4,12
        };
        /// <summary>
        /// Given an array nums of integers, return how many of them contain an even number of digits.
        /// Input: nums = [12,345,2,6,7896]
        /// Output: 2
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbers(int[] nums)
        {
            int evenCount = 0;
            for (int i = 0; i < tester.Length; i++)
            {
                int len = tester[i].ToString().Length;
                if (len % 2 == 0) evenCount++;
            }
            Console.WriteLine($"even digit number count: {evenCount}");
            return evenCount;
        }
    }
}
