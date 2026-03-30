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

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);
        var f = dummy;
        var s = dummy;
        while(n > 0)
        {
            f = f.next;
            n--;
        }
      
        while(f.next != null)
        {
            s = s.next;
            f = f.next;
        }
        s.next =s.next.next;
        return dummy.next;
    }
}
