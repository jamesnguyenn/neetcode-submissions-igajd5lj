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
    public void ReorderList(ListNode head) {

        //Find Middle
        ListNode f = head;
        ListNode s = head;

        while(f != null && f.next != null && f.next.next != null){
            s = s.next;
            f = f.next.next;
        }
        ListNode second = ReverseLinkedList(s.next);
        s.next =null;
        ListNode first = head;
        
        while(second != null)
        {
            ListNode t1 = first.next;
            ListNode t2 = second.next;

            first.next = second;
            second.next = t1;

            first = t1;
            second = t2;
        }
    }

    public ListNode ReverseLinkedList(ListNode node)
    {
        ListNode prev = null;
        ListNode c = node;
        while(c != null)
        {
            ListNode temp = c.next;
            c.next = prev;
            prev = c;
            c = temp;
        }   
        return prev;
    }
}
