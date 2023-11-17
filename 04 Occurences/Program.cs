using System;
using System.IO;
namespace Module_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int find = Convert.ToInt32(Console.ReadLine());
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);


                //Console.WriteLine(numbers[1].ToString());
                //Console.WriteLine(numbers.Length);
                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Occurences(numbers, find));
            }
            catch 
            {
                Console.WriteLine("Crazy input!");
            }
            
        }

        public class Assignment 
        { 
            public int Occurences(int[] numberes,  int find,int i= 0)
            {
                int count = 0;
                if (i >= numberes.Length)
                {
                    return count;
                }

                if (numberes[i]== find) count++;
                return count+ Occurences( numberes, find, i +1);

            }
        }

    }
}