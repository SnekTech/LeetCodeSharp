using Interview150.common;

namespace Interview150._114;

public class Solution
{
    public void Flatten(TreeNode root)
    {
        GetFlattened(root);
    }

    private (TreeNode head, TreeNode tail) GetFlattened(TreeNode root)
    {
        if (root == null)
            return (null, null);

        var (leftHead, leftTail) = GetFlattened(root.left);
        var (rightHead, rightTail) = GetFlattened(root.right);
        root.left = null;

        if (leftHead == null && rightHead == null)
            return (root, root);
        
        if (leftHead != null && rightHead != null)
        {
            root.right = leftHead;
            leftTail.right = rightHead;
            return (root, rightTail);
        }

        if (leftHead != null)
        {
            root.right = leftHead;
            return (root, leftTail);
        }

        // leftHead == null && rightHead != null
        root.right = rightHead;
        return (root, rightTail);
    }
}