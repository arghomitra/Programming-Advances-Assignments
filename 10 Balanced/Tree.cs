using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Balanced
{
    public class Tree
    {
        public Node Root { get; set; }
        public Tree() 
        {
            Root = null;
        }
        public Tree(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null) Root = new Node(value);
            else Add(Root, value);
        }

        private void Add(Node root, int value)
        {
            if (root.Value > value)
            {
                if (root.Left == null)
                {
                    root.Left = new Node(value);
                }
                else
                {
                    Add(root.Left, value);
                }
            }
            else
            {

                if (root.Right == null)
                {
                    root.Right = new Node(value);
                }
                else Add(root.Right, value);
            }
        }

        public void Hight ()
    }
}
