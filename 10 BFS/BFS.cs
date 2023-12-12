using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_10;

namespace Module_10
{
    public class BFS
    {
        public Node Root { get; set; }
        public BFS() 
        { 
            Root = null;
        }
        public BFS(int value)
        {
            Root = new Node(value);

        }


        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }

        }

        private void Add(Node node, int value)
        {
            if (node.Value>value)
            {
                
                if (node.Left==null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Add(node.Left, value);
                }
                

            }
            else if(node.Value<value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }

        }
        public string BratchFirstSearch()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            List<string> path = new List<string>();
            path.Add(Root.Value.ToString());
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();


                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    path.Add(node.Left.Value.ToString());
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    path.Add(node.Right.Value.ToString());
                }
            }

            return string.Join(" ", path);

        }

        
    }
}
