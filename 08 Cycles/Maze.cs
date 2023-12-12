using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cycles
{
    class Maze
    {
        int node;
        List<int>[] graph;

        public Maze(int nodes)
        {
            this.node = nodes;
            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1,int node2 )
        {
            graph[node1].Add(node2);
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < node; i++)
            {
                s += i + "--> " + string.Join(" ", graph[i]) + "\n";
            }
            return s;
            
        }

        public string cyclic(int start )
        {
            string result = "acyclic";
            Queue<int> queue = new Queue<int>();    
            queue.Enqueue(start);
            List<int> visited = new List<int>();
            visited.Add(start);

            while (queue.Count != 0)
            {
                int node = queue.Dequeue();

                foreach (int item in graph[node])
                {

                    if (!visited.Contains(item))
                    {
                        visited.Add(item);
                        queue.Enqueue(item);
                        
                    }
                    if (item == start)
                    {
                        result= "cyclic";
                        break;
                    }

                }
            }
            Console.WriteLine(string.Join("--> ",visited));
            return result;
        }
    }
}
