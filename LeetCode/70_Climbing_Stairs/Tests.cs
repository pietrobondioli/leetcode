namespace LeetCode._70_Climbing_Stairs;

public class Tests
{
    // 70. Climbing Stairs
    // Easy
    // Topics
    // Companies
    // Hint
    //
    // You are climbing a staircase. It takes n steps to reach the top.
    //
    // Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    //
    //  
    //
    // Example 1:
    //
    // Input: n = 2
    // Output: 2
    // Explanation: There are two ways to climb to the top.
    // 1. 1 step + 1 step
    // 2. 2 steps
    //
    // Example 2:
    //
    // Input: n = 3
    // Output: 3
    // Explanation: There are three ways to climb to the top.
    // 1. 1 step + 1 step + 1 step
    // 2. 1 step + 2 steps
    // 3. 2 steps + 1 step
    //
    //  
    //
    // Constraints:
    //
    // 1 <= n <= 45
    //
    [Test]
    public void Test1()
    {
        var solution = new Implementation.Solution();
        var result = solution.ClimbStairs(2);
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Implementation.Solution();
        var result = solution.ClimbStairs(3);
        Assert.AreEqual(3, result);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Implementation.Solution();
        var result = solution.ClimbStairs(4);
        Assert.AreEqual(5, result);
    }
    
    // Last Executed Input
    //     Use Testcase
    //     n =
    //         44
    [Test]
    public void Test4()
    {
        var solution = new Implementation.Solution();
        var result = solution.ClimbStairs(44);
        Assert.AreEqual(1134903170, result);
    }
}