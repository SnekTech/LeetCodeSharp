namespace Interview150._2;

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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (l1 is { val: 0, next: null })
            return l2;

        if (l2 is { val: 0, next: null })
            return l1;

        ListNode? p1 = l1, p2 = l2;
        ListNode dummy = new(), prev = dummy;
        int carry = 0;

        while (p1 != null && p2 != null)
        {
            var sum = p1.val + p2.val + carry;
            
            prev.next = new ListNode(sum % 10);
            prev = prev.next;
            p1 = p1.next;
            p2 = p2.next;
            carry = sum > 9 ? 1 : 0;
        }

        if (p1 == null && p2 == null)
        {
            if (carry > 0)
            {
                prev.next = new ListNode(1);
                return dummy.next!;
            }
        }

        var p = p1 ?? p2;
        while (p != null)
        {
            if (carry == 0)
            {
                prev.next = p;
                return dummy.next!;
            }

            int sum = p.val + carry;
            carry = sum > 9 ? 1 : 0;
            prev.next = new ListNode(sum % 10);
            prev = prev.next;
            p = p.next;
        }

        if (carry > 0)
        {
            prev.next = new ListNode(1);
        }

        return dummy.next!;
    }
}