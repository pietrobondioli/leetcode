namespace LeetCode._21_Merge_Two_Sorted_Lists;

public class Tests
{
    // 21. Merge Two Sorted Lists
    // Easy
    // Topics
    // Companies
    //
    // You are given the heads of two sorted linked lists list1 and list2.
    //
    // Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
    //
    // Return the head of the merged linked list.
    //
    //  
    //
    // Example 1:
    //
    // Input: list1 = [1,2,4], list2 = [1,3,4]
    // Output: [1,1,2,3,4,4]
    //
    // Example 2:
    //
    // Input: list1 = [], list2 = []
    // Output: []
    //
    // Example 3:
    //
    // Input: list1 = [], list2 = [0]
    // Output: [0]
    //
    //  
    //
    // Constraints:
    //
    // The number of nodes in both lists is in the range [0, 50].
    // -100 <= Node.val <= 100
    // Both list1 and list2 are sorted in non-decreasing order.

    [Test]
    public void Test1()
    {
        Implementation.Solution solution = new();
        var result = solution.MergeTwoLists(new Implementation.ListNode(1, new Implementation.ListNode(2, new Implementation.ListNode(4))), new Implementation.ListNode(1, new Implementation.ListNode(3, new Implementation.ListNode(4))));
        Assert.AreEqual(1, result.val);
        Assert.AreEqual(1, result.next.val);
        Assert.AreEqual(2, result.next.next.val);
        Assert.AreEqual(3, result.next.next.next.val);
        Assert.AreEqual(4, result.next.next.next.next.val);
        Assert.AreEqual(4, result.next.next.next.next.next.val);
    }
    
    [Test]
    public void Test2()
    {
        Implementation.Solution solution = new();
        var result = solution.MergeTwoLists(null, null);
        Assert.AreEqual(null, result);
    }

    [Test]
    public void Test3()
    {
        Implementation.Solution solution = new();
        var result = solution.MergeTwoLists(null, new Implementation.ListNode(0));
        Assert.AreEqual(0, result.val);
    }
}