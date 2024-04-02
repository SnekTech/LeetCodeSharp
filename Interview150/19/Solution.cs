using Interview150._2;

namespace Interview150._19;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(-1, head);
        var prev = dummy;
        var end = head;
        for (int i = 0; i < n; i++)
        {
            end = end.next;
        }

        while (end != null)
        {
            prev = prev.next;
            end = end.next;
        }

        prev.next = prev.next.next;

        return dummy.next;
    }
}