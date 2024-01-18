namespace LeetCode._2385_Amount_of_Time_for_Binary_Tree_to_Infected;

public class Tests
{
    [Test]
    public void Test1()
    {
        Implementation.TreeNode node1 = new Implementation.TreeNode(1);
        Implementation.TreeNode node2 = new Implementation.TreeNode(2);
        Implementation.TreeNode node3 = new Implementation.TreeNode(3);
        Implementation.TreeNode node4 = new Implementation.TreeNode(4);
        Implementation.TreeNode node5 = new Implementation.TreeNode(5);
        Implementation.TreeNode node6 = new Implementation.TreeNode(6);
        Implementation.TreeNode node9 = new Implementation.TreeNode(9);
        Implementation.TreeNode node10 = new Implementation.TreeNode(10);

        node1.left = node5;
        node1.right = node3;
        node3.left = node4;
        node3.right = node10;
        node5.left = node2;
        node5.right = node6;
        node6.left = node9;

        Implementation.Solution solution = new Implementation.Solution();
        var amountOfTime = solution.AmountOfTime(node1, 3);
        
        Assert.AreEqual(4, amountOfTime);
    }
    
    [Test]
    public void Test2()
    {
        Implementation.TreeNode node1 = new Implementation.TreeNode(1);
        Implementation.TreeNode node2 = new Implementation.TreeNode(2);
        Implementation.TreeNode node3 = new Implementation.TreeNode(3);
        Implementation.TreeNode node4 = new Implementation.TreeNode(4);
        Implementation.TreeNode node5 = new Implementation.TreeNode(5);

        node1.left = node2;
        node2.left = node3;
        node3.left = node4;
        node4.left = node5;

        Implementation.Solution solution = new Implementation.Solution();
        var amountOfTime = solution.AmountOfTime(node1, 1);
        
        Assert.AreEqual(4, amountOfTime);
    }
}