using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    /// Return the array in the form[x1, y1, x2, y2, ..., xn, yn].
    /// e.g. INPUT: [2,5,1,3,4,7], n = 3
    /// OUTPUT: [2,3,5,4,1,7]
    /// </summary>
    public class Shuffle
    {
        int[] tester = new int[6]
        {
            2,5,1,3,4,7
        };

        public int[] ShuffleProblem(int[] nums, int n)
        {
            var array = new int[] { 1, 2, 3, 4, 5 }; 
            foreach (var item in nums)
            {
                Console.WriteLine($"before shuffle: {item}");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (i + n >= nums.Length || j + n >= nums.Length) break;
                    nums[i + 1] = nums[i + n];
                    nums[j] = nums[j + n];
                }
            }

            foreach (var item in nums)
            {
                Console.WriteLine($"after shuffle: {item}");
            }
            return nums;
        }
    }
}
