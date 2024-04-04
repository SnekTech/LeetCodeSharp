using Interview150.common;

namespace Interview150.BinaryTree._129;

public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return Dfs(root, 0);
    }

    private int Dfs(TreeNode root, int prevSum)
    {
        if (root == null)
            return 0;

        var sum = prevSum * 10 + root.val;
        if (root.left == null && root.right == null)
        {
            return sum;
        }

        return Dfs(root.left, sum) + Dfs(root.right, sum);
    }
}