using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_Connection;

namespace Module_09
{
    class Assignment
    {
        int nodes;
        List<int>[] graph;

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph= new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();

            }
        }

        public void AddEdge(int node1,int node2)
        {
            graph[node1].Add(node2);
        }

        //public override string ToString()
        //{
        //    string s = "";
        //    for (int i = 0; i < nodes; i++)
        //    {
        //        s += i + " --> " + String.Join(" ", graph[i]) + "\n";
        //    }
        //    return s;
        //}

        public string Connection(int start)
        {
            string result = "";

            Stack<int> stack = new Stack<int>();
            stack.Push(start);
            List<int> visited = new List<int>();
            visited.Add(start);

            while (stack.Count != 0)
            {
                int node = stack.Pop();
                if (!visited.Contains(node))
                {
                    //stack.Push(node);
                    visited.Add(node);
                }
                foreach (var next in graph[node])
                {
                    if (!visited.Contains(next))
                    {
                        stack.Push(next);
                        //visited.Add(next);
                    }
                }

               
            }
            if (visited.Last() == nodes - 1) result = "connected";
            else result = "not connected";

            return result;

        }

    }
}
