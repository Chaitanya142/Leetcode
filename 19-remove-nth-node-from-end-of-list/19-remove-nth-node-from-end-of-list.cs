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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode ptr = head;
        ListNode ctr = null;
        int nodeCt = 0;
        while (ptr != null)
        {
            ptr = ptr.next;
            nodeCt++;

            if (nodeCt == n && ptr != null)
            {
                //Console.WriteLine(ptr.val);
                ctr = head;
            }
            else if (nodeCt > n && ptr != null)
            {
                //Console.WriteLine(ptr.val);
                ctr = ctr.next;
            }
            else if (nodeCt == n && ptr == null)
            {
                return head.next;
            }


        }
        //Console.WriteLine(ctr.val);
        if (ctr == null)
            return ctr;
        else
        {
            ctr.next = ctr.next.next;
        }
        return head;
    }
}