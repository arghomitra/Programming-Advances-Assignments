using System;
using System.IO;
using System.Collections.Generic;
using Module_05;
namespace Module_05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Subset subset = new Subset();
                List<List<int>> result = new List<List<int>>();
                subset.Combinationas(number, 1, new List<int>(), result);

                foreach (var item in result)
                {
                    Console.WriteLine(String.Join(" ", item));
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Crazy input!");
            }
            
        }
        
    }
}