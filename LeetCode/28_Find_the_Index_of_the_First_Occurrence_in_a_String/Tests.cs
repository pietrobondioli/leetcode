namespace LeetCode._28_Find_the_Index_of_the_First_Occurrence_in_a_String;

public class Tests
{
    // 28. Find the Index of the First Occurrence in a String
    // Easy
    // Topics
    // Companies
    //
    // Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    //
    //  
    //
    // Example 1:
    //
    // Input: haystack = "sadbutsad", needle = "sad"
    // Output: 0
    // Explanation: "sad" occurs at index 0 and 6.
    // The first occurrence is at index 0, so we return 0.
    //
    // Example 2:
    //
    // Input: haystack = "leetcode", needle = "leeto"
    // Output: -1
    // Explanation: "leeto" did not occur in "leetcode", so we return -1.
    //
    //  
    //
    // Constraints:
    //
    // 1 <= haystack.length, needle.length <= 104
    // haystack and needle consist of only lowercase English characters.
    //
    [Test]
    public void Test1()
    {
        var solution = new Implementation.Solution();
        var result = solution.StrStr("sadbutsad", "sad");
        Assert.AreEqual(0, result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Implementation.Solution();
        var result = solution.StrStr("leetcode", "leeto");
        Assert.AreEqual(-1, result);
    }
    
    // haystack =
    // "aaa"
    // needle =
    // "aaaa"
    [Test]
    public void Test3()
    {
        var solution = new Implementation.Solution();
        var result = solution.StrStr("aaa", "aaaa");
        Assert.AreEqual(-1, result);
    }
    
    // haystack =
    // "mississippi"
    // needle =
    // "issip"
    [Test]
    public void Test4()
    {
        var solution = new Implementation.Solution();
        var result = solution.StrStr("mississippi", "issip");
        Assert.AreEqual(4, result);
    }
    
    // Input
    //     haystack =
    //         "abc"
    // needle =
    // "c"
    [Test]
    public void Test5()
    {
        var solution = new Implementation.Solution();
        var result = solution.StrStr("abc", "c");
        Assert.AreEqual(2, result);
    }
}