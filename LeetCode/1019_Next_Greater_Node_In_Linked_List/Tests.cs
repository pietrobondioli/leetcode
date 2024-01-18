namespace LeetCode._1019_Next_Greater_Node_In_Linked_List;

public class Tests
{
    // 1019. Next Greater Node In Linked List
    // Medium
    // Topics
    // Companies
    // Hint
    //
    // You are given the head of a linked list with n nodes.
    //
    // For each node in the list, find the value of the next greater node. That is, for each node, find the value of the first node that is next to it and has a strictly larger value than it.
    //
    // Return an integer array answer where answer[i] is the value of the next greater node of the ith node (1-indexed). If the ith node does not have a next greater node, set answer[i] = 0.
    // Example 1:
    //
    // Input: head = [2,1,5]
    // Output: [5,5,0]
    //
    // Example 2:
    //
    // Input: head = [2,7,4,3,5]
    // Output: [7,0,5,5,0]
    [Test]
    public void Test1()
    {
        Implementation.Solution solution = new();
        var result = solution.NextLargerNodes(new Implementation.ListNode(2, new Implementation.ListNode(1, new Implementation.ListNode(5))));
        Assert.AreEqual(5, result[0]);
        Assert.AreEqual(5, result[1]);
        Assert.AreEqual(0, result[2]);
    }
    
    [Test]
    public void Test2()
    {
        Implementation.Solution solution = new();
        var result = solution.NextLargerNodes(new Implementation.ListNode(2, new Implementation.ListNode(7, new Implementation.ListNode(4, new Implementation.ListNode(3, new Implementation.ListNode(5))))));
        Assert.AreEqual(7, result[0]);
        Assert.AreEqual(0, result[1]);
        Assert.AreEqual(5, result[2]);
        Assert.AreEqual(5, result[3]);
        Assert.AreEqual(0, result[4]);
    }
}