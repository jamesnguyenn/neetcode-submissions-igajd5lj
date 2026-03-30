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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length < 1) return null;
        ListNode result = lists[0];

        for(var i = 1; i < lists.Length; i++ )
        {
           result = this.MergeTwoSortedList(result, lists[i]);
        }
        return result;
    }

    private ListNode MergeTwoSortedList(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode curr = dummy;

        while(l1 != null  && l2 != null)
        {
                if(l1.val < l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
               
                }else{
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
        }
        if(l1 == null && l2 != null)
        {
            curr.next = l2;
        }else{
            curr.next = l1;
        }
        return dummy.next;
    }
}
