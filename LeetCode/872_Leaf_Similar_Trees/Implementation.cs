namespace LeetCode._872_Leaf_Similar_Trees;

// https://leetcode.com/problems/leaf-similar-trees/
public class Implementation
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public class Solution {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            List<int> root1Leafs = new();
            List<int> root2Leafs = new();

            CollectLeafs(root1, root1Leafs.Add);
            CollectLeafs(root2, root2Leafs.Add);

            return CompareLeafs(root1Leafs, root2Leafs);
        }

        private void CollectLeafs(TreeNode root, Action<int> storeLeaf)
        {
            if (root == null) {
                return;
            }

            if (root.left == null && root.right == null) {
                storeLeaf(root.val);
            }

            CollectLeafs(root.left, storeLeaf);
            CollectLeafs(root.right, storeLeaf);
        }

        private bool CompareLeafs(List<int> leafs1, List<int> leafs2)
        {
            if (leafs1.Count != leafs2.Count)
            {
                return false;
            }

            for (int i = 0; i < leafs1.Count; i++) {
                if (leafs1[i] != leafs2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}