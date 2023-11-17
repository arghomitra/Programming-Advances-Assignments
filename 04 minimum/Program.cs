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
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Assignment assignment = new Assignment();
                int min = numbers[0];
                Console.WriteLine(assignment.Minimum(numbers, min));
            }
            catch 
            {

                Console.WriteLine("Crazy input!"); ;
            }
            


        }

        public class Assignment
        {
            public int Minimum(int[] numbers,int min,int i = 0) 
            {
                
                if (i >= numbers.Length)
                {
                    return min;
                }

                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                

                return Minimum(numbers, min, i + 1);
                
            }
        }
    }
}