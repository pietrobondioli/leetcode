namespace LeetCode.1608_Special_Array_With_X_Elements_Greater_Than_or_Equal_X;

public class Implementation
{
    public class Solution
    {
        public int SpecialArray(int[] nums)
        {
            int x = -1;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int possibleX = nums.Length - i;
                if (possibleX <= nums[i])
                {
                    if (i == 0 || possibleX > nums[i - 1])
                    {
                        x = possibleX;
                        break;
                    }
                }
            }

            return x;
        }
    }
}
