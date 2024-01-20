namespace LeetCode._70_Climbing_Stairs;

public class Implementation
{
    public class Solution {
        public int ClimbStairs(int n)
        {
            int[] memo = new int[n + 1];
            Array.Fill(memo, -1);
            int possibleWays = ClimbStairsRecursive(n, 0, memo);

            return possibleWays;
        }

        private int ClimbStairsRecursive(int stairH, int currentH, int[] memo)
        {
            if (currentH > stairH)
            {
                return 0;
            }

            if (currentH == stairH)
            {
                return 1;
            }
            
            if(memo[currentH] > -1)
                return memo[currentH];

            memo[currentH] = ClimbStairsRecursive(stairH, currentH + 1, memo) + ClimbStairsRecursive(stairH, currentH + 2, memo);
            
            return memo[currentH];
        }
    }
}