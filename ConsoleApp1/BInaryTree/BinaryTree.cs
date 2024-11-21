class Tree
{
    //Find Leaves of Binary Tree
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
public class TreeNode
{
    public int val; // The value of the node
    public TreeNode left; // Reference to the left child
    public TreeNode right; // Reference to the right child

    // Constructor to initialize the node
    public TreeNode(int value = 0, TreeNode leftChild = null, TreeNode rightChild = null)
    {
        val = value;
        left = leftChild;
        right = rightChild;
    }
}
