public class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();
        List<TreeNode> result = new List<TreeNode>();
        Serialize(root, map, result);
        return result;
    }

    private string Serialize(TreeNode node, Dictionary<string, int> map, List<TreeNode> result)
    {
        if (node == null) return "#";
        string serial = $"{node.val},{Serialize(node.left, map, result)},{Serialize(node.right, map, result)}";

        if (map.ContainsKey(serial))
        {
            map[serial]++;
            if (map[serial] == 2) result.Add(node); // Add only the first duplicate
        }
        else
        {
            map[serial] = 1;
        }

        return serial;
    }
}
