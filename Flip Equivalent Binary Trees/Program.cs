Solution s = new Solution();
TreeNode root1 = new TreeNode(1);
root1.left= new TreeNode(2);
root1.right= new TreeNode(3);
root1.left.left = new TreeNode(4);
root1.left.right = new TreeNode(5);

root1.right.left = new TreeNode(6);

root1.left.right.left = new TreeNode(7);
root1.left.right.right = new TreeNode(8);


TreeNode root2 = new TreeNode(1);
root2.right = new TreeNode(2);
root2.left = new TreeNode(3);
root2.right.left = new TreeNode(4);
root2.right.right = new TreeNode(5);

root2.left.right = new TreeNode(6);

root2.right.right.right = new TreeNode(7);
root2.right.right.left = new TreeNode(8);

var answer = s.FlipEquiv(root1, root2); 
Console.WriteLine(answer);  

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
  public bool FlipEquiv(TreeNode x, TreeNode y)
  {
    // base condition
    if (x == null && y == null) return true;
    if (x == null || y == null) return false;
    // if roots are not matching no point to proceed
    if (x.val != y.val) return false;

    var leftAndRightEqual = FlipEquiv(x?.left, y?.left) && FlipEquiv(x?.right, y?.right);
    var equal = leftAndRightEqual || FlipEquiv(x?.left, y?.right) && FlipEquiv(x?.right, y?.left);
    return equal;
  }
}