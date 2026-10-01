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
    private HashSet<ListNode> set = new();

    public bool HasCycle(ListNode head) {
        var cur = head;

        while (cur != null && cur.next != null) {
            if (set.Contains(cur.next)) return true;
            cur = cur.next;
            set.Add(cur);
        }

        return false;
    }
}
