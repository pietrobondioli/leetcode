namespace LeetCode._746_Min_Cost_Climbing_Stairs;

public class Implementation
{
    public class Solution {
        public int MinCostClimbingStairs(int[] cost)
        {
            int[] memo = new int[cost.Length];
            Array.Fill(memo, -1);
            
            return Math.Min(MinCostRecursive(cost, 0, memo), MinCostRecursive(cost, 1, memo));
        }

        private int MinCostRecursive(int[] cost, int currI, int[] memo)
        {
            if (currI >= cost.Length)
            {
                return 0;
            }

            if (memo[currI] != -1)
            {
                return memo[currI];
            }
            
            memo[currI] = cost[currI] + Math.Min(MinCostRecursive(cost, currI + 1, memo), MinCostRecursive(cost, currI + 2, memo));

            return memo[currI];
        }
    }
}