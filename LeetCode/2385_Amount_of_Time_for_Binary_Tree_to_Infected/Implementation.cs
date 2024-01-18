namespace LeetCode._2385_Amount_of_Time_for_Binary_Tree_to_Infected;

// https://leetcode.com/problems/amount-of-time-for-binary-tree-to-be-infected
public class Implementation
{
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

    public class GraphNode
    {
        public int val;
        public List<GraphNode> neighbors;

        public GraphNode(int _val)
        {
            neighbors = new();
            val = _val;
        }
    }

    public class Solution
    {
        private GraphNode _startNode;

        public int AmountOfTime(TreeNode root, int start)
        {
            if (root == null)
            {
                return 0;
            }

            var graphRoot = TransformTreeWhileSearch(root, null, start);

            var depth = GraphDepth(_startNode);

            return depth - 1;
        }

        public int GraphDepth(GraphNode graphNode)
        {
            if (graphNode == null)
            {
                return 0;
            }

            Queue<GraphNode> queue = new Queue<GraphNode>();
            HashSet<GraphNode> visited = new HashSet<GraphNode>();

            queue.Enqueue(graphNode);
            visited.Add(graphNode);

            int depth = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    GraphNode currentNode = queue.Dequeue();

                    foreach (GraphNode neighbor in currentNode.neighbors)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                            visited.Add(neighbor);
                        }
                    }
                }

                depth++;
            }

            return depth;
        }

        public GraphNode? TransformTreeWhileSearch(TreeNode? node, GraphNode? parentGNode, int searchVal)
        {
            if (node == null)
            {
                return null;
            }

            GraphNode newGNode = new GraphNode(node.val);
            var left = TransformTreeWhileSearch(node.left, newGNode, searchVal);
            if (left != null)
            {
                newGNode.neighbors.Add(left);
            }

            var right = TransformTreeWhileSearch(node.right, newGNode, searchVal);
            if (right != null)
            {
                newGNode.neighbors.Add(right);
            }

            if (parentGNode != null)
            {
                newGNode.neighbors.Add(parentGNode);
            }

            if (node.val == searchVal)
            {
                _startNode = newGNode;
            }

            return newGNode;
        }
    }
}