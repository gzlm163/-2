public class BinaryTreeSorter
{
    public static void Sort(int[] targetArray)
    {
        if (targetArray.Length == 0)
        {
            return;
        }

        TreeNode root = new TreeNode(targetArray[0]);

        for (int elementIndex = 1; elementIndex < targetArray.Length; ++elementIndex)
        {
            InsertIntoTree(root, targetArray[elementIndex]);
        }

        int[] result = new int[targetArray.Length];
        InOrderTraversal(root, result, 0);

        for (int copyIndex = 0; copyIndex < result.Length; ++copyIndex)
        {
            targetArray[copyIndex] = result[copyIndex];
        }
    }

    private static void InsertIntoTree(TreeNode root, int value)
    {
        if (value < root.Value)
        {
            if (root.Left == null)
            {
                root.Left = new TreeNode(value);
            }
            else
            {
                InsertIntoTree(root.Left, value);
            }
        }
        else
        {
            if (root.Right == null)
            {
                root.Right = new TreeNode(value);
            }
            else
            {
                InsertIntoTree(root.Right, value);
            }
        }
    }

    private static int InOrderTraversal(TreeNode node, int[] resultArray, int currentIndex)
    {
        if (node == null)
        {
            return currentIndex;
        }

        currentIndex = InOrderTraversal(node.Left, resultArray, currentIndex);
        resultArray[currentIndex] = node.Value;
        currentIndex = currentIndex + 1;
        currentIndex = InOrderTraversal(node.Right, resultArray, currentIndex);

        return currentIndex;
    }
}