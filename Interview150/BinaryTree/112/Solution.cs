using Interview150.common;

namespace Interview150.BinaryTree._112;

public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        if (root.left == null && root.right == null)
        {
            return root.val == targetSum;
        }

        targetSum -= root.val;
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
    }
}