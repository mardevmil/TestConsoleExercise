using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftTestPreparation.ExamplesJun2018
{
    class TreeNode
    {
        public int value;
        public TreeNode sibling; // Pointer to the next sibling, or NULL if next sibling does not exist 
        public TreeNode firstChild; // Pointer to the first child, or NULL if this is leaf
    }

    class Example02
    {
        public TreeNode GenerateTree(int m, int[] a)
        {
            TreeNode root = null;

            //TreeNode previous = null;
            //TreeNode previousOdd = null;
            //bool branching = false;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (root.value == 0)
            //    {
            //        root = new TreeNode();
            //        root.value = a[i];
            //        previous = root;
            //        continue;
            //    }

            //    var current = new TreeNode();
            //    current.value = a[i];
            //    if (previous.value % 2 == 0)
            //    {
            //        previous.sibling = current;
            //    }
            //    else
            //    {
            //        previousOdd = previous;
            //        previous.firstChild = current;                    
            //    }
            //    previous = current;
            //}

            return root;
        }
    }
}
