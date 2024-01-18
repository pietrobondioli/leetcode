namespace LeetCode._1_Two_Sum;


// https://leetcode.com/problems/two-sum/
public class Implementation
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            return CheckSums(nums, 0, target);
        }

        private int[] CheckSums(int[] nums, int currIndex, int target)
        {
            int currNum = nums[currIndex];

            for (int i = currIndex + 1; i < nums.Length; i++)
            {
                int currSum = currNum + nums[i];
                if (currSum == target) {
                    return new int[] { currIndex, i };
                }
            }

            return CheckSums(nums, currIndex + 1, target);
        }
    }
}