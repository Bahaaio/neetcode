/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private bool IsSame(TreeNode root, TreeNode sub) {
        if (root is null && sub is null) return true;
        if (root is null || sub is null) return false;

        return root.val == sub.val 
            && IsSame(root.right, sub.right) 
            && IsSame(root.left, sub.left);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root is null) return false;

        return IsSame(root, subRoot)
            || IsSubtree(root.left, subRoot) 
            || IsSubtree(root.right, subRoot);
    }
}
