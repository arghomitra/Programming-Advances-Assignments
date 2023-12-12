using System;
using System.IO;
using Module_07;

namespace _07_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                Assignment assignment = new Assignment();
                int input = int.Parse(Console.ReadLine());
                if (input < 0) { Console.WriteLine("Crazy input!"); }
                else
                {
                    List<int> list = assignment.Sum(input);
                    Console.WriteLine(string.Join(" ", list));
                    Console.WriteLine(list.Sum());
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Crazy input!"); ;
            }
            
            
        }

    }
}