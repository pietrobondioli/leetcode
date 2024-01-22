using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.1470_Shuffle_the_Array;

public class Implementation
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] shuffledArr = new int[2 * n];
            int currI = 0;

            for (int i = 0; i < n; i++)
            {
                shuffledArr[currI] = nums[i];
                shuffledArr[currI + 1] = nums[n + i];
                currI += 2;
            }

            return shuffledArr;
        }
    }
}
