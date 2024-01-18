namespace LeetCode._138_Copy_List_with_Random_Pointer;

// https://leetcode.com/problems/copy-list-with-random-pointer/description/
public class Implementation
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            Dictionary<Node, Node> oldToNewMap = new();

            Node newHead = RecursiveCopyNode(head, oldToNewMap);

            AssignRandoms(head, newHead, oldToNewMap);

            return newHead;
        }

        private Node RecursiveCopyNode(Node originalNode, Dictionary<Node, Node> trackMap)
        {
            Node newNode = new Node(originalNode.val);
            if (originalNode.next != null)
            {
                newNode.next = RecursiveCopyNode(originalNode.next, trackMap);
            }
            trackMap.Add(originalNode, newNode);

            return newNode;
        }

        private void AssignRandoms(Node oldNode, Node newNode, Dictionary<Node, Node> trackMap)
        {
            if (oldNode == null || newNode == null)
            {
                return;
            }

            if (oldNode.random != null)
            {
                trackMap.TryGetValue(oldNode.random, out Node random);

                if (random != null)
                {
                    newNode.random = random;
                }
            }

            AssignRandoms(oldNode.next, newNode.next, trackMap);
        }
    }
}