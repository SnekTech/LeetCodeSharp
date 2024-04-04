using Interview150.common;

namespace Interview150.LinkedList._61;

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (k == 0 || head == null || head.next == null)
        {
            return head;
        }

        var dummy = new ListNode(-1, head);
        var prev = dummy;
        var n = 0;
        while (prev.next != null)
        {
            n++;
            prev = prev.next;
        }

        // prev references tail now,

        var offset = n - k % n;
        if (offset == n) return head;
        
        // build circle
        prev.next = head;
        while (offset-- > 0)
        {
            prev = prev.next;
        }

        var newHead = prev.next;
        prev.next = null;
        return newHead;
    }
}