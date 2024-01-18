namespace LeetCode._26_Remove_Duplicates_from_Sorted_Array;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Implementation
{
    public class Solution {
        public int RemoveDuplicates(int[] nums)
        {
            int uniqueNumsCount = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[uniqueNumsCount - 1] != nums[i])
                {
                    nums[uniqueNumsCount] = nums[i];
                    uniqueNumsCount++;
                }
            }

            return uniqueNumsCount;
        }
    }
}