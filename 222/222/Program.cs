namespace Solution222
{
    public class Example
    {
        static void Main()
        {
            TreeNode fourthNode = new TreeNode(4);
            TreeNode fifthNode = new TreeNode(5);
            TreeNode sixthNode = new TreeNode(6);
            TreeNode thirdNode = new TreeNode(3, sixthNode);
            TreeNode secondNode = new TreeNode(2, fourthNode, fifthNode);
            TreeNode firstNode = new TreeNode(1, secondNode, thirdNode);
            Solution solution = new Solution();
            var first = solution.CountNodes(firstNode);
            Console.WriteLine(first);
        }
    }
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int rightResult = 0;
        if (root.right != null)
        {
            rightResult = CountNodes(root.right);
        }
        int leftResult = 0;
        if (root.left != null)
        {
            leftResult = CountNodes(root.left);
        }
        return 1 + leftResult + rightResult;
    }
}
}
