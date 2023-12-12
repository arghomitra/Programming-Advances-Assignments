using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Add_or_Delete
{
    public class BST
    {
        public Node Root { get; set; }
        public BST() 
        {
            Root = null;
        }

        public BST(int value)
        {
           
            Root = new Node(value);
            

        }

        public void Add(int value) 
        {

            if (Root==null)
            {
                Root = new Node(value);
            }

            else
            {
                Add(Root,value);
            }
        }

        public void Add(Node currentRoot,int value)
        {
            if (currentRoot.Value > value)
            {
                if (currentRoot.Left == null) currentRoot.Left = new Node(value);
                else
                {
                    Add(currentRoot.Left,value);
                }
            }
            else
            {
                if (currentRoot.Right == null) currentRoot.Right = new Node(value);

                else Add(currentRoot.Right, value);
            }
        }
        public void TraverseInOrder()
        {
            if (Root != null) TraverseInOrder(Root);
        }
        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.Write(node.Value + " ");
                TraverseInOrder(node.Right);
            }
        }

        public void DeleteNode(int value)
        {
            if ((Root.Left==null)&& (Root.Right==null)) Root.Value = null;
            if (Root.Value > value) Root.Right = null;
            if (Root.Value < value) Root.Left = null;

        }
        
    }
}
