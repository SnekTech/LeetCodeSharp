namespace Interview150._146;

public class LRUCache
{
    private class DLinkNode(int key = -1, int value = -1)
    {
        public DLinkNode prev = null;
        public DLinkNode next = null;
        public int key = key;
        public int val = value;
    }

    private Dictionary<int, DLinkNode> nodeByKey;
    private DLinkNode dummyHead;
    private DLinkNode dummyTail;
    private int size = 0;
    private readonly int capacity;

    public LRUCache(int capacity)
    {
        nodeByKey = new Dictionary<int, DLinkNode>(capacity);
        this.capacity = capacity;

        dummyHead = new DLinkNode();
        dummyTail = new DLinkNode();
        dummyHead.next = dummyTail;
        dummyTail.prev = dummyHead;
    }

    public int Get(int key)
    {
        if (!nodeByKey.ContainsKey(key))
        {
            return -1;
        }

        // find node by key,
        // then move the node to head
        var targetNode = nodeByKey[key];
        MoveToHead(targetNode);

        return targetNode.val;
    }

    public void Put(int key, int value)
    {
        if (nodeByKey.ContainsKey(key))
        {
            var node = nodeByKey[key];
            node.val = value;
            MoveToHead(node);
        }
        else
        {
            var newNode = new DLinkNode(key, value);
            nodeByKey[key] = newNode;
            AddToHead(newNode);
            size++;
            if (size > capacity)
            {
                var tail = RemoveTail();
                nodeByKey.Remove(tail.key);
                size--;
            }
        }
    }

    private void MoveToHead(DLinkNode node)
    {
        RemoveNode(node);
        AddToHead(node);
    }

    private void AddToHead(DLinkNode node)
    {
        node.prev = dummyHead;
        node.next = dummyHead.next;
        dummyHead.next.prev = node;
        dummyHead.next = node;
    }

    private void RemoveNode(DLinkNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    private DLinkNode RemoveTail()
    {
        var tail = dummyTail.prev;
        RemoveNode(tail);
        return tail;
    }
}