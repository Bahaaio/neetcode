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
    private bool Valid(TreeNode root, int min = int.MinValue, int max = int.MaxValue) {
        if (root is null) return true;
        if (root.val > max) return false;
        if (root.val < min) return false;

        return Valid(root.left, min, root.val - 1) && Valid(root.right, root.val + 1, max);
    }

    public bool IsValidBST(TreeNode root) {
        return Valid(root.left, max: root.val - 1) && Valid(root.right, min: root.val + 1);
    }
}
