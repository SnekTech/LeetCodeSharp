namespace Interview150._117;

public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
            return null;

        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            Node last = null;
            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                if (last != null)
                {
                    last.next = node;
                }

                last = node;
            }
        }

        return root;
    }
}