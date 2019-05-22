using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class Tree_bst
    {
        public class Node
        {
            public int data;
            public Node Left;
            public Node Right;
            public Node(int d)
            {
                data = d;
                Left = null;
                Right = null;
            }
        }
        public static Node CreateBST(Node root,int ele)
        {
            if (root == null)
                return new Node(ele);
            if (ele < root.data)
                root.Left = CreateBST(root.Left, ele);
            else if (ele > root.data)
                root.Right = CreateBST(root.Right, ele);
            return root;
        }
       

        public static void ListToTreePath(List<int> l,int? n1,int? n2)
        {
            if (l.Count == 0||!n1.HasValue||!n2.HasValue)
            {
                Console.WriteLine("List is empty or values to find path are not present");
                return;
            }

            Node root = new Node(l[0]);
            for(int i =1; i<l.Count; i++)
            {
                CreateBST(root, l[i]);
            }

        }


    }
}
