namespace LeetCode._138_Copy_List_with_Random_Pointer;

public class Tests
{
    [Test]
    public void Test1()
    {
        Implementation.Node node1 = new Implementation.Node(1);
        Implementation.Node node2 = new Implementation.Node(2);
        Implementation.Node node3 = new Implementation.Node(3);
        Implementation.Node node4 = new Implementation.Node(4);
        Implementation.Node node5 = new Implementation.Node(5);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        node1.random = node3;
        node2.random = node1;
        node3.random = node5;

        Implementation.Solution solution = new Implementation.Solution();
        Implementation.Node newHead = solution.CopyRandomList(node1);
        
        Console.WriteLine("Done");
        
        // use nunit assertions
        Assert.AreEqual(1, newHead.val);
        Assert.AreEqual(2, newHead.next.val);
        Assert.AreEqual(3, newHead.next.next.val);
        Assert.AreEqual(4, newHead.next.next.next.val);
        Assert.AreEqual(5, newHead.next.next.next.next.val);
        
        Assert.AreEqual(3, newHead.random.val);
        Assert.AreEqual(1, newHead.next.random.val);
        Assert.AreEqual(5, newHead.next.next.random.val);
        Assert.IsNull(newHead.next.next.next.random);
        Assert.IsNull(newHead.next.next.next.next.random);
        
        Console.WriteLine("All tests passed.");
        Assert.Pass();
    }
    
    // The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of [val, random_index] where:
    //
    // val: an integer representing Node.val
    // random_index: the index of the node (range from 0 to n-1) that the random pointer points to, or null if it does not point to any node.
    //
    //     Your code will only be given the head of the original linked list.

    [Test]
    public void Test2()
    {
        // input: [[7,null],[13,0],[11,4],[10,2],[1,0]]
        // expected: [[7,null],[13,0],[11,4],[10,2],[1,0]]

        Implementation.Node node1 = new Implementation.Node(7);
        Implementation.Node node2 = new Implementation.Node(13);
        Implementation.Node node3 = new Implementation.Node(11);
        Implementation.Node node4 = new Implementation.Node(10);
        Implementation.Node node5 = new Implementation.Node(1);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        node1.random = null;
        node2.random = node1;
        node3.random = node5;
        node4.random = node3;
        node5.random = node1;

        Implementation.Solution solution = new Implementation.Solution();

        Implementation.Node newHead = solution.CopyRandomList(node1);

        Console.WriteLine("Done");

        // use nunit assertions
        Assert.AreEqual(7, newHead.val);
        Assert.AreEqual(13, newHead.next.val);
        Assert.AreEqual(11, newHead.next.next.val);
        Assert.AreEqual(10, newHead.next.next.next.val);
        Assert.AreEqual(1, newHead.next.next.next.next.val);

        Assert.IsNull(newHead.random);
        Assert.AreEqual(7, newHead.next.random.val);
        Assert.AreEqual(1, newHead.next.next.random.val);
        Assert.AreEqual(11, newHead.next.next.next.random.val);
        Assert.AreEqual(7, newHead.next.next.next.next.random.val);

        Console.WriteLine("All tests passed.");
        Assert.Pass();
    }
}