class tree
{
    public class Solution
    {
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            GetHeight(root, result);
            return result;
        }

        private int GetHeight(TreeNode node, List<IList<int>> result)
        {
            if (node == null) return -1;
            int leftHeight = GetHeight(node.left, result);
            int rightHeight = GetHeight(node.right, result);
            int currentHeight = Math.Max(leftHeight, rightHeight) + 1;

            if (result.Count == currentHeight)
            {
                result.Add(new List<int>());
            }

            result[currentHeight].Add(node.val);
            return currentHeight;
        }
    }

}