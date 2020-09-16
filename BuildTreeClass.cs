using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLib
{
    public class BuildTreeClas
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            /*
             * 前序遍历 preorder = [3,9,20,15,7]
               中序遍历 inorder = [9,3,15,20,7]
               
            1、前序的第一个元素3是根节点，那么中序数组3前面的就是左子树（[9]），后面的就是右子树[20,15,7]
            2、右子树（[20,15,7]）前序的第一个元素20是当前右子树的根节点，中序数组20前面的是左子树[15]，后面的是右子树[7]
             */
            if (preorder.Length < 1)
            {
                return null;
            }

            TreeNode rootNode = new TreeNode(preorder[0]);
            rootNode.leftNode = null;
            rootNode.rightNode = null;
            if(preorder.Length == 1 && inorder.Length == 1) 
            {
                return rootNode;
            }
            
            int rootIndexInMid = 0;
            for (int i = 0; i < inorder.Length; i++) 
            {
                if(rootNode.val != inorder[i]) 
                {
                    rootIndexInMid++;
                }
                else 
                {
                    break;
                }
            }

            int[] tempLeftPreorder = new int[rootIndexInMid];
            int[] tempLeftInorder = new int[rootIndexInMid];
            int[] tempRightPreorder = new int[inorder.Length - rootIndexInMid - 1];
            int[] tempRightInorder = new int[inorder.Length - rootIndexInMid - 1];
            for (int i = 0; i < inorder.Length; i++)
            {
                if (i < rootIndexInMid)
                {
                    tempLeftPreorder[i] = preorder[i + 1];
                    tempLeftInorder[i] = inorder[i];
                }

                if (i > rootIndexInMid)
                {
                    tempRightPreorder[i - rootIndexInMid - 1] = preorder[i];
                    tempRightInorder[i - rootIndexInMid - 1] = inorder[i];
                }
            }

            rootNode.leftNode = BuildTree(tempLeftPreorder, tempLeftInorder);
            rootNode.rightNode = BuildTree(tempRightPreorder, tempRightInorder);

            //Array.Copy(preorder, tempLeftPreorder, 1, rootIndexInMid-1);
            //rootNode.leftNode = BuildTree(tempLeftPreorder, tempLeftInorder);
            //rootNode.rightNode = BuildTree(tempRightPreorder, tempRightInorder);

            return rootNode;
        }
    }

    public class TreeNode 
    {
        public int val;

        public TreeNode leftNode { get; set; }

        public TreeNode rightNode { get; set; }

        public TreeNode(int x) 
        {
            val = x; 
        }
    }
}
