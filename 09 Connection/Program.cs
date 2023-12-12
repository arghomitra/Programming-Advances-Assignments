using System;
using System.IO;
using Module_09;

namespace _09_Connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());
                Assignment assignment = new Assignment(nodes);
                for (int i = 0; i < edges; i++)
                {
                    string[] input = Console.ReadLine().Split(",");
                    assignment.AddEdge(int.Parse(input[0]), int.Parse(input[1]));
                }




                //Console.WriteLine(assignment.ToString());
                Console.WriteLine(assignment.Connection(0));

            }
            catch (Exception)
            {

                Console.WriteLine("Crazy input!"); ;
            }
            
        }
    }
}