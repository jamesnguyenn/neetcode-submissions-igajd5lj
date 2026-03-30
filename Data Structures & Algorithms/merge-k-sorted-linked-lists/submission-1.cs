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
        PriorityQueue<ListNode,int> minHeap = new();
        foreach(var item in lists)
        {
            if(item != null)minHeap.Enqueue(item,item.val);
        }
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        while(minHeap.Count > 0)
        {
            var node =minHeap.Dequeue();
            curr.next = node;
            curr = curr.next;

            if(node.next != null)
                minHeap.Enqueue(node.next, node.next.val);
        }
        return dummy.next;
    }
}
