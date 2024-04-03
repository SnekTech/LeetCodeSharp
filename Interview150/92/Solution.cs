using Interview150._2;
using Interview150.common;

namespace Interview150._92;

public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var dummy = new ListNode(-1, head);
        var prevLeft = dummy;
        for (int i = 0; i < left - 1; i++)
        {
            prevLeft = prevLeft.next;
        }

        var tail = prevLeft;
        for (int i = 0; i < right - left + 1; i++)
        {
            tail = tail.next;
        }

        var p = prevLeft.next;
        prevLeft.next = tail.next;
        tail.next = null;

        while (p != null)
        {
            var nextP = p.next;
            p.next = prevLeft.next;
            prevLeft.next = p;
            p = nextP;
        }

        return dummy.next;
    }
}