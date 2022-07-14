/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head) 
    {
        if(head == null) return false;
        ListNode fastP = head;
        ListNode slowP = head;
        while(fastP !=null && fastP.next!=null)
        {
            fastP = fastP.next.next;
            slowP = slowP.next;
            if(slowP == fastP)return true;            
        }
        return false;
        
        
    }
}