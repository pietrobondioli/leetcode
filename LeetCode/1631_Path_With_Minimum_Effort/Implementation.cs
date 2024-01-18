namespace LeetCode._1631_Path_With_Minimum_Effort;

public class Implementation
{
    public class Solution {
        public int MinimumEffortPath(int[][] heights)
        {
            var min = CheckPathEffort(heights, 0, 0, heights.Length, heights[0].Length);

            return min;
        }

        private int CheckPathEffort(int[][] area, int currX, int currY, int destX, int destY)
        {
            if (area.Length == currX + 1)
            {
                return 0;
            }

            if (area[currX].Length == currY + 1)
            {
                return 0;
            }

            if (currX == destX && currY == destY)
            {
                return area[currX][currY];
            }

            var goRight = CheckPathEffort(area, currX + 1, currY, destX, destY);
            var goDown = CheckPathEffort(area, currX, currY + 1, destX, destY);
            var goLeft = CheckPathEffort(area, currX - 1, currY, destX, destY);
            var goUp = CheckPathEffort(area, currX, currY - 1, destX, destY);

            return area[currX][currY] + Math.Min(goRight, Math.Min(goDown, Math.Min(goLeft, goUp)));
        }
    }
}