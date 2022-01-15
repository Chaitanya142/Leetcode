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
    public ListNode MergeKLists(ListNode[] lists)
    {

        if (lists != null
            && lists.Length > 0)
        {

            ListNode[] currentElementOfList = new ListNode[lists.Length];
            for (int i = 0; i < currentElementOfList.Length; i++)
            {
                currentElementOfList[i] = lists[i];
            }
            bool isProcComplete = false;
            ListNode head = null;
            ListNode currentNode = null;
            //int lastMinVal = Int32.MaxValue;
            int len = lists.Length;
            ListNode minNode = getLeastNode(currentElementOfList, ref len);
            if (minNode != null)
            {
                head = minNode;
                currentNode = minNode;
            }
            else
            {
                return null;
            }
            while (isProcComplete == false)
            {
                minNode = getLeastNode(currentElementOfList, ref len);
                currentNode.next = minNode;
                if (minNode == null)
                {
                    isProcComplete = true;
                }
                else
                    currentNode = minNode;

            }
            return head;
        }
        return null;
    }

    public ListNode getLeastNode(ListNode[] currentElementList, ref int length)
    {
        ListNode minNode = null;
        int lastMinVal = Int32.MaxValue;

        int listNo = 0;
        for (int i = 0; i < length; i++)
        {
            if (currentElementList[i] != null &&
                currentElementList[i].val <= lastMinVal)
            {
                lastMinVal = currentElementList[i].val;
                minNode = currentElementList[i];
                listNo = i;
            }
        }
        if (minNode != null)
            currentElementList[listNo] = currentElementList[listNo].next;
        return minNode;
    }
}