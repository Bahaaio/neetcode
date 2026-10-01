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
        int len = 0;
        for (var curr = head; curr is not null; curr = curr.next) len++;

        if(len == n) return head.next;

        n = len - n;

        var cur = head;
        for (; --n > 0; cur = cur.next);

        cur.next = cur.next.next;

        return head;
    }
}
