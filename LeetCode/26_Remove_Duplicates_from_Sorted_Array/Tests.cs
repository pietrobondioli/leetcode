namespace LeetCode._26_Remove_Duplicates_from_Sorted_Array;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var nums = new int[] {1, 1, 2};
        var expectedNums = new int[] {1, 2};
        
        Implementation.Solution solution = new Implementation.Solution();
        var k = solution.RemoveDuplicates(nums);
        
        Assert.AreEqual(2, k);
        Assert.AreEqual(expectedNums.Length, k);
        for (int i = 0; i < k; i++)
        {
            Assert.AreEqual(expectedNums[i], nums[i]);
        }
    }

    [Test]
    public void Test2()
    {
        var nums = new int[] {0,0,1,1,1,2,2,3,3,4};
        var expectedNums = new int[] {0,1,2,3,4};
        
        Implementation.Solution solution = new Implementation.Solution();
        var k = solution.RemoveDuplicates(nums);
        
        Assert.AreEqual(5, k);
        Assert.AreEqual(expectedNums.Length, k);
        for (int i = 0; i < k; i++)
        {
            Assert.AreEqual(expectedNums[i], nums[i]);
        }
    }
}