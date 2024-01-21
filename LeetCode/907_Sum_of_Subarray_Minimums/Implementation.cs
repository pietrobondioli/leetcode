namespace LeetCode._907_Sum_of_Subarray_Minimums;

public class Implementation
{
    public class Solution {
        public int SumSubarrayMins(int[] arr)
        {
            int MOD = 1000000007;
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j <= arr.Length; j++)
                {
                    var subArray = arr[i..j];
                    sum += subArray.Min();
                    sum %= MOD;
                }
            }

            return sum;
        }
    }
}