using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.645_Set_Mismatch;

public class Implementation
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] countNums = new int[nums.Length + 1];
            Array.Fill(countNums, 0);
            int repeated = default;
            int missing = default;

            for (int i = 0; i < nums.Length; i++)
            {
                if (countNums[nums[i]] == 1)
                {
                    repeated = nums[i];
                    continue;
                }

                countNums[nums[i]] = 1;
            }

            for (int j = 1; j < countNums.Length; j++)
            {
                if (countNums[j] == 0)
                {
                    missing = j;
                    break;
                }
            }

            return new int[] { repeated, missing };
        }
    }
}
