public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode();
        dummy.next =head;
        ListNode r = dummy, l  = dummy;
        while(n>0)
        {
            r= r.next;
            n--;
        }
        while(r.next != null)
        {
            r = r.next;
            l = l.next;
        }
        l.next  = l.next.next;
        return dummy.next;
    }
}