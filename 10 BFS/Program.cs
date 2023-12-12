using System;
using System.IO;
using Module_10;

namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().Trim();

                int[] inputArray = Array.ConvertAll(input.Split(" "), int.Parse);

                BFS bFS = new BFS();
                foreach (int i in inputArray)
                {
                    bFS.Add(i);
                }


                Console.WriteLine(bFS.BratchFirstSearch());
            }
            catch (Exception)
            {

                Console.WriteLine("Crazy input!"); ;
            }
            


        }
    }
}