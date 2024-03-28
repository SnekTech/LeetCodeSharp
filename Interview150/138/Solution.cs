namespace Interview150._138;

public class Solution {
    public Node CopyRandomList(Node head)
    {
        var originToReplicate = new Dictionary<Node, Node>();
        Node p = head, dummy = new Node(-1), prev = dummy;
        while (p != null)
        {
            var replicate = new Node(p.val);
            originToReplicate.Add(p, replicate);
            prev.next = replicate;
            prev = prev.next;
            p = p.next;
        }

        p = head;
        while (p != null)
        {
            var replicate = originToReplicate[p];
            replicate.random = p.random != null ? originToReplicate[p.random] : null;
            p = p.next;
        }

        return dummy.next;
    }
}