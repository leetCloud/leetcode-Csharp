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
        
        ListNode dummy = new ListNode();

        ListNode tail = dummy;
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }
        if(l1 != null)
        {
            tail.next = l1;
            l1 = l1.next;
        }
        if(l2 !=null)
        {
            tail.next = l2;
            l2 = l2.next;
        }
        return dummy.next;
        
        
    }
}