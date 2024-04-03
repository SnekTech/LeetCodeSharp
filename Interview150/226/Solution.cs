using Interview150.common;

namespace Interview150._226;

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        var left = root.left;
        var right = root.right;
        root.left = InvertTree(right);
        root.right = InvertTree(left);

        return root;
    }
}