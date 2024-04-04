using Interview150.common;

namespace Interview150.BinaryTree._105;

public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0)
            return null;

        var rootVal = preorder[0];
        var rootIndex = Array.IndexOf(inorder, rootVal);
        var leftLength = rootIndex;
        
        var leftPreorder = preorder[1..(1 + leftLength)];
        var leftInorder = inorder[..rootIndex];
        var rightPreorder = preorder[(1 + leftLength)..];
        var rightInorder = inorder[(rootIndex + 1)..];

        var leftTree = BuildTree(leftPreorder, leftInorder);
        var rightTree = BuildTree(rightPreorder, rightInorder);

        var root = new TreeNode(rootVal, leftTree, rightTree);
        return root;
    }
}