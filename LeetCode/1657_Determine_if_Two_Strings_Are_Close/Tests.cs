namespace LeetCode._1657_Determine_if_Two_Strings_Are_Close;

public class Tests
{
    [Test]
    public void Test1()
    {
        Implementation.Solution solution = new();
        Assert.IsTrue(solution.CloseStrings("abc", "bca"));
    }
    
    [Test]
    public void Test2()
    {
        Implementation.Solution solution = new();
        Assert.IsFalse(solution.CloseStrings("a", "aa"));
    }
    
    [Test]
    public void Test3()
    {
        Implementation.Solution solution = new();
        Assert.IsTrue(solution.CloseStrings("cabbba", "abbccc"));
    }
    
    [Test]
    public void Test4()
    {
        Implementation.Solution solution = new();
        Assert.IsFalse(solution.CloseStrings("cabbba", "aabbss"));
    }
}