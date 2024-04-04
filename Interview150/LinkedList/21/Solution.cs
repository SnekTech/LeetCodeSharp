using Interview150.common;

namespace Interview150.LinkedList._21;

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode p1 = list1, p2 = list2;
        ListNode dummy = new(), prev = dummy;

        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                prev.next = p1;
                p1 = p1.next;
            }
            else
            {
                prev.next = p2;
                p2 = p2.next;
            }

            prev = prev.next;
        }

        if (p1 == null && p2 == null)
        {
            return dummy.next;
        }
        else if (p1 != null)
        {
            prev.next = p1;
        }
        else
        {
            prev.next = p2;
        }

        return dummy.next;
    }
}