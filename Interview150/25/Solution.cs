using Interview150._2;
using Interview150.common;

namespace Interview150._25;

public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var dummy = new ListNode(-1, head);
        var prev = dummy;
        var begin = head;
        var end = head;

        while (true)
        {
            var shouldReverse = true;
            for (int i = 0; i < k; i++)
            {
                if (end == null)
                {
                    shouldReverse = false;
                    break;
                }

                end = end.next;
            }

            if (!shouldReverse)
            {
                prev.next = begin;
                break;
            }

            prev.next = Reverse(begin, end);
            prev = begin;
            begin = end;
        }

        return dummy.next;
    }

    private ListNode Reverse(ListNode head, ListNode end)
    {
        var dummy = new ListNode(-1);
        var p = head;
        while (p != end)
        {
            var nextP = p.next;
            p.next = dummy.next;
            dummy.next = p;
            p = nextP;
        }

        return dummy.next;
    }
}