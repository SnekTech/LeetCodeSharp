using Interview150.common;

namespace Interview150._100;

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == q)
            return true;
        if (p == null || q == null)
            return false;

        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}