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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        List<string> res = new List<string>();
        dfsSerialize(root, res);
        return string.Join(",",res);
    }

    private void dfsSerialize(TreeNode node, List<string> res)
    {
        if(node == null)
        {
            res.Add("N");
            return;
        }
        res.Add(node.val.ToString());
        dfsSerialize(node.left, res);
        dfsSerialize(node.right, res);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        int i = 0;
        string[] newData = data.Split(',');
        return dfsDeserizalize(newData, ref i);
    }

    private TreeNode dfsDeserizalize(string[] newData, ref int i)
    {
        if(newData[i] == "N")
        {
            i++;
            return null;
        }
        TreeNode node  = new TreeNode(Int32.Parse(newData[i]), null, null);
        i++;
        node.left = dfsDeserizalize(newData, ref i);
        node.right = dfsDeserizalize(newData, ref i);

        return node;
    }
}
