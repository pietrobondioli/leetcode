namespace LeetCode._1019_Next_Greater_Node_In_Linked_List;

public class Implementation
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public int[] NextLargerNodes(ListNode head)
        {
            int[] nextLargerNodeList = new int[0];
    
            int currNodeIndex = 0;
            ListNode currNode = head;
    
            while (currNode != null)
            {
                ListNode currNextNode = currNode.next;
    
                if (currNodeIndex >= nextLargerNodeList.Length)
                {
                    int[] _nextLargerNodeList = new int[nextLargerNodeList.Length + 1];
                    nextLargerNodeList.CopyTo(_nextLargerNodeList, 0);
                    nextLargerNodeList = _nextLargerNodeList;
                }
    
                if (currNextNode == null)
                {
                    nextLargerNodeList[currNodeIndex] = 0;
                    currNode = currNode.next;
                    currNodeIndex++;
                    continue;
                }
    
                while (currNextNode != null)
                {
                    if (currNextNode.val > currNode.val)
                    {
                        nextLargerNodeList[currNodeIndex] = currNextNode.val;
                        break;
                    }
    
                    currNextNode = currNextNode.next;
                    if (currNextNode == null)
                    {
                        nextLargerNodeList[currNodeIndex] = 0;
                    }
                }
    
                currNode = currNode.next;
                currNodeIndex++;
            }
    
            return nextLargerNodeList.ToArray();
        }
    }
}