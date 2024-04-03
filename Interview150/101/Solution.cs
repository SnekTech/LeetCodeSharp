using Interview150.common;

namespace Interview150._101;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
            return true;

        return IsSymmetric(root.left, root.right);
    }

    private bool IsSymmetric(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
            return true;
        if (root1 == null || root2 == null)
            return false;
        if (root1.val != root2.val)
            return false;

        return IsSymmetric(root1.left, root2.right) && IsSymmetric(root1.right, root2.left);
    }
}