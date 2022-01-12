/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode lastL1Node = l1;
        ListNode lastL2Node = l2;
        ListNode currentNode;
        ListNode head;
        int current = 0;
        if (lastL1Node == null)
        {
            return lastL2Node;
        }
        if (lastL2Node == null)
        {
            return lastL1Node;
        }
        if (lastL1Node.val < lastL2Node.val)
        {
            currentNode = lastL1Node;
            current = 1;
        }
        else
        {
            currentNode = lastL2Node;
            current = 2;
        }
        head = currentNode;
        while (currentNode != null)//&& currentNode!=null   //lastL1Node != null && lastL2Node !=null
        {
            if (current == 1 && currentNode.next != null && currentNode.next.val > lastL2Node.val)
            {
                lastL1Node = currentNode.next;
                currentNode.next = lastL2Node;
                current = 2;
            }
            else if (current == 2 && currentNode.next != null && currentNode.next.val > lastL1Node.val)
            {
                lastL2Node = currentNode.next;
                currentNode.next = lastL1Node;
                current = 1;
            }
            else if (currentNode != null)
            {
                currentNode = currentNode.next;
                if (current == 1 && currentNode != null)
                {
                    lastL1Node = currentNode;
                }
                else if (currentNode != null)
                {
                    lastL2Node = currentNode;
                }
            }
        }

        if (current == 1 && lastL2Node != null)
        {
            lastL1Node.next = lastL2Node;
        }
        else if (current == 2 && lastL1Node != null)
        {
            lastL2Node.next = lastL1Node;
        }

        return head;
    }
}