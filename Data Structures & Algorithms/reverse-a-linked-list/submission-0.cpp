/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
   public:
    ListNode* reverseList(ListNode* head, ListNode* prev = nullptr) {
        if (!head) return head;

        if (head->next) {
            auto h = reverseList(head->next, head);
            head->next = prev;
            return h;
        } else {
            head->next = prev;
            return head;
        }
    }
};
