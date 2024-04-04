using Interview150.common;

namespace Interview150.BinaryTree._106;

public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0)
            return null;

        var rootVal = postorder[^1];
        var rootIndex = Array.IndexOf(inorder, rootVal);
        var leftLength = rootIndex;

        var leftInorder = inorder[..rootIndex];
        var leftPostorder = postorder[..leftLength];
        var rightInorder = inorder[(rootIndex + 1)..];
        var rightPostorder = postorder[leftLength..^1];

        var leftTree = BuildTree(leftInorder, leftPostorder);
        var rightTree = BuildTree(rightInorder, rightPostorder);

        return new TreeNode(rootVal, leftTree, rightTree);
    }
}