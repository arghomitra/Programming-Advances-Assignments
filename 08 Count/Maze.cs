using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Count
{
    class Maze
    {
        int nodes;
        List<int>[] graph;

        public Maze(int nodes)
        {
            this .nodes = nodes;
            graph= new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i]=new List<int>();
            }
            
        }

        public void AddEdge(int node1, int node2)
        {
            graph[node1].Add(node2);
            
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0;i < nodes;i++)
            {
                s +=i + " -- >"+ string.Join(" ", graph[i]) + "\n";
            }
            return s;
        }


        public int Count(int nodes)
        {
            int count = 0;
            List<int> visited = new List<int>();
            for (int i = 0; i < nodes; i++)
            {
                
                //stack.Push(i);

                //visited.Add(start);

                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    
                    


                }
                if (graph[i].Count > 0)
                {
                    Stack<int> stack = new Stack<int>();
                    stack.Push(i);

                    while (stack.Count>0)
                    {
                        int node = stack.Pop();
                        foreach (var item in graph[i])
                        {
                            if (!visited.Contains(item))
                            {
                                visited.Add(item);
                                stack.Push(node);
                            }
                        }

                    }
                }

                count++;


            }

            return count;
        }
    }
}
