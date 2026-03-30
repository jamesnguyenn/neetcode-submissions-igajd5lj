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
    public bool HasCycle(ListNode head) {
         ListNode s = head; ListNode f = head;
         while(f != null && f.next != null && f.next.next != null)
         {
            f = f.next.next;
            s = s.next;
            if(f.Equals(s)) return true;
         }
         return false;
    }
}
