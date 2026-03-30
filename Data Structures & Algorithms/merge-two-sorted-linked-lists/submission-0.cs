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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new ListNode(0);
        ListNode c = head;
        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val){
                c.next = list1;
                list1 = list1.next;
            }else{
                c.next = list2;
                list2 = list2.next;
            }
            c = c.next;
        }
        if(list1 == null && list2 != null){
            c.next = list2;
        }else if(list2 == null && list1 != null){
            c.next = list1;
        }
       return head.next;
    }
}