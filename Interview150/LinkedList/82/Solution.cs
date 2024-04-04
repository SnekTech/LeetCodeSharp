using Interview150.common;

namespace Interview150.LinkedList._82;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var dummy = new ListNode(-101, head);
        var prev = dummy;
        var p = head;
        int sameVal = -1;

        while (p != null)
        {
            if (p.next == null)
            {
                break;
            }

            sameVal = p.val;
            if (p.val == p.next.val)
            {
                while (p != null && p.val == sameVal)
                {
                    p = p.next;
                }

                prev.next = p;
            }
            else
            {
                prev = p;
                p = p.next;
            }
        }

        return dummy.next;
    }
}