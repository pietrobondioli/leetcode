namespace LeetCode._1631_Path_With_Minimum_Effort;

public class Tests
{
    [Test]
    public void Test1()
    {
        var heights = new[]
        {
            new[] {1, 2, 2},
            new[] {3, 8, 2},
            new[] {5, 3, 5}
        };

        var solution = new Implementation.Solution();

        var result = solution.MinimumEffortPath(heights);

        Assert.AreEqual(2, result);
    }

    [Test]
    public void Test2()
    {
        var heights = new[]
        {
            new[] {1, 2, 3},
            new[] {3, 8, 4},
            new[] {5, 3, 5}
        };

        var solution = new Implementation.Solution();

        var result = solution.MinimumEffortPath(heights);

        Assert.AreEqual(1, result);
    }

    [Test]
    public void Test3()
    {
        var heights = new[]
        {
            new[] { 1, 2, 1, 1, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 1, 1, 2, 1 }
        };

        var solution = new Implementation.Solution();

        var result = solution.MinimumEffortPath(heights);

        Assert.AreEqual(0, result);
    }
}