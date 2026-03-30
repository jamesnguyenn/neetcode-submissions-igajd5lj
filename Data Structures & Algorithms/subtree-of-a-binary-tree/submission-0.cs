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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) return false;
        if (IsSameTree(root, subRoot)) return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    public bool IsSameTree(TreeNode curr, TreeNode subCurr){
        if(curr == null && subCurr == null) return true;
        if(curr == null || subCurr == null) return false;
        if(curr.val != subCurr.val) return false;

        var left=this.IsSameTree(curr.left,subCurr.left);
        var right =this.IsSameTree(curr.right,subCurr.right);
        return left && right;
    }
}