namespace LeetCode._21_Merge_Two_Sorted_Lists;

public class Implementation
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode currNode1 = list1;
            ListNode currNode2 = list2;

            ListNode head = default;
            ListNode lastPushedNode = default;

            while (currNode1 != null || currNode2 != null)
            {
                if (currNode1 == null)
                {
                    if(head == null)
                    {
                        head = currNode2;
                    }
                    else
                    {
                        lastPushedNode.next = currNode2;
                    }
                    lastPushedNode = currNode2;
                    currNode2 = currNode2.next;
                    continue;
                }

                if (currNode2 == null)
                {
                    if (head == null)
                    {
                        head = currNode1;
                    }
                    else
                    {
                        lastPushedNode.next = currNode1;
                    }
                    lastPushedNode = currNode1;
                    currNode1 = currNode1.next;
                    continue;
                }

                if (currNode1.val <= currNode2.val)
                {
                    if (head == null)
                    {
                        head = currNode1;
                    }
                    else
                    {
                        lastPushedNode.next = currNode1;
                    }
                    lastPushedNode = currNode1;
                    currNode1 = currNode1.next;
                }
                else
                {
                    if (head == null)
                    {
                        head = currNode2;
                    }
                    else
                    {
                        lastPushedNode.next = currNode2;
                    }
                    lastPushedNode = currNode2;
                    currNode2 = currNode2.next;
                }
            }

            return head;
        }
    }
}