using Interview150.common;

namespace Interview150.LinkedList._141;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head)
    {
        var nodes = new HashSet<ListNode>();
        var p = head;

        while (p != null)
        {
            if (nodes.Contains(p))
            {
                return true;
            }

            nodes.Add(p);
            p = p.next;
        }

        return false;
    }
}